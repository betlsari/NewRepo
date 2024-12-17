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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }
        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {

        }

        public UserManagement(string userName)
        {
            InitializeComponent();

            userName0 = userName;


            // Kullanıcı bilgileri
            this.userName.Text = userName; // Örnek kullanıcı adı

            // Favori ilanlar
            MessageBox.Show("Lütfen bir ilan başlığı seçin.");
            comboBoxAd.Items.Add("2020 Model Ford Focus");
            comboBoxAd.Items.Add("2018 Model BMW 3 Serisi");
            comboBoxAd.Items.Add("2021 Model Tesla Model 3");
            comboBoxAd.Items.Add("2019 Model Audi A4");
            comboBoxAd2.Items.Add("2020 Model Ford Focus");
            comboBoxAd2.Items.Add("2018 Model BMW 3 Serisi");
            comboBoxAd2.Items.Add("2021 Model Tesla Model 3");
            comboBoxAd2.Items.Add("2019 Model Audi A4");

        }




        private void button1_Click(object sender, EventArgs e)
        {
            // Satıcı İletişimi formuna geçiş
            SaticiIletisim saticiIletisimFormu = new SaticiIletisim();
            saticiIletisimFormu.Show();
            // Form1'e kullanıcı adı gönderilir



            // Bu form kapatılır
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedAd = comboBoxAd.SelectedItem?.ToString();

            // Eğer bir ilan başlığı seçilmişse
            if (!string.IsNullOrEmpty(selectedAd))
            {
                // Seçilen ilana göre ilgili formu aç
                if (selectedAd == "2020 Model Ford Focus")
                {
                    // Ford Focus ilanına ait formu aç
                    FordFocus fordFocusForm = new FordFocus();
                    fordFocusForm.Show();
                }
                else if (selectedAd == "2018 Model BMW 3 Serisi")
                {
                    // BMW 3 Serisi ilanına ait formu aç
                    Bmw3 bmwForm = new Bmw3();
                    bmwForm.Show();
                }
                else if (selectedAd == "2021 Model Tesla Model 3")
                {
                    // Tesla Model 3 ilanına ait formu aç
                    TeslaModel3 teslaForm = new TeslaModel3();
                    teslaForm.Show();
                }
                else if (selectedAd == "2019 Model Audi A4")
                {
                    // Audi A4 ilanına ait formu aç
                    AudiA4 audiForm = new AudiA4();
                    audiForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ilan başlığı seçin.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string selectedAd = comboBoxAd2.SelectedItem?.ToString();

            // Eğer bir ilan başlığı seçilmişse
            if (!string.IsNullOrEmpty(selectedAd))
            {
                // Seçilen ilana göre ilgili formu aç
                if (selectedAd == "2020 Model Ford Focus")
                {
                    // Ford Focus ilanına ait formu aç
                    FordFocus fordFocusForm = new FordFocus();
                    fordFocusForm.Show();
                }
                else if (selectedAd == "2018 Model BMW 3 Serisi")
                {
                    // BMW 3 Serisi ilanına ait formu aç
                    Bmw3 bmwForm = new Bmw3();
                    bmwForm.Show();
                }
                else if (selectedAd == "2021 Model Tesla Model 3")
                {
                    // Tesla Model 3 ilanına ait formu aç
                    TeslaModel3 teslaForm = new TeslaModel3();
                    teslaForm.Show();
                }
                else if (selectedAd == "2019 Model Audi A4")
                {
                    // Audi A4 ilanına ait formu aç
                    AudiA4 audiForm = new AudiA4();
                    audiForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ilan başlığı seçin.");
            }
        }
    }
}
    
