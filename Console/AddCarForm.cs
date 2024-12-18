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
    public partial class AddCarForm : Form
    {
        // Constructor for initializing the form and loading the car list
        public AddCarForm()
        {
            InitializeComponent();
            ListOfCars(); // Call the method to list available cars when the form loads
        }

        // Method to list available cars in the DataGridView
        private void ListOfCars()
        {
            // The code for fetching car models from the database is currently commented out.
            // However, available cars are still being listed in the DataGridView (dgwFilter).

            using (AppDbContext context = new AppDbContext())
            {
                // Fetch unique car models from the database
                var carModels = context.Cars
                    .Select(c => c.Model)
                    .Distinct()
                    .ToList();

                // Note: The ComboBox for selecting car models is not populated in this method currently.
            }

            // Display available cars in the DataGridView using the CarManager class
            CarManager _carManager = new CarManager(new CarDal());
            dgwFilter.DataSource = _carManager.GetAvailableCars();

            // Hide the 'isAvailable' column as it is not necessary for the user to see it
            dgwFilter.Columns["isAvailable"].Visible = false;
        }

        // Event handler for adding a new car to the database when the "Add" button is clicked
        private void btnAddListing_Click(object sender, EventArgs e)
        {
            // Check if the car model input is empty or just white space
            if (string.IsNullOrWhiteSpace(txtAddModel.Text))
            {
                MessageBox.Show("Please enter a car model!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate the price input, ensuring it is a valid integer and greater than 0
            if (!int.TryParse(txtAddPrice.Text, out int price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Retrieve values from the form fields
                string model = txtAddModel.Text;
                bool isAvailable = chkIsAvailable.Checked;

                // Ensure that the price is a valid integer
                if (!int.TryParse(txtAddPrice.Text, out int carPrice))
                {
                    MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new Car object with the collected data
                var newCar = new Car
                {
                    Model = model,
                    Price = price,
                    isAvailable = isAvailable
                };

                // Add the new car to the database
                using (AppDbContext context = new AppDbContext())
                {
                    context.Cars.Add(newCar);
                    context.SaveChanges();
                }

                // Notify the user that the car has been added successfully
                MessageBox.Show("Car successfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the input fields for new entries
                txtAddModel.Text = string.Empty;
                txtAddPrice.Text = string.Empty;
                chkIsAvailable.Checked = false;

                // Refresh the car list to show the newly added car
                ListOfCars();
            }
            catch (Exception ex)
            {
                // Show an error message if any exception occurs
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for form load (currently not used but can be added for additional setup)
        private void AddCarForm_Load(object sender, EventArgs e)
        {
        }

        // Event handler for navigating back to the previous form (Ilan form)
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var Form1 = new Ilan();
            Form1.Show(); // Show the Ilan form
            this.Hide(); // Hide the current form
        }
    }
}
