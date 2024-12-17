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
    public partial class RegisterPage : Form
    {
        // Constructor for the RegisterPage form, initializes components and sets up the password field
        public RegisterPage()
        {
            InitializeComponent();
            password0.PasswordChar = '*'; // Set the password character to '*' for security
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {
            // Event handler for the form's Load event (currently empty)
        }

        // Event handler for the checkbox to toggle password visibility
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) // If the checkbox is checked, show the password in plain text
            {
                password0.PasswordChar = '\0'; // Remove the password masking character
            }
            else // If the checkbox is unchecked, mask the password with '*'
            {
                password0.PasswordChar = '*'; // Set the password character to '*'
            }
        }

        // Duplicate event handler for password visibility toggle (same functionality as the previous one)
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked) // If the checkbox is checked, show the password in plain text
            {
                password0.PasswordChar = '\0'; // Remove the password masking character
            }
            else // If the checkbox is unchecked, mask the password with '*'
            {
                password0.PasswordChar = '*'; // Set the password character to '*'
            }
        }

        // Event handler for the registration button click
        
            private void Register_Click_1(object sender, EventArgs e)
            {
                // Kullanıcı adı daha önce kaydedilmiş mi kontrol et
                string savedUserName = Properties.Settings.Default.username;

                // Kullanıcı adı daha önce kaydedilmişse, kayıt yapılmasın
                if (savedUserName != null && savedUserName == userName0.Text)
                {
                    MessageBox.Show("You are already registered with this username.", "Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Bu durumda fonksiyondan çık ve işlemi durdur
                }

                // Kayıt işleminden önce, herhangi bir alan boş mu kontrol et
                if (name0.Text == "" || surname0.Text == "" || userName0.Text == "" || password0.Text == "")
                {
                    MessageBox.Show("\r\nLütfen Boş Değer Bırakmayın.", "Incorrect Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Kullanıcı bilgilerini kaydet
                    Properties.Settings.Default.name = name0.Text;
                    Properties.Settings.Default.surname = surname0.Text;
                    Properties.Settings.Default.username = userName0.Text;
                    Properties.Settings.Default.password = password0.Text;
                    Properties.Settings.Default.email = eMail.Text; // E-posta bilgisi de kaydediliyor
                    Properties.Settings.Default.Save(); // Ayarları kaydet

                    // Başarı mesajı
                    MessageBox.Show("Kayıt Başarılı!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }



        }
    }
