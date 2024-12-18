using Console.Oğulcan;
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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void Services_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecenekSayfası sf1 = new SecenekSayfası();
            sf1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forum fr= new Forum();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ilan form1 = new Ilan();
            form1.Show();
            this.Hide();
        }
    }
}
