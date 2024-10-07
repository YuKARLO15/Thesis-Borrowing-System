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
    public partial class admindashboard : Form
    {
        private int adminStatus;
        private string username;

        public admindashboard(int status, string adminUsername)
        {
            InitializeComponent();
            adminStatus = status; // Store the admin status
            username = adminUsername; // Store the username

            ConfigureButtons(); // Call a method to configure buttons based on username
        }
        private void ConfigureButtons()
        {
            if (username == "admin1")
            {
                btn_adduser.Visible = true;
            }
            else
            {
                btn_adduser.Visible = false; // Hide this button for other admins
                lBLADDUSER.Visible = false;
            }
        }
        private void add_thesis_Click(object sender, EventArgs e)
        {
            Add_Book AdminAdd_Book = new Add_Book();
            AdminAdd_Book.Show();
            this.Hide();

        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            Admin AdminAdd_User = new Admin();
            AdminAdd_User.Show();
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            thesislogs SearchThesis = new thesislogs();
            SearchThesis.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login.Logout();


            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();


        }
        public static void Logout()
        {
            UserSession.AdminStatus = 0;
            UserSession.Username = null;
            UserSession.StudentStatus = 0;
            UserSession.StudentUsername = null;
            UserSession.StudentId = null;
            UserSession.StudentName = null;
        }

        private void admindashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listhesis listthesis = new listhesis(adminStatus);
            listthesis.Show();
            this.Hide();
        }
    }
}