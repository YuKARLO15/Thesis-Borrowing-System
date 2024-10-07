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
    public partial class Receipt : Form
    {
        public Receipt(string process, string studentID, string studentName, string category, string thesisName, DateTime dateCurrent, DateTime dueDate)
        {
            InitializeComponent();

            // Set the label texts to display the receipt details
            lbl_process.Text = process; // "Borrowing" or "Returning"
            lbl_studentnumber.Text = studentID;
            lbl_studentname.Text = studentName;
            lbl_category.Text = category;
            lbl_thesis.Text = thesisName;
            lbl_date.Text = dateCurrent.ToString("yyyy-MM-dd"); // Remove time
            lbl_datedue.Text = dueDate.ToString("yyyy-MM-dd"); // Remove time
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }
    }
}
