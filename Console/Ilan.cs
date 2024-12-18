using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Console.Betül;
using Console.Samet;
using DataAccessLayer;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Migrations;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Console
{
    public partial class Ilan : Form
    {
        // Constructor to initialize the form
        public Ilan()
        {
            InitializeComponent();
        }

        // This method is triggered when the form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            TimerFunc(); // Starts the timer to check car availability periodically
            ListOfRentals(); // Load the list of rentals (for rental-related operations)
            ListOfCars(); // Load the list of cars (for available car listings)
        }

        // Timer method to check car availability every 10 seconds
        private void TimerFunc()
        {
            Timer timer = new Timer();
            timer.Interval = 10000; // Set the interval to 10 seconds
            timer.Tick += Timer_Tick; // Attach the event handler
            timer.Start(); // Start the timer
        }

        // This method is triggered every time the timer ticks
        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateCarAvailability(); // Update car availability status
        }

        // This method updates the availability of cars based on rental end date
        private void UpdateCarAvailability()
        {
            using (AppDbContext context = new AppDbContext())
            {
                DateTime today = DateTime.Now; // Get today's date

                // Get all rentals where the end date has passed
                var rentals = context.Rentals
                    .Where(r => r.EndDate < today)
                    .ToList();

                foreach (var rental in rentals)
                {
                    // Update the car status to available if the rental has ended
                    var car = context.Cars.FirstOrDefault(c => c.CarId == rental.CarId);
                    if (car != null && !car.isAvailable)
                    {
                        car.isAvailable = true; // Mark the car as available
                    }
                }

                context.SaveChanges(); // Save changes to the database
            }
        }

        // This method loads and displays the list of rentals with car models
        private void ListOfRentals()
        {
            using (AppDbContext context = new AppDbContext())
            {
                // Query to join rentals with car models and get necessary details
                var rentalsWithCars = from rental in context.Rentals
                                      join car in context.Cars
                                      on rental.CarId equals car.CarId
                                      select new
                                      {
                                          RentalId = rental.RentalId,
                                          Model = car.Model,
                                          UserId = rental.UserId,
                                          StartDate = rental.StartDate,
                                          EndDate = rental.EndDate
                                      };
                // dgwRentals.DataSource = rentalsWithCars.ToList(); 
            }
        }

        // This method loads and displays the list of available cars
        private void ListOfCars()
        {
            using (AppDbContext context = new AppDbContext())
            {
                // Get distinct car models to populate ComboBox
                var carModels = context.Cars
                    .Select(c => c.Model)
                    .Distinct()
                    .ToList();

                cbxCar.DataSource = carModels; // Bind car models to ComboBox
            }

            // Get available cars and bind them to DataGridView
            CarManager _carManager = new CarManager(new CarDal());
            dgwFilter.DataSource = _carManager.GetAvailableCars();
            dgwFilter.Columns["isAvailable"].Visible = false; // Hide the availability column
        }

        // This method filters cars based on the selected car model from ComboBox
        private void cbxCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedModel = cbxCar.SelectedItem.ToString(); // Get the selected model
            ListCarsByModel(selectedModel); // Call method to filter cars by model
        }

        // This method filters the cars list based on the selected model
        private void ListCarsByModel(string model)
        {
            using (AppDbContext context = new AppDbContext())
            {
                // Filter cars based on model and availability
                var cars = context.Cars
                    .Where(c => c.Model == model && c.isAvailable == true)
                    .ToList();

                dgwFilter.DataSource = cars; // Bind filtered cars to DataGridView
            }
        }

        // This method filters the cars list based on model name, minimum price, and maximum price
        private void ListCars(string modelKey, int? minPriceKey, int? maxPriceKey)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var query = context.Cars.AsQueryable(); // Start query with all cars

                // Filter by model if provided
                if (!string.IsNullOrEmpty(modelKey))
                {
                    query = query.Where(c => c.Model.Contains(modelKey));
                }

                // Filter by minimum price if provided
                if (minPriceKey.HasValue)
                {
                    query = query.Where(c => c.Price >= minPriceKey.Value);
                }

                // Filter by maximum price if provided
                if (maxPriceKey.HasValue)
                {
                    query = query.Where(c => c.Price <= maxPriceKey.Value);
                }

                // Only show available cars
                query = query.Where(c => c.isAvailable == true);

                // Get the filtered list of cars
                var cars = query.ToList();

                // Bind the filtered cars to DataGridView
                dgwFilter.DataSource = cars;
            }
        }

        // This method is triggered when the text in the model name or price textboxes changes
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            int? minPrice = string.IsNullOrEmpty(txtMinPrice.Text) ? (int?)null : Convert.ToInt32(txtMinPrice.Text);
            int? maxPrice = string.IsNullOrEmpty(txtMaxPrice.Text) ? (int?)null : Convert.ToInt32(txtMaxPrice.Text);

            ListCars(txtName.Text, minPrice, maxPrice); // Call the ListCars method with new filters
        }

        // This method is triggered when the minimum price textbox value changes
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            int? minPrice = string.IsNullOrEmpty(txtMinPrice.Text) ? (int?)null : Convert.ToInt32(txtMinPrice.Text);
            int? maxPrice = string.IsNullOrEmpty(txtMaxPrice.Text) ? (int?)null : Convert.ToInt32(txtMaxPrice.Text);

            ListCars(txtName.Text, minPrice, maxPrice); // Call the ListCars method with updated filters
        }

        // This method is triggered when the "Go to Rental Form" button is clicked
        private void goToRentalFormBtn_Click(object sender, EventArgs e)
        {
            var rentalForm = new RentalForm(); // Create a new instance of RentalForm
            rentalForm.Show(); // Show the RentalForm
            this.Hide(); // Hide the current form
        }

        // This method is triggered when the "Go to Add Car Form" button is clicked
        private void goToAddCarFormBtn_Click(object sender, EventArgs e)
        {
            var addCarForm = new AddCarForm(); // Create a new instance of AddCarForm
            addCarForm.Show(); // Show the AddCarForm
            this.Hide(); // Hide the current form
        }

        // This method is triggered when the maximum price textbox value changes
        private void txtMaxPrice_TextChanged(object sender, EventArgs e)
        {
            int? minPrice = string.IsNullOrEmpty(txtMinPrice.Text) ? (int?)null : Convert.ToInt32(txtMinPrice.Text);
            int? maxPrice = string.IsNullOrEmpty(txtMaxPrice.Text) ? (int?)null : Convert.ToInt32(txtMaxPrice.Text);

            ListCars(txtName.Text, minPrice, maxPrice); // Call the ListCars method with updated filters
        }

        // This method is triggered when the "Register" button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            var Register = new Register(); // Create a new instance of Register form
            Register.Show(); // Show the Register form
            this.Hide(); // Hide the current form
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenü();

            mainMenu.Show();
            this.Hide();
        }
    }
}
