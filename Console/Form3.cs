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
    public partial class Form3 : Form
    {

        public forgotPassword()
        {
            InitializeComponent();
            txtNewPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';

        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtNewPassword.PasswordChar = '\0';
            }
            else
            {
                txtNewPassword.PasswordChar = '*';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void reset_Click_1(object sender, EventArgs e)
        {
            string username = userName.Text;
            string email = txtEmail.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string oldPassword = Properties.Settings.Default.password;


            //Check email address
            if (email == "")
            {
                MessageBox.Show("E mail field cannot be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (username == "")
            {
                MessageBox.Show("Username field cannot be left blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (newPassword == "" || confirmPassword == "")
            {
                MessageBox.Show("Password field cannot be left blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (oldPassword == newPassword)
            {
                MessageBox.Show("\r\nNew password and old password must be different!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            string savedEmail = Properties.Settings.Default.email;
            string savedUsername = Properties.Settings.Default.username;
            // E-mail address and username verification is done
            if (savedEmail != email || savedUsername != username)
            {
                MessageBox.Show("Username or email address is incorrect. Please check again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Password verification
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }



            // Check user if passwords are the same
            if (oldPassword == newPassword)
            {
                MessageBox.Show("The old password and the new password cannot be the same. Please enter a different password.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // If the password reset is successful:
                // Here you can save the new password or perform the password reset.
                // For example, you can save the password in the database or application settings.

                // After the password reset process is completed:
                MessageBox.Show("Your password has been successfully reset.",
                                "Successful.", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //Saving the new password:
                Properties.Settings.Default.password = newPassword;
                Properties.Settings.Default.Save();

            }
        }

        private void forgotPassword_Load(object sender, EventArgs e)
        {

        }
    }

}

