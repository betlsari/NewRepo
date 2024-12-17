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
        public Register()
        {
            InitializeComponent();
            textBox3.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox3.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Please Do Not Leave Empty Values.", "Incorrect Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            if (textBox3.Text != "" && textBox1.Text != "")
            {
                if (textBox1.Text == Properties.Settings.Default.username && textBox3.Text == Properties.Settings.Default.password)
                {
                    MessageBox.Show("Welcome!");
                    string userName = textBox1.Text;
                    UserManagement anaForm = new UserManagement(userName);
                    anaForm.Show(); // Yeni formu açar.
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Username or Password is Incorrect.");
                }
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            RegisterPage form2 = new RegisterPage(); //Create an instance of Form2

            form2.Show(); //Show Form2 modally

        }



        private void button4_Click(object sender, EventArgs e)
        {
            ResetPage form3 = new ResetPage();
            form3.Show();


        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Register_Load_1(object sender, EventArgs e)
        {

        }
    }
}
