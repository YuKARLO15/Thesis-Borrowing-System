using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Thesis
{
    public partial class Admin : Form
    {
        string connectionString = "Server=localhost;Port=4306;Database=thesis_management;Uid=root;Pwd=;";
        public Admin()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string admin_name = txt_adminname.Text;

            if (string.IsNullOrWhiteSpace(username) ||
               string.IsNullOrWhiteSpace(password) ||
               string.IsNullOrWhiteSpace(admin_name))
            {
                return;
            }

            if (SignupAdmin(username, password, admin_name))
            {
                MessageBox.Show("You are now Registered!");
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }


        private bool SignupAdmin(string username, string password, string admin_name)
        {
            string query = "INSERT INTO admin (username, password, admin_name) " +
                           "VALUES (@username, @password, @admin_name)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Use parameters to avoid SQL injection attacks
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@admin_name", admin_name);

                        int result = command.ExecuteNonQuery();

                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }
    }

}
