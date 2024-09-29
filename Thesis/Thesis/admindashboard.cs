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
    public partial class admindashboard : Form
    {
        public admindashboard()
        {
            InitializeComponent();
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
            Search SearchThesis = new Search();
            SearchThesis.Show();
            this.Hide();
        }
    }
}
