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
    public partial class AudiA4 : Form
    {
        public AudiA4()
        {
            InitializeComponent();
        }

        private void AudiA4_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaticiIletisim st = new SaticiIletisim();
            st.ShowDialog();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaticiIletisim si = new SaticiIletisim();
            si.ShowDialog();
            this.Hide();
        }
    }
}
