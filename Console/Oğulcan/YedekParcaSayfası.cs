using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Console.Oğulcan
{
    public partial class YedekParcaSayfası : Form
    {
        //The codes for opening a file for saving the data
        private string filePath = "listbox_data.text";
        private string filePath2 = "listbox_data2.text";
        public YedekParcaSayfası()
        {
            InitializeComponent();
        }

        private void btnYdkParcaİlan_Click(object sender, EventArgs e)
        {
            //This code make lavel and textbox visible labels are used for asking information and textbox used for taking that information from user
            comboBox1.Visible = true;
            lblİlanDurum.Visible = true;
            btnİlanAktar.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
        }

        private void btnİlanGöster_Click(object sender, EventArgs e)
        {
            //That part used for showing the inputs from taken the users
            listBox1.Visible = true;
            label2.Visible = true;
            listBox2.Visible = true;
            label9.Visible = true;
        }

        private void btnİlanAktar_Click(object sender, EventArgs e)
        {
            //This variables used for holding the inputs from taken the users
            string marka, model, parca, yil, fiyat;

            marka = textBox1.Text;
            model = textBox2.Text;
            parca = textBox3.Text;
            yil = textBox4.Text;
            fiyat = textBox5.Text;

            //this if part checks the inputs are in the corretct form
            if (string.IsNullOrWhiteSpace(marka) || string.IsNullOrWhiteSpace(model) ||
                string.IsNullOrWhiteSpace(parca) || string.IsNullOrWhiteSpace(yil) ||
                string.IsNullOrWhiteSpace(fiyat))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Lütfen Bir Seçim Yapınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            //the if codes used for classification  the inputs and then add the inputs to the combobox
            if (comboBox1.Text == "Sıfır")
            {
                listBox1.Items.Add(marka + "/" + model + "/" + parca + "/" + yil + "/" + fiyat);

                //this code read all text in the file that we save data
                File.WriteAllLines(filePath, listBox1.Items.Cast<string>());

                MessageBox.Show("İlan Eklenmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (comboBox1.Text == "İkinciEl")
            {
                listBox2.Items.Add(marka + "/" + model + "/" + parca + "/" + yil + "/" + fiyat);

                File.WriteAllLines(filePath2, listBox2.Items.Cast<string>());

                MessageBox.Show("İlan Eklenmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            //this code opens the previous page
            SecenekSayfası geridön = new SecenekSayfası();
            geridön.Show();
            this.Hide();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //this code show all datas in the file on the listbox
            if (File.Exists(filePath))
            {
                string[] items = File.ReadAllLines(filePath);
                listBox1.Items.AddRange(items);
            }
            if (File.Exists(filePath2))
            {
                string[] items = File.ReadAllLines(filePath2);
                listBox2.Items.AddRange(items);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //that code opens an another information part when we click a index included in listbox
            string selectedItem = listBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedItem))
                return;

            DisplayDetails(selectedItem);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox2.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedItem))
                return;

            DisplayDetails(selectedItem);
        }


        private void DisplayDetails(string selectedItem)
        {
            //when we click any index included listbox this part parts the data inside the list box and show it on the screen
            string[] parts = selectedItem.Split('/');

            if (parts.Length == 5)
            {
                lblMarkaGöster.Text = parts[0];
                lblModelGöster.Text = parts[1];
                lblYilGöster.Text = parts[2];
                lblParcaGöster.Text = parts[3];
                lblFiyatGöster.Text = parts[4];

                ClearAndShowDetails();


            }
            else
            {
                MessageBox.Show("Hatalı Veri Formatı!!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAndShowDetails()
        {
            //it makes all other information parts visible
            lblMarkaGöster.Visible = true;
            lblModelGöster.Visible = true;
            lblYilGöster.Visible = true;
            lblParcaGöster.Visible = true;
            lblFiyatGöster.Visible = true;
            lblMarka.Visible = true;
            lblModel.Visible = true;
            lblYil.Visible = true;
            lblParca.Visible = true;
            lblFiyat.Visible = true;
        }
    }
}
}
