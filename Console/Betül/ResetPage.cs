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
    public partial class ResetPage : Form
    {
        // Constructor for the ResetPage form, initializes components and sets up the password fields
        public ResetPage()
        {
            InitializeComponent();
            txtNewPassword.PasswordChar = '*'; // Mask the new password with '*' by default
            txtConfirmPassword.PasswordChar = '*'; // Mask the confirm password with '*' by default
        }

        private void ResetPage_Load(object sender, EventArgs e)
        {
            // Event handler for the form's Load event (currently empty)
        }

        // Event handler for the checkbox to toggle visibility of the new password
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) // If the checkbox is checked, show the new password in plain text
            {
                txtNewPassword.PasswordChar = '\0'; // Remove the password masking character
            }
            else // If the checkbox is unchecked, mask the password with '*'
            {
                txtNewPassword.PasswordChar = '*'; // Set the password character to '*'
            }
        }

        // Event handler for the checkbox to toggle visibility of the confirm password
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) // If the checkbox is checked, show the confirm password in plain text
            {
                txtConfirmPassword.PasswordChar = '\0'; // Remove the password masking character
            }
            else // If the checkbox is unchecked, mask the password with '*'
            {
                txtConfirmPassword.PasswordChar = '*'; // Set the password character to '*'
            }
        }

        // Event handler for the reset button click
        private void reset_Click_1(object sender, EventArgs e)
        {
            string username = userName.Text;
            string email = txtEmail.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string oldPassword = Properties.Settings.Default.password;

            // Check if email field is empty
            if (email == "")
            {
                MessageBox.Show("E-mail alanı boş olamaz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if username field is empty
            if (username == "")
            {
                MessageBox.Show("Kullanıcı Adı alanı boş olamaz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if password or confirm password fields are empty
            if (newPassword == "" || confirmPassword == "")
            {
                MessageBox.Show("Şifre alanı boş olamaz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if the new password is the same as the old password
            if (oldPassword == newPassword)
            {
                MessageBox.Show("\r\nEski şifre ve yeni şifre farklı olmalı!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string savedEmail = Properties.Settings.Default.email;
            string savedUsername = Properties.Settings.Default.username;
            // Verify if the entered email and username match the saved ones
            if (savedEmail != email || savedUsername != username)
            {
                MessageBox.Show("Kullanıcı adı veya e-posta adresi yanlış. Lütfen tekrar kontrol edin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the new password matches the confirm password
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Şifreler uyuşmuyor. Lütfen tekrar deneyin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the new password is different from the old password (redundant, but ensures clear logic)
            if (oldPassword == newPassword)
            {
                MessageBox.Show("\r\nEski şifre ve yeni şifre aynı olamaz. Lütfen farklı bir şifre girin.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // If the password reset is successful, display a success message
                MessageBox.Show("\r\nŞifreniz başarıyla sıfırlandı.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Save the new password to application settings
                Properties.Settings.Default.password = newPassword;
                Properties.Settings.Default.Save();
            }
        }
    }
}