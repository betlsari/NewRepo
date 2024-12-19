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
    public partial class RegisterPage : Form
    {
        // Constructor for the RegisterPage form, initializes components and sets up the password field
        public RegisterPage()
        {
            InitializeComponent();
            password0.PasswordChar = '*'; // Mask the password field with '*' for security
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) // If the checkbox is checked, display the password as plain text
            {
                password0.PasswordChar = '\0'; // Remove the password masking character
            }
            else // If the checkbox is unchecked, mask the password with '*'
            {
                password0.PasswordChar = '*'; // Restore the password masking character
            }
        }
        private void RegisterPage_Load(object sender, EventArgs e)
        {
            // Event handler for the form's Load event (currently empty)
        }

        // Event handler for the checkbox to toggle password visibility
        
        // Event handler for the registration button click
        private void Register_Click_1(object sender, EventArgs e)
        {
            // Check if the username is already registered
            string savedUserName = Properties.Settings.Default.username;

            // If the username already exists, do not allow registration
            if (savedUserName != null && savedUserName == userName0.Text)
            {
                MessageBox.Show("Bu kullanıcı zaten kayıtlı.", "Zaten Kayıtlı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Exit the function and stop further execution
            }

            // Before proceeding with registration, check if any fields are empty
            if (name0.Text == "" || surname0.Text == "" || userName0.Text == "" || password0.Text == "")
            {
                MessageBox.Show("\r\nLütfen boş alan bırakmayın.", "Incorrect Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Save user information
                Properties.Settings.Default.name = name0.Text;
                Properties.Settings.Default.surname = surname0.Text;
                Properties.Settings.Default.username = userName0.Text;
                Properties.Settings.Default.password = password0.Text;
                Properties.Settings.Default.email = eMail.Text; // Save email information as well
                Properties.Settings.Default.Save(); // Save the settings

                // Display success message
                MessageBox.Show("Kayıt Başarılı!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void RegisterPage_Load_1(object sender, EventArgs e)
        {

        }
    }
}





