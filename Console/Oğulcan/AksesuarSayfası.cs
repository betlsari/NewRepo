using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Console.Oğulcan
{
    public partial class AksesuarSayfası : Form
    {
        //The codes for opening a file for saving the data
        private string filePath3 = "listbox_data3.text";


        public AksesuarSayfası()
        {
            InitializeComponent();

        }

       
        


        private void Form3_Load(object sender, EventArgs e)
        {
            //this code show all datas in the file on the listbox
            if (File.Exists(filePath3))
            {
                string[] items = File.ReadAllLines(filePath3);

                listBox1.Items.AddRange(items);
            }

        }

       


        private void button2_Click_1(object sender, EventArgs e)
        {
            //it is showing on the screen labels and textbox for taking inputs from the users to list in the listbox
            textBox1.Visible = true;
            textBox2.Visible = true;
            lblAksesuar.Visible = true;
            lblAksesuarFiyat.Visible = true;
            button3.Visible = true;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //it shows the listbox and datas inside it
            listBox1.Visible = true;
            label2.Visible = true;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            //this code is send the datas to listbox for listing datas
            string aksesuarAdi = textBox1.Text;
            string aksesuarFiyati = textBox2.Text;

            if (string.IsNullOrEmpty(aksesuarAdi) || string.IsNullOrEmpty(aksesuarFiyati))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            listBox1.Items.Add(aksesuarAdi + " - " + aksesuarFiyati + " TL");

            File.WriteAllLines(filePath3, listBox1.Items.Cast<string>());


        }

        private void btnGeriDön_Click_1(object sender, EventArgs e)
        {
            //it goes to the previous page
            SecenekSayfası geridön = new SecenekSayfası();
            geridön.Show();
            this.Hide();
        }
    }

}
