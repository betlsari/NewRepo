using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console
{
    public partial class Forum : Form
    {
        private string postsFile = "posts.txt";       // Gönderiler için dosya
        private string commentsFile = "comments.txt"; // Yorumlar için dosya
        public Forum()
        {
            InitializeComponent();
            LoadPosts();
        }

        private void Forum_Load(object sender, EventArgs e)
        {

        }
        private void LoadPosts()
        {
            lstPosts.Items.Clear();
            if (File.Exists(postsFile))
            {
                string[] posts = File.ReadAllLines(postsFile);
                foreach (var post in posts)
                {
                    lstPosts.Items.Add(post);
                }
            }
        }




        // Listeden bir gönderi seçildiğinde yorumları yükle
        private void lstPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPosts.SelectedItem != null)
            {
                string selectedPost = lstPosts.SelectedItem.ToString();
                LoadComments(selectedPost);
            }
        }

        // Yorumları dosyadan yükle
        private void LoadComments(string selectedPost)
        {
            lstComments.Items.Clear();
            if (File.Exists(commentsFile))
            {
                string[] comments = File.ReadAllLines(commentsFile);
                foreach (var comment in comments)
                {
                    if (comment.StartsWith(selectedPost + ":")) // Yorum gönderiyle eşleşiyor mu?
                    {
                        lstComments.Items.Add(comment.Replace(selectedPost + ":", ""));
                    }
                }
            }
        }





        // Yorum ekle butonuna tıklandığında çalışır


        private void btnAddComment_Click(object sender, EventArgs e)
        {
            if (lstPosts.SelectedItem != null)
            {
                string selectedPost = lstPosts.SelectedItem.ToString();
                string comment = txtComment.Text.Trim();

                if (!string.IsNullOrEmpty(comment))
                {
                    File.AppendAllText(commentsFile, $"{selectedPost}:{comment}" + Environment.NewLine);
                    MessageBox.Show("Yorum başarıyla eklendi!");
                    txtComment.Clear();
                    LoadComments(selectedPost); // Listeyi güncelle
                }
                else
                {
                    MessageBox.Show("Yorum boş olamaz!");
                }
            }
            else
            {
                MessageBox.Show("Bir gönderi seçin!");
            }
        }
        // Gönderi ekle butonuna tıklandığında çalışır
        private void btnAddPosts_Click_1(object sender, EventArgs e)
        {

            string title = txtTitle.Text.Trim();
            string content = txtContent.Text.Trim();

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(content))
            {
                string post = $"{title} - {content}";
                File.AppendAllText(postsFile, post + Environment.NewLine); // Dosyaya yaz
                MessageBox.Show("Gönderi başarıyla eklendi!");
                txtTitle.Clear();
                txtContent.Clear();
                LoadPosts(); // Listeyi güncelle
            }
            else
            {
                MessageBox.Show("Başlık ve içerik boş olamaz!");
            }
        }

    }
}
