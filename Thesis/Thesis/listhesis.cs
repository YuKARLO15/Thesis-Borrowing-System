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
using static Thesis.Login;

namespace Thesis
{
    public partial class listhesis : Form
    {

        private int adminstatus;
        private int studentStatus;

        public listhesis(int adminstatus) // Constructor
        {
            InitializeComponent();
            this.adminstatus = adminstatus;
        }


        string connectionString = "Server=localhost;Port=3306;Database=thesis_management;Uid=root;Pwd=;";
        private void btn_back_Click_1(object sender, EventArgs e)
        {
            int adminstatus = UserSession.AdminStatus;
            string username = UserSession.Username;

            // Check if the user is an admin
            if (adminstatus == 1 && !string.IsNullOrEmpty(username))
            {
                // Go back to the admin dashboard
                admindashboard adminDashboard = new admindashboard(adminstatus, username);
                adminDashboard.Show();
                this.Hide(); // Hide the current form
            }
            else if (UserSession.StudentStatus == 2 && !string.IsNullOrEmpty(UserSession.StudentUsername))
            {
                // If it's a student, go back to the BorrowReturnPage
                BorrowReturnPage BorrowReturnForm = BorrowReturnPage.Instance(UserSession.StudentId, UserSession.StudentName); // Pass the correct StudentId and StudentName
                BorrowReturnForm.Show(); // Show the BorrowReturnPage
                this.Hide(); // Hide the current form
            }
            else
            {
                MessageBox.Show("User status or username is not set.");
            }
        }

        private void listhesis_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // SQL query to join thesis_info and status_info tables without aliases
            string query = @"
                SELECT 
                    thesis_info.Thesis_Name, 
                    thesis_info.Year_Publish,  
                    thesis_info.Category,
                    thesis_info.Copies
                FROM 
                    thesis_info";

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


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text.Trim(); // Capture input from the TextBox
            string selectedCriteria = cmbSearchCriteria.SelectedItem.ToString(); // Get selected criteria

            if (!string.IsNullOrEmpty(searchValue))
            {
                // Initialize the query based on the selected criteria
                string query = @"
            SELECT 
                thesis_info.Thesis_Name, 
                thesis_info.Year_Publish,  
                thesis_info.Category,
                thesis_info.Copies

            FROM 
                thesis_info
                
            WHERE
                1=1"; // Start with a condition that is always true

                // Add conditions based on the selected criteria
                if (selectedCriteria == "Title")
                {
                    query += " AND thesis_info.Thesis_Name = @SearchValue";
                }
                else if (selectedCriteria == "Category")
                {
                    query += " AND thesis_info.Category = @SearchValue";
                }
                else if (selectedCriteria == "Status")
                {
                    query += " AND  thesis_info.Copies = @SearchValue";
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

        private void ThesisGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}