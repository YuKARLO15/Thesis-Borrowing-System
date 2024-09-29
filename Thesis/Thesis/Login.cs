using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Thesis
{
    public partial class Login : Form
    {
        string connectionString = "Server=localhost;Port=4306;Database=thesis_management;Uid=root;Pwd=;";

        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;


            if (Admin(username, password))
            {
                MessageBox.Show("Admin Login");
                this.Hide();
                Add_Book adminform = new Add_Book();
                adminform.ShowDialog();
            }
            else if (ValidateUser(username, password))
            {
                MessageBox.Show("Login Successfully");
                this.Hide();
            }
            else {
                MessageBox.Show("Incorrect Student Number or Password");
            }
        }

        private bool ValidateUser(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM student_info WHERE Student_ID = @username AND Password = @password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);


                        int result = Convert.ToInt32(command.ExecuteScalar());


                        return result == 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }


        private bool Admin(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM admin WHERE username = @username AND password = @password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);


                        int result = Convert.ToInt32(command.ExecuteScalar());


                        return result == 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }



        private void btn_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration register_user = new Registration();
            register_user.ShowDialog();
            this.Show();

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
      


