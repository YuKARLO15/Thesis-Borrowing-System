﻿using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Thesis.Login;

namespace Thesis
{
    public partial class Add_Book : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=thesis_management;Uid=root;Pwd=;";
        public Add_Book()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string thesis_name = txt_thesis.Text;
            string year_publish = txt_publication.Text;
            string Copies = txt_copies.Text;
            string Category = txt_category.Text;

            if (string.IsNullOrWhiteSpace(thesis_name) ||
             string.IsNullOrWhiteSpace(year_publish) ||
             string.IsNullOrWhiteSpace(Copies) ||
             string.IsNullOrWhiteSpace(Category))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (SignupAdmin(thesis_name, year_publish, Copies, Category))
            {
                MessageBox.Show("Thesis Information Added");
            }

            txt_thesis.Clear();
            txt_publication.Clear();
            txt_copies.Clear();
            txt_category.Clear();

        }

        private bool SignupAdmin(string thesis_name, string year_publish, string Copies, string Category)
        {
            string query = "INSERT INTO thesis_info (Thesis_Name, Year_Publish, Copies, Category) " +
                           "VALUES (@Thesis_Name, @Year_Publish, @Copies, @Category)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Thesis_Name", thesis_name);
                        command.Parameters.AddWithValue("@Year_Publish", year_publish);
                        command.Parameters.AddWithValue("@Copies", Copies);
                        command.Parameters.AddWithValue("@Category", Category);

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

        private void txt_publication_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_copies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void Add_Book_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
