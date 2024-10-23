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
using MySql.Data.MySqlClient;

namespace Thesis
{
    public partial class Registration : Form
    {

        string connectionString = "Server=localhost;Port=3306;Database=thesis_management;Uid=root;Pwd=;";

        public Registration()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string studentNumber = txt_studentnumber.Text;  
            string password = txt_password.Text;
            string studentName = txt_studentname.Text;      
            string course = txt_course.Text;     
            
            if (string.IsNullOrWhiteSpace(studentNumber) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(studentName) ||
                string.IsNullOrWhiteSpace(course))
            {
                lblerror.Visible = true;
                lblerror.Text = "Please fill in all fields.";
                return;
            }

            if (SignupUser(studentNumber, password, studentName, course))
            {
                MessageBox.Show("Sign-up successful!");
                Login loginform = new Login();
                loginform.Show();
                this.Dispose();
            }
            else
            {
                lblerror.Visible = true;
                lblerror.Text = "Sign-up failed. Please try again.";
            }
        }

        private bool SignupUser(string studentNumber, string password, string studentName, string course)
        {

            string hashedPassword = Hashing.ComputeSha256Hash(password);

            string query = "INSERT INTO student_info (Student_ID, Password, Student_Name, Course) " +
                           "VALUES (@StudentID, @Password, @StudentName, @Course)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Use parameters to avoid SQL injection attacks
                        command.Parameters.AddWithValue("@StudentID", studentNumber);
                        command.Parameters.AddWithValue("@Password", hashedPassword);
                        command.Parameters.AddWithValue("@StudentName", studentName);
                        command.Parameters.AddWithValue("@Course", course);

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

        private void txt_studentnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
       
                e.Handled = true;
            }
        }

        private void txt_studentnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login_form = new Login();
            login_form.Show();

        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
