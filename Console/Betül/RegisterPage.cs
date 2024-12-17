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
        public RegisterPage()
        {
            

            InitializeComponent();
            password0.PasswordChar = '*';
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password0.PasswordChar = '\0';
            }
            else
            {
                password0.PasswordChar = '*';
            }
        }


        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password0.PasswordChar = '\0';
            }
            else
            {
                password0.PasswordChar = '*';
            }
        }

        private void Register_Click_1(object sender, EventArgs e)
        {
            if (name0.Text == "" || surname0.Text == "" || userName0.Text == "" || password0.Text == "")
            {
                MessageBox.Show("\r\nPlease Do Not Leave Empty Values.", "Incorrect Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                Properties.Settings.Default.name = name0.Text;
                Properties.Settings.Default.surname = surname0.Text;
                Properties.Settings.Default.username = userName0.Text;
                Properties.Settings.Default.password = password0.Text;
                Properties.Settings.Default.email = eMail.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Registration successful!", "Succesful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string savedUsername = Properties.Settings.Default.username;
            string savedPassword = Properties.Settings.Default.password;


        }


    }
}
