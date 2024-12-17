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
        private string postsFile = "posts.txt";       // File for storing posts
        private string commentsFile = "comments.txt"; // File for storing comments

        public string userName { get; private set; }

        // Constructor for the Forum form, initializes components and loads posts
        public Forum()
        {
            InitializeComponent();
            LoadPosts(); // Load posts from the file when the form is initialized
        }

        private void Forum_Load(object sender, EventArgs e)
        {
            // Event handler for the form's Load event (currently empty)
        }

        // Method to load posts from the "posts.txt" file and display them in the list box
        private void LoadPosts()
        {
            lstPosts.Items.Clear(); // Clear the existing list of posts
            if (File.Exists(postsFile)) // Check if the posts file exists
            {
                string[] posts = File.ReadAllLines(postsFile); // Read all posts from the file
                foreach (var post in posts)
                {
                    lstPosts.Items.Add(post); // Add each post to the list box
                }
            }
        }

        // Event handler for when a post is selected from the list box
        private void lstPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPosts.SelectedItem != null) // Check if a post is selected
            {
                string selectedPost = lstPosts.SelectedItem.ToString(); // Get the selected post's text
                LoadComments(selectedPost); // Load comments for the selected post
            }
        }

        // Method to load comments for a selected post
        private void LoadComments(string selectedPost)
        {
            lstComments.Items.Clear(); // Clear the existing list of comments
            if (File.Exists(commentsFile)) // Check if the comments file exists
            {
                string[] comments = File.ReadAllLines(commentsFile); // Read all comments from the file
                foreach (var comment in comments)
                {
                    if (comment.StartsWith(selectedPost + ":")) // Check if the comment belongs to the selected post
                    {
                        lstComments.Items.Add(comment.Replace(selectedPost + ":", "")); // Display the comment without the post title
                    }
                }
            }
        }

        // Event handler for adding a comment to the selected post
        private void btnAddComment_Click(object sender, EventArgs e)
        {
            if (lstPosts.SelectedItem != null) // Check if a post is selected
            {
                string selectedPost = lstPosts.SelectedItem.ToString(); // Get the selected post's text
                string comment = txtComment.Text.Trim(); // Get the comment text entered by the user

                if (!string.IsNullOrEmpty(comment)) // Check if the comment is not empty
                {
                    File.AppendAllText(commentsFile, $"{selectedPost}:{comment}" + Environment.NewLine); // Append the comment to the comments file
                    MessageBox.Show("Yorum Başarıyla Eklendi!"); // Show a success message
                    txtComment.Clear(); // Clear the comment text box
                    LoadComments(selectedPost); // Reload the comments for the selected post
                }
                else
                {
                    MessageBox.Show("Yorum Boş Olamaz!"); // Show an error message if the comment is empty
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Gönderi Seçin!"); // Show an error message if no post is selected
            }
        }

        // Event handler for adding a new post
        private void btnAddPosts_Click_1(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim(); // Get the post title entered by the user
            string content = txtContent.Text.Trim(); // Get the post content entered by the user

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(content)) // Check if both title and content are not empty
            {
                string post = $"{title} - {content}"; // Create a new post string
                File.AppendAllText(postsFile, post + Environment.NewLine); // Append the new post to the posts file
                MessageBox.Show("Gönderi Başarıyla Eklendi!"); // Show a success message
                txtTitle.Clear(); // Clear the title text box
                txtContent.Clear(); // Clear the content text box
                LoadPosts(); // Reload the list of posts
            }
            else
            {
                MessageBox.Show("Başlık Ve İçerik Boş Olamaz!"); // Show an error message if title or content is empty
            }
        }
    }
}