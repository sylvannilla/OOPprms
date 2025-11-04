using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OOP_Project.Windows;

namespace OOP_Project
{
    public partial class Login : Form
    {
        string strConn = "server = localhost;user id=root;password=; database=db_oop";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            errorLabel.Text = "";
            usernameTextBox.Focus();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                errorLabel.Text = "Please enter both username and password.";
                return;
            }
            try
            {
                using (var con = new MySqlConnection(strConn))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand("SELECT * FROM login WHERE username = @username AND password = @password", con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Successful login
                                this.Hide();
                                AdminWindow admin = new AdminWindow();
                                admin.ShowDialog();
                            }
                            else
                            {
                                errorLabel.Text = "Invalid username or password.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
