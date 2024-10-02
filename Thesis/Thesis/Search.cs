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
            // Query to select data from the table
            string query = "SELECT Thesis_Name, Year_Publish, Copies, Category FROM thesis_info";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a MySQL command
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Create a DataTable to hold the query results
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable using a DataAdapter
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        ThesisGridView.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    // Show error message if something goes wrong
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
