using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer;
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
    public partial class RentaledCarsForm : Form
    {
        // Constructor method to initialize the form and its components
        public RentaledCarsForm()
        {
            InitializeComponent();
        }

        // This method is called when the form is loaded
        // It loads the list of rentals that have cars associated with them
        private void RentaledCarsForm_Load(object sender, EventArgs e)
        {
            ListOfRentals(); // Load the list of rentals when the form is loaded
        }

        // This method retrieves and displays the list of rentals with associated car models
        private void ListOfRentals()
        {
            // Create a RentalManager to manage rental operations
            RentalManager rentalManager = new RentalManager(new RentalDal());

            // Set the data source of the DataGridView to the rentals with car models
            dgwRentals.DataSource = rentalManager.GetRentalsWithCarModels();

            // Hide unwanted columns to make the DataGridView cleaner
            dgwRentals.Columns["RentalId"].Visible = false; // Hide the RentalId column
            dgwRentals.Columns["UserId"].Visible = false; // Hide the UserId column
        }

        // This method is triggered when the "Back to Rental Form" button is clicked
        // It opens the RentalForm and hides the current form


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var RentalForm = new RentalForm(); // Create a new instance of the RentalForm
            RentalForm.Show(); // Show the RentalForm
            this.Hide(); // Hide the current RentaledCarsForm
        }

        private void dgwRentals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
