using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SaticiIletisim : Form
    {
        public SaticiIletisim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcının yazdığı mesajı al ve göster
            string mesaj = txtMesaj.Text;
            MessageBox.Show($"Mesaj Gönderildi: {mesaj}", "Bilgi");
        }
    }
}
