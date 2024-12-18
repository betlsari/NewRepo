using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console.Oğulcan
{
    public partial class SecenekSayfası : Form
    {
        public SecenekSayfası()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //When we click the button another page is openning
            YedekParcaSayfasi yedekparca = new YedekParcaSayfasi();
            yedekparca.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //When we click the button another page is openning
            AksesuarSayfası aksesuar = new AksesuarSayfası();
            aksesuar.Show();
            this.Hide();
        }

    }
}
