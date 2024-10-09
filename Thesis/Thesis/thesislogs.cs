using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static Thesis.Login;

namespace Thesis
{
    public partial class thesislogs : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=thesis_management;Uid=root;Pwd=;";

        public thesislogs()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            int adminstatus = UserSession.AdminStatus; // Access AdminStatus from static class
            string username = UserSession.Username; // Access Username from static class

            // Use adminstatus and username safely
            if (adminstatus > 0 && !string.IsNullOrEmpty(username))
            {
                admindashboard Admindashboard = new admindashboard(adminstatus, username);
                Admindashboard.Show();
                this.Hide(); // Hide the current form
            }
            else
            {
                MessageBox.Show("Admin status or username is not set.");
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // SQL query to join thesis_info and status_info tables without aliases
            string query = @"
                SELECT 
                borrowing.Borrowed_ID,
                borrowing.Thesis_Name, 
                borrowing.Status,
                borrowing.Date_Borrowed,
                borrowing.Student_ID,
                student_info.Student_Name

            FROM 
                borrowing
            INNER JOIN 
                student_info ON borrowing.Student_ID = student_info.Student_ID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dataTable);
                        ThesisGridView.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Trigger the search on button click using a single TextBox
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text.Trim(); // Capture input from the TextBox
            string selectedCriteria = cmbSearchCriteria.SelectedItem.ToString(); // Get selected criteria

            if (!string.IsNullOrEmpty(searchValue))
            {
                // Initialize the query based on the selected criteria
                string query = @"
            SELECT 
                borrowing.Borrowed_ID,
                borrowing.Thesis_Name, 
                borrowing.Status,
                borrowing.Date_Borrowed,
                borrowing.Student_ID,
                student_info.Student_Name


            FROM 
                borrowing
            INNER JOIN 
                student_info ON borrowing.Student_ID = student_info.Student_ID
                
            WHERE
                1=1"; // Start with a condition that is always true

                // Add conditions based on the selected criteria
                if (selectedCriteria == "Title")
                {
                    query += " AND thesis_info.Thesis_Name = @SearchValue";
                }
                else if (selectedCriteria == "Status")
                {
                    query += " AND borrowing.Status = @SearchValue";
                }
                else if (selectedCriteria == "Student_ID")
                {
                    query += " AND borrowing.Student_ID = @SearchValue";
                }
                else if (selectedCriteria == "Student_Name")
                {
                    query += " AND student_info.Student_Name = @SearchValue";
                }

                MessageBox.Show("Executing Query: " + query);
                MessageBox.Show("Searching for: " + searchValue);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@SearchValue", searchValue); // Pass exact search value

                            DataTable dataTable = new DataTable();
                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            adapter.Fill(dataTable);


                            if (dataTable.Rows.Count > 0)
                            {
                                ThesisGridView.DataSource = dataTable; // Set the DataGridView source
                            }
                            else
                            {
                                MessageBox.Show("No results found."); // Notify if no results
                                ThesisGridView.DataSource = null; // Clear the DataGridView if no results
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message); // Show error messages
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a value to search."); // Prompt for input
            }
        }

        private void btn_Sall_Click(object sender, EventArgs e)
        {
            LoadData();
            txt_search.Text = "";
            cmbSearchCriteria.SelectedIndex = -1;
        }

        private void ThesisGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}