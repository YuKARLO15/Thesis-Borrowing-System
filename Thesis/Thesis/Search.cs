using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Thesis
{
    public partial class Search : Form
    {
        string connectionString = "Server=localhost;Port=4306;Database=thesis_management;Uid=root;Pwd=;";

        public Search()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            admindashboard AdminDashBoard = new admindashboard();
            AdminDashBoard.Show();
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
                    thesis_info.Thesis_Name, 
                    thesis_info.Year_Publish, 
                    thesis_info.Copies, 
                    thesis_info.Category, 
                    borrowing.Status
                FROM 
                    thesis_info
                INNER JOIN 
                    borrowing ON thesis_info.Thesis_Name = borrowing.Thesis_Name";

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
            string searchValue = txt_search.Text;   // One TextBox for input

            if (!string.IsNullOrEmpty(searchValue))
            {
                // Modify the query to search in Category, Status (from status_info), and Title (Thesis_Name)
                string query = @"
                    SELECT 
                        thesis_info.Thesis_Name, 
                        thesis_info.Year_Publish, 
                        thesis_info.Copies, 
                        thesis_info.Category, 
                        borrowing.Status
                    FROM 
                        thesis_info
                    INNER JOIN 
                        status_info ON thesis_info.Thesis_Name = borrowing.Thesis_Name
                    WHERE 
                        thesis_info.Category LIKE @SearchValue 
                        OR borrowing.Status LIKE @SearchValue 
                        OR thesis_info.Thesis_Name LIKE @SearchValue";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            // Add parameter for the search value
                            cmd.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");

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
            else
            {
                MessageBox.Show("Please enter a value to search.");
            }
        }


    }
}