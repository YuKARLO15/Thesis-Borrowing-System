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
            LoadUniqueCategories();


            date_due.MinDate = DateTime.Now;

            date_current.KeyPress += date_current_KeyPress;
            date_due.KeyPress += date_due_KeyPress;

        }


        private void LoadStudentDetails() 
        {
            txt_studentname.Text = studentName; 
            txt_studentnum.Text = studentId; 
        }

        string connectionString = "Server=localhost;Port=3306;Database=thesis_management;Uid=root;Pwd=;";

        private void BorrowReturnPage_Load(object sender, EventArgs e)
        {

            cb_thesistitle.Enabled = false;
            cb_category.Enabled = false;

            cb_title_return.Visible = false;    
            cb_category_return.Visible = false;

            LoadUniqueCategories(); 

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
                    string thesisName = cb_thesistitle.SelectedItem?.ToString();
                    string studentID = txt_studentnum.Text;
                    DateTime date_current = DateTime.Now;
                    DateTime due_date = date_due.Value;

                    cb_category.Enabled = true;
                    cb_thesistitle.Enabled = false;

                    InsertBorrowingRecord(studentID, thesisName, selectedStatus, date_current, due_date);
                    MessageBox.Show("Borrowing process completed successfully.");

                    // After borrowing, refresh the thesis titles and categories
                    LoadThesisTitles();
                    LoadUniqueCategories(); // Load categories again to ensure they are up to date
                }
                else if (selectedStatus == "Returning")
                {
                    string thesisName = cb_title_return.SelectedItem?.ToString();
                    string studentID = txt_studentnum.Text;
                    DateTime date_current = DateTime.Now;

                    ProcessReturn(studentID, thesisName);
                    UpdateThesisStatus(thesisName, studentID);

                    MessageBox.Show("Returning process completed successfully.");

                    
                    LoadBorrowedThesisTitles(studentID);
                    LoadThesisTitles(); 
                }
                else
                {
                    MessageBox.Show("Please select a valid status (Borrowing or Returning).");
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

            string updateQuery = "UPDATE thesis_info SET Copies = Copies - 1 WHERE Thesis_Name = @thesisName AND Copies > 0";
            string insertQuery = "INSERT INTO borrowing (Borrowed_ID, Student_ID, Thesis_Name, Status, Date_Borrowed, Due_Date) " +
                                 "VALUES (@borrowedId, @studentNumber, @thesisName, @status, @date_current, @date_due)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // First, update the number of copies
                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@thesisName", thesisName);
                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No available copies to borrow.");
                            return; // Exit if no copies are available
                        }
                    }

                    // Then, insert the borrowing record
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@borrowedId", borrowedId);
                        insertCommand.Parameters.AddWithValue("@studentNumber", studentID);
                        insertCommand.Parameters.AddWithValue("@thesisName", thesisName);
                        insertCommand.Parameters.AddWithValue("@status", status);
                        insertCommand.Parameters.AddWithValue("@date_current", date_current);
                        insertCommand.Parameters.AddWithValue("@date_due", date_due);

                        insertCommand.ExecuteNonQuery();
                        MessageBox.Show("Borrowing record inserted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void UpdateCopies(string thesisTitle, int change)
        {
            string query = "UPDATE thesis_info SET Copies = Copies + @Change WHERE Thesis_Name = @ThesisName";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Change", change);
                        command.Parameters.AddWithValue("@ThesisName", thesisTitle);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating copies: " + ex.Message);
                }
            }
        }

        private void ProcessReturn(string studentID, string thesisName)
        {
            string updateQuery = "UPDATE thesis_info SET Copies = Copies + 1 WHERE Thesis_Name = @ThesisName";
            string returnQuery = "UPDATE borrowing SET Status = 'Returned' " +
                                 "WHERE Student_ID = @StudentID AND Thesis_Name = @ThesisName AND Status = 'Borrowing'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // First, update the number of copies
                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@ThesisName", thesisName);
                        updateCommand.ExecuteNonQuery();
                    }

                    // Then, update the borrowing record
                    using (MySqlCommand returnCommand = new MySqlCommand(returnQuery, connection))
                    {
                        returnCommand.Parameters.AddWithValue("@StudentID", studentID);
                        returnCommand.Parameters.AddWithValue("@ThesisName", thesisName);
                        returnCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing return: " + ex.Message);
                }
            }
        }


        private void txt_process_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_process.SelectedItem != null)
            {
                string selectedStatus = txt_process.SelectedItem.ToString();
                UpdateUIForStatus(selectedStatus);
            }
            else
            {
                ResetUI(); // This should reset the UI elements properly.
            }

        }
        private void UpdateUIForStatus(string status)
        {
            // Disable both combo boxes initially
            cb_thesistitle.Enabled = false;
            cb_category.Enabled = false;
            cb_category_return.Hide();
            cb_title_return.Hide();

            switch (status)
            {
                case "Borrowing":
                    btn_add.Text = "Borrowing";
                    cb_category.Enabled = true; // Enable only the category for borrowing

                    DateTime date_current = DateTime.Now;
                    DateTime dueDate = date_current.AddDays(7);
                    date_due.Value = dueDate;

                    LoadThesisTitles(); // Load titles related to the thesis

                    cb_category.SelectedItem = null;
                    break;

                case "Returning":

                    cb_category_return.Enabled = false;
                    cb_title_return.Enabled = true;
                    btn_add.Text = "Returning";
                    cb_category_return.Show();
                    cb_title_return.Show();

                    LoadBorrowedThesisTitles(studentId);
                    break;

                default:
                    // Reset UI if status is not recognized
                    ResetUI();
                    break;
            }
        }

        private void ResetUI()
        {
            cb_thesistitle.Enabled = false;
            cb_category.Enabled = false;
            cb_category_return.Hide();
            cb_title_return.Hide();

            // You can also clear the selections if necessary
            cb_thesistitle.SelectedIndex = -1;
            cb_category.SelectedIndex = -1;
            cb_category_return.SelectedIndex = -1;
            cb_title_return.SelectedIndex = -1;
        }

            private void UpdateThesisStatus(string thesisName, string studentId)
        {
            string query = "UPDATE borrowing SET Status = 'Returned' WHERE Thesis_Name = @ThesisName AND Student_ID = @StudentId"; // Adjust based on your DB structure

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ThesisName", thesisName);
                        command.Parameters.AddWithValue("@StudentId", studentId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thesis returned successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No thesis found for the specified title and student ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating thesis status: " + ex.Message);
                }
            }
        }
        private void cb_thesistitle_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb_thesistitle.SelectedItem is ThesisRecord selectedThesis)
            {
                // Display the due date (make sure it's appropriate)
                date_due.Value = selectedThesis.DateBorrowed;

                // Get the category
                string category = GetCategory(selectedThesis.ThesisName);

                // Get the number of available copies from the database
                int availableCopies = GetAvailableCopies(selectedThesis.ThesisName);

                
                if (availableCopies > 0)
                {
                    lbl_status.Text = $"Available Copies: {availableCopies}";
                }
                else
                {
                    lbl_status.Text = "Not Available";
                }

                // Populate the category dropdown
                cb_category.Items.Clear();
                if (!string.IsNullOrEmpty(category))
                {
                    cb_category.Items.Add(category);
                    cb_category.Enabled = true;
                    cb_category.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Category not found for the selected thesis.");
                    cb_category.Enabled = false;
                }
            }

        }

        private void LoadBorrowedThesisTitles(string studentId)
        {
            string query = "SELECT Thesis_Name FROM borrowing WHERE Student_ID = @StudentId AND Status = 'Borrowing'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentId", studentId);
                        MySqlDataReader reader = command.ExecuteReader();
                        cb_title_return.Items.Clear();

                        while (reader.Read())
                        {
                            var thesisRecord = new ThesisRecord
                            {
                                ThesisName = reader["Thesis_Name"].ToString(),
                            };
                            cb_title_return.Items.Add(thesisRecord);
                        }

                        if (cb_title_return.Items.Count > 0)
                            cb_title_return.SelectedIndex = 0; // Select the first item if available
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading borrowed thesis titles: " + ex.Message);
                }
            }
        }

        public class ThesisRecord
        {
            public string ThesisName { get; set; }

            public int Copies { get; set; } 

            public DateTime DateBorrowed { get; set; }

            public override string ToString()
            {
                return ThesisName; 
            }
        }
        private string GetCategory(string thesisTitle)
        {
            string query = "SELECT Category FROM thesis_info WHERE Thesis_Name = @Thesis_Name";
            string category = string.Empty;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Thesis_Name", thesisTitle);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            category = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching category: " + ex.Message);
                    }
                }
            }
            return category;
        }


        private int GetAvailableCopies(string thesisName)
        {
            string query = "SELECT Copies FROM thesis_info WHERE Thesis_Name = @ThesisName";
            int availableCopies = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ThesisName", thesisName);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            availableCopies = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("No copies found for the selected thesis.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving available copies: " + ex.Message);
                    }
                }
            }
            return availableCopies;
        }


        private void LoadUniqueCategories()
        {
            string query = "SELECT DISTINCT Category FROM thesis_info";
            cb_category.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string category = reader["Category"].ToString();
                            cb_category.Items.Add(category);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading categories: " + ex.Message);
                }
            }
        }


        private void LoadThesisTitles()
        {
            string query = "SELECT thesis_name FROM borrowing WHERE student_id = @studentId"; // Adjust the query as needed

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId); // Adding the student ID parameter
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
                    MessageBox.Show("Error loading thesis names: " + ex.Message);
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

            cb_thesistitle.Enabled = true;

            string selectedCategory = cb_category.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                LoadThesisTitlesByCategory(selectedCategory);
            }
        }

        private void LoadThesisTitlesByCategory(string category)
        {
            string query = "SELECT Thesis_Name FROM thesis_info WHERE Category = @Category";

            cb_thesistitle.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Category", category);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cb_thesistitle.Items.Add(reader["Thesis_Name"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading thesis titles by category: " + ex.Message);
                }
            }
        }

        private void txt_studentnum_TextChanged(object sender, EventArgs e)
        {
            LoadBorrowedThesisTitles(txt_studentnum.Text);
        }




        private void LoadCategory(string title)
        {
            string query = "SELECT Category FROM thesis_info WHERE Thesis_Name = @title";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cb_category_return.Items.Clear();
                                cb_category_return.Items.Add(reader["Category"].ToString());
                                cb_category_return.SelectedIndex = 0;
                            }
                            else
                            {
                                cb_category_return.Items.Clear();
                                MessageBox.Show("Category not found for the selected title.");
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

        private void cb_category_return_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_title_return_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_category_return.Enabled = false;
            if (cb_title_return.SelectedItem != null)
            {
                string selectedTitle = cb_title_return.SelectedItem.ToString();
                LoadCategory(selectedTitle);
            }
        }
    }
}
