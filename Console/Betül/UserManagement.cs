using Console.Betül;
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
    public partial class UserManagement : Form
    {
        private string userName0; // Variable to store the user's name

        // Default constructor for the UserManagement form
        public UserManagement()
        {
            InitializeComponent();
        }

        // Constructor that takes a user name as an argument
        public UserManagement(string userName)
        {
            InitializeComponent();

            userName0 = userName; // Store the user name

            // Set the user name on the form (e.g., a label or textbox)
            this.userName.Text = userName;

            // Add some sample favorite listings to the combo boxes
            MessageBox.Show("Lütfen bir ilan başlığı seçin."); // Show a message prompting the user to select a listing title
            comboBoxAd.Items.Add("2020 Model Ford Focus");
            comboBoxAd.Items.Add("2019 Model Audi A4");
            comboBoxAd2.Items.Add("2020 Model Ford Focus");
            comboBoxAd2.Items.Add("2019 Model Audi A4");
        }

        // Event handler for the first button click (to go to the Seller Communication form)
        private void button1_Click(object sender, EventArgs e)
        {
            // Open the "Seller Communication" form
            SaticiIletisim saticiIletisimFormu = new SaticiIletisim();
            saticiIletisimFormu.Show();

            // Hide the current form (User Management form)
            this.Hide();
        }

        // Event handler for the second button click (to select a listing and view its details)
        private void button2_Click(object sender, EventArgs e)
        {
            string selectedAd = comboBoxAd.SelectedItem?.ToString(); // Get the selected item in comboBoxAd

            // If a listing title is selected
            if (!string.IsNullOrEmpty(selectedAd))
            {
                // Open the relevant form based on the selected listing
                if (selectedAd == "2020 Model Ford Focus")
                {
                    // Open the form for the Ford Focus listing
                    FordFocus fordFocusForm = new FordFocus();
                    fordFocusForm.Show();
                }
                else if (selectedAd == "2019 Model Audi A4")
                {
                    // Open the form for the Audi A4 listing
                    AudiA4 audiForm = new AudiA4();
                    audiForm.Show();
                }
            }
            else
            {
                // If no listing title is selected, show a message asking the user to select one
                MessageBox.Show("Lütfen bir ilan başlığı seçin.");
            }
        }

        // Event handler for the third button click (to select another listing and view its details)
        private void button1_Click_1(object sender, EventArgs e)
        {
            string selectedAd = comboBoxAd2.SelectedItem?.ToString(); // Get the selected item in comboBoxAd2

            // If a listing title is selected
            if (!string.IsNullOrEmpty(selectedAd))
            {
                // Open the relevant form based on the selected listing
                if (selectedAd == "2020 Model Ford Focus")
                {
                    // Open the form for the Ford Focus listing
                    FordFocus fordFocusForm = new FordFocus();
                    fordFocusForm.Show();
                }
                else if (selectedAd == "2019 Model Audi A4")
                {
                    // Open the form for the Audi A4 listing
                    AudiA4 audiForm = new AudiA4();
                    audiForm.Show();
                }
            }
            else
            {
                // If no listing title is selected, show a message asking the user to select one
                MessageBox.Show("Lütfen bir ilan başlığı seçin.");
            }
            
        }
    }
}