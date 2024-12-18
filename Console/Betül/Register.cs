using Console.Samet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console.Betül
{
    public partial class Register : Form
    {
        // Constructor for the Register form, initializes components and sets up password field
        public Register()
        {
            InitializeComponent();
            textBox3.PasswordChar = '*'; // Set the default password character to '*' for security
        }

        // Event handler for the checkbox to toggle password visibility
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) // If the checkbox is checked, show the password in plain text
            {
                textBox3.PasswordChar = '\0'; // Remove the password masking character
            }
            else // If the checkbox is unchecked, mask the password with '*'
            {
                textBox3.PasswordChar = '*'; // Set the password character to '*'
            }
        }

        // Event handler for the login button click
        private void button2_Click(object sender, EventArgs e)
        {
            // Check if the username or password fields are empty
            if (textBox3.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayın.", "Incorrect Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // If both fields are filled, check if they match the stored credentials
            if (textBox3.Text != "" && textBox1.Text != "")
            {
                if (textBox1.Text == Properties.Settings.Default.username && textBox3.Text == Properties.Settings.Default.password)
                {
                    MessageBox.Show("Hoşgeldiniz!"); // Show a welcome message
                    string userName = textBox1.Text; // Store the entered username
                    UserManagement anaForm = new UserManagement(userName); // Create a new instance of the UserManagement form
                    anaForm.Show(); // Open the UserManagement form
                    this.Hide(); // Hide the current form (login screen)
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı ya da Parola Hatalı."); // Show an error message if credentials do not match
                }
            }
        }

        // Event handler for the registration button click (empty for now)
        private void button1_Click(object sender, EventArgs e)
        {
            // Code for this button is not defined yet
        }

        // Event handler for the registration page button click
        private void button1_Click_1(object sender, EventArgs e)
        {
            RegisterPage form2 = new RegisterPage(); // Create an instance of the RegisterPage form
            form2.Show(); // Show the RegisterPage form
        }

        // Event handler for the reset password button click
        private void button4_Click(object sender, EventArgs e)
        {
            ResetPage form3 = new ResetPage(); // Create an instance of the ResetPage form
            form3.Show(); // Show the ResetPage form
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenü();
            mainMenu.Show();
            this.Hide();
        }
    }
}