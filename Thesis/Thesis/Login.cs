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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Thesis
{
    public partial class Login : Form
    {

        string connectionString = "Server=localhost;Port=3306;Database=thesis_management;Uid=root;Pwd=;";

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
                admindashboard adminform = new admindashboard(username,password);
                adminform.Show();
                this.Hide();
            }
            else if (ValidateStudent(username, password))
            {
                MessageBox.Show("Login Successfully");

                var (studentId, studentName) = LoadStudentInfo(username); 

                if (!string.IsNullOrEmpty(studentName)) 
                {
                    BorrowReturnPage borrowReturnPage = new BorrowReturnPage(studentId, studentName); 
                    borrowReturnPage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Student name not found.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Student Number or Password");
            }

        }

        private (string studentId, string studentName) LoadStudentInfo(string studentId)
        {
            string query = "SELECT Student_ID, Student_Name FROM student_info WHERE Student_ID = @StudentId";
            string studentName = string.Empty;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentId", studentId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                studentId = reader["Student_ID"].ToString();
                                studentName = reader["Student_Name"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student information: " + ex.Message);
                }
            }

            return (studentId, studentName); 
        }


        private bool ValidateStudent(string username, string password)
        {

            string hashedPassword = Hashing.ComputeSha256Hash(password);

            string query = "SELECT COUNT(1) FROM student_info WHERE Student_ID = @username AND Password = @password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", hashedPassword);


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

            string hashedPassword = Hashing.ComputeSha256Hash(password);

            string query = "SELECT COUNT(1) FROM admin WHERE username = @username AND password = @password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", hashedPassword);


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
            register_user.Show();

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
      


