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

        public static class UserSession
        {
            public static int AdminStatus { get; set; }
            public static string Username { get; set; }

            public static int StudentStatus { get; set; }
            public static string StudentUsername { get; set; }
            public static string StudentId { get; set; }
            public static string StudentName { get; set; }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Logout();

            string username = txt_username.Text;
            string password = txt_password.Text;

            // Admin login
            if (Admin(username, password))
            {
                MessageBox.Show("Admin Login");

                UserSession.AdminStatus = 1;
                UserSession.Username = username;
                admindashboard adminForm = new admindashboard(UserSession.AdminStatus, UserSession.Username);
                adminForm.Show();
                this.Hide();
            }

            UserSession.StudentStatus = 2;
            UserSession.StudentUsername = username;

            var (studentId, studentName) = LoadStudentInfo(username);

            if (!string.IsNullOrEmpty(studentId) && !string.IsNullOrEmpty(studentName))
            {

                MessageBox.Show("Student Login");
                UserSession.StudentId = studentId;
                UserSession.StudentName = studentName;

                BorrowReturnPage borrowReturnPage = BorrowReturnPage.Instance(studentId, studentName);
                borrowReturnPage.Show();
                this.Hide();
            }

        }
        public static void Logout()
        {
            UserSession.AdminStatus = 0; // Reset admin status
            UserSession.Username = null; // Clear username
            UserSession.StudentStatus = 0; // Reset student status
            UserSession.StudentUsername = null; // Clear student username
            UserSession.StudentId = null; // Clear student ID
            UserSession.StudentName = null; // Clear student name
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

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
      


