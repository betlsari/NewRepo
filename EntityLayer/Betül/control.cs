using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console
{
    internal class control
    {
        private string filePath = "usernames.txt";

        // Username check
        public bool IsUsernameTaken(string username)
        {
            if (File.Exists(filePath))
            {
                var usernames = File.ReadAllLines(filePath).ToList();
                return usernames.Contains(username);  // Returns true if the username already exists
            }
            return false;  // If the file doesn't exist, the username is available
        }

        // Register a new user
        public void RegisterUser(string username, string password)
        {
            if (IsUsernameTaken(username))
            {
                MessageBox.Show("This username is already taken. Please choose a different username.");
            }
            else
            {
                // If the username is new, register it
                File.AppendAllText(filePath, username + Environment.NewLine);  // Adds the new username to the file
                MessageBox.Show("Registration successful!");
            }
        }
    }
}
