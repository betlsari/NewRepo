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
    public partial class FordFocus : Form
    {
        public FordFocus()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaticiIletisim st = new SaticiIletisim();
            st.ShowDialog();
            this.Hide();
        }


        private void FordFocus_Load(object sender, EventArgs e)
        {

        }

    }
}
