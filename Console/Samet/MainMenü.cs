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

namespace Console.Samet
{
    public partial class MainMenü : Form
    {
        public MainMenü()
        {
            InitializeComponent();
        }

        private void MainMenü_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();


        }

        private void servisesBtn_Click(object sender, EventArgs e)
        {
            Services sv = new Services();
            sv.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
