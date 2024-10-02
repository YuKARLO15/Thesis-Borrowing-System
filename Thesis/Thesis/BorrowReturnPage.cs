using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesis
{
    public partial class BorrowReturnPage : Form
    {
        private string studentId;
        private string studentName;

        public BorrowReturnPage(string studentId, string studentName) 
        {
            InitializeComponent();
            this.studentId = studentId; 
            this.studentName = studentName; 
            LoadStudentDetails(); 
            LoadThesisNames();

            date_current.KeyPress += date_current_KeyPress; 
            date_due.KeyPress += date_due_KeyPress;

        }


        private void LoadStudentDetails() 
        {
            txt_studentname.Text = studentName; 
            txt_studentnum.Text = studentId; 
        }
        string connectionString = "Server=localhost;Port=4306;Database=thesis_management;Uid=root;Pwd=;";

        private void BorrowReturnPage_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_process.SelectedItem != null)
            {
                
                string selectedStatus = txt_process.SelectedItem.ToString();

               
                if (selectedStatus == "Borrowing")
                {
                    
                    string status = txt_process.SelectedItem.ToString();
                    string thesisName = cb_thesistitle.SelectedItem.ToString();
                    string studentID = txt_studentnum.Text;
                    DateTime date_current = DateTime.Now;
                    DateTime due_date = date_due.Value;

                    InsertBorrowingRecord(studentID, thesisName,status,date_current, due_date);
                }
               
                else if (selectedStatus == "Returning")
                {
                    
                    string thesisName = cb_thesistitle.SelectedItem.ToString();
                    string studentNumber = txt_studentnum.Text;
                    string studentName = txt_studentname.Text;
                    DateTime date_current = DateTime.Now;

                }
                else
                {
                    
                    MessageBox.Show("Please select a valid status from the dropdown.");
                }
            }
            else
            {
                
                MessageBox.Show("Please select a status from the dropdown.");
            }
        }
        private string GenerateBorrowedID()
        {
            string lastBorrowedId = "B_000"; 
            string query = "SELECT Borrowed_ID FROM borrowing ORDER BY Borrowed_ID DESC LIMIT 1;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            lastBorrowedId = result.ToString(); 
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving Borrowed_ID: " + ex.Message);
                }
            }

            
            int numericPart = int.Parse(lastBorrowedId.Split('_')[1]) + 1;
            string newBorrowedId = $"B_{numericPart:D3}"; 

            return newBorrowedId;
        }
        private void InsertBorrowingRecord(string studentID, string thesisName, string status, DateTime date_current, DateTime date_due)
        {
            string borrowedId = GenerateBorrowedID(); 

            
            string query = "INSERT INTO borrowing (Borrowed_ID, Student_ID, Thesis_Name, Status, Date_Borrowed, Due_Date) " +
                           "VALUES (@borrowedId, @studentNumber, @thesisName, @status, @date_current, @date_due)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@borrowedId", borrowedId);
                        command.Parameters.AddWithValue("@studentNumber", studentID);
                        command.Parameters.AddWithValue("@thesisName", thesisName);
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@date_current", date_current);
                        command.Parameters.AddWithValue("@date_due", date_due);

                       
                        command.ExecuteNonQuery();
                        MessageBox.Show("Borrowing record inserted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void txt_process_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = txt_process.SelectedItem.ToString();

           
            if (selectedStatus == "Borrowing")
            {
                btn_add.Text = "Borrowing"; 
            }
            else if (selectedStatus == "Returning")
            {
                btn_add.Text = "Returning"; 
            }
        }

        private void cb_thesistitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadThesisNames()
        {
            
            string query = "SELECT thesis_name FROM thesis_info";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                  
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            
                            cb_thesistitle.Items.Clear();

                           
                            while (reader.Read())
                            {
                               
                                cb_thesistitle.Items.Add(reader["thesis_name"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void date_current_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true; 
        }

        private void date_due_KeyPress(object sender, KeyPressEventArgs e)
        {
         
            e.Handled = true; 
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
