using BusinessLayer.Concrete;
using DataAccessLayer;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console
{
    public partial class RentalForm : Form
    {
        // Constructor method to initialize the form and its components
        public RentalForm()
        {
            InitializeComponent();
        }

        // This method is called when the form is loaded
        // It will load the list of available cars
        private void RentalForm_Load(object sender, EventArgs e)
        {
            ListOfCars();
        }

        // Timer function created to periodically check car availability
        private void TimerFunc()
        {
            Timer timer = new Timer();
            timer.Interval = 10000; // 10 seconds interval for checking
            timer.Tick += Timer_Tick; // On each tick, the Timer_Tick method will be called
            timer.Start();
        }

        // This method is triggered on each tick of the timer (every 10 seconds)
        // It will update the car availability based on rental end dates
        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateCarAvailability();
        }

        // This method updates the availability of cars based on the rental end date
        private void UpdateCarAvailability()
        {
            using (AppDbContext context = new AppDbContext())
            {
                DateTime today = DateTime.Now;

                // Get rentals where the end date is before today
                var rentals = context.Rentals
                    .Where(r => r.EndDate < today)
                    .ToList();

                // Loop through the rentals and make the cars available again
                foreach (var rental in rentals)
                {
                    var car = context.Cars.FirstOrDefault(c => c.CarId == rental.CarId);
                    if (car != null && !car.isAvailable)
                    {
                        car.isAvailable = true;  // Mark the car as available
                    }
                }

                context.SaveChanges(); // Save the changes to the database
            }
            ListOfCars(); // Refresh the list of available cars
        }

        // This method loads the list of available cars and updates the DataGridView
        private void ListOfCars()
        {
            using (AppDbContext context = new AppDbContext())
            {
                // Retrieve distinct car models from the database
                var carModels = context.Cars
                    .Select(c => c.Model)
                    .Distinct()
                    .ToList();

                // The ComboBox could be populated with the car models here
            }

            // Load the available cars into the DataGridView
            CarManager _carManager = new CarManager(new CarDal());
            dgwFilter.DataSource = _carManager.GetAvailableCars(); // Fetch available cars

            dgwFilter.Columns["isAvailable"].Visible = false; // Hide the isAvailable column
        }

        // This method handles the process of renting a car
        private void RentCar(int carId, DateTime startDate, DateTime endDate)
        {
            if (startDate >= endDate)
            {
                MessageBox.Show("Start date must be before the end date.");
                return;
            }

            using (AppDbContext context = new AppDbContext())
            {
                var car = context.Cars.FirstOrDefault(c => c.CarId == carId);
                if (car != null && car.isAvailable)
                {
                    car.isAvailable = false; // Mark the car as unavailable once rented

                    var rental = new Rental
                    {
                        CarId = carId,
                        UserId = GetCurrentUserId(), // Get the current user's ID
                        StartDate = startDate,
                        EndDate = endDate
                    };

                    context.Rentals.Add(rental); // Add the rental record to the database
                    context.SaveChanges(); // Save changes to the database

                    MessageBox.Show("Car rented successfully.");
                }
                else
                {
                    MessageBox.Show("This car is already rented.");
                }
            }

            ListOfCars(); // Refresh the car list after the rental
        }

        // This method simulates getting the current user's ID
        private int GetCurrentUserId()
        {
            return 1; // Here, we return a static user ID (in real applications, get this from the logged-in user)
        }

        // This method is triggered when the Rent button is clicked
        private void btnRent_Click(object sender, EventArgs e)
        {
            if (dgwFilter.SelectedRows.Count > 0)
            {
                // Get the selected car ID
                int selectedCarId = Convert.ToInt32(dgwFilter.SelectedRows[0].Cells["CarId"].Value);
                DateTime startDate = dtpStartDate.Value.Date;
                DateTime endDate = dtpEndDate.Value.Date;

                RentCar(selectedCarId, startDate, endDate); // Rent the car with the selected dates
            }
            else
            {
                MessageBox.Show("Please select a car.");
            }
        }

        // This method is triggered when the 'Ilan' button is clicked
  
        // This method is triggered when the 'Rentaled Cars' button is clicked
        // It opens the form to show rented cars
        private void goToRentaledForm_Click(object sender, EventArgs e)
        {

            var RentaledCarsForm = new RentaledCarsForm();
            RentaledCarsForm.Show();
            this.Hide(); // Hide the current form
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            var Form1 = new Ilan();
            Form1.Show();
            this.Hide(); // Hide the current form
        }
    }
}
