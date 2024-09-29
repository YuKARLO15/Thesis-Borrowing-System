namespace Thesis
{
    partial class BorrowReturnPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_process = new System.Windows.Forms.ComboBox();
            this.txt_studentnum = new System.Windows.Forms.TextBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.txt_studentname = new System.Windows.Forms.TextBox();
            this.cb_thesistitle = new System.Windows.Forms.ComboBox();
            this.date_current = new System.Windows.Forms.DateTimePicker();
            this.date_due = new System.Windows.Forms.DateTimePicker();
            this.lbl_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_process
            // 
            this.txt_process.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_process.FormattingEnabled = true;
            this.txt_process.Location = new System.Drawing.Point(265, 149);
            this.txt_process.Name = "txt_process";
            this.txt_process.Size = new System.Drawing.Size(192, 33);
            this.txt_process.TabIndex = 0;
            // 
            // txt_studentnum
            // 
            this.txt_studentnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_studentnum.Location = new System.Drawing.Point(412, 223);
            this.txt_studentnum.Name = "txt_studentnum";
            this.txt_studentnum.Size = new System.Drawing.Size(212, 27);
            this.txt_studentnum.TabIndex = 1;
            // 
            // cb_category
            // 
            this.cb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(414, 299);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(211, 28);
            this.cb_category.TabIndex = 2;
            // 
            // txt_studentname
            // 
            this.txt_studentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_studentname.Location = new System.Drawing.Point(414, 260);
            this.txt_studentname.Name = "txt_studentname";
            this.txt_studentname.Size = new System.Drawing.Size(209, 27);
            this.txt_studentname.TabIndex = 3;
            // 
            // cb_thesistitle
            // 
            this.cb_thesistitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_thesistitle.FormattingEnabled = true;
            this.cb_thesistitle.Location = new System.Drawing.Point(415, 345);
            this.cb_thesistitle.Name = "cb_thesistitle";
            this.cb_thesistitle.Size = new System.Drawing.Size(211, 28);
            this.cb_thesistitle.TabIndex = 4;
            // 
            // date_current
            // 
            this.date_current.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_current.Location = new System.Drawing.Point(285, 431);
            this.date_current.Name = "date_current";
            this.date_current.Size = new System.Drawing.Size(200, 22);
            this.date_current.TabIndex = 5;
            // 
            // date_due
            // 
            this.date_due.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_due.Location = new System.Drawing.Point(285, 470);
            this.date_due.Name = "date_due";
            this.date_due.Size = new System.Drawing.Size(200, 22);
            this.date_due.TabIndex = 6;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.White;
            this.lbl_status.Location = new System.Drawing.Point(877, 354);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(97, 30);
            this.lbl_status.TabIndex = 7;
            this.lbl_status.Text = "available";
            this.lbl_status.Visible = false;
            // 
            // BorrowReturnPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thesis.Properties.Resources.Receipt__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.date_due);
            this.Controls.Add(this.date_current);
            this.Controls.Add(this.cb_thesistitle);
            this.Controls.Add(this.txt_studentname);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.txt_studentnum);
            this.Controls.Add(this.txt_process);
            this.DoubleBuffered = true;
            this.Name = "BorrowReturnPage";
            this.Text = "Borrowing And Returning Page";
            this.Load += new System.EventHandler(this.BorrowReturnPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_process;
        private System.Windows.Forms.TextBox txt_studentnum;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.TextBox txt_studentname;
        private System.Windows.Forms.ComboBox cb_thesistitle;
        private System.Windows.Forms.DateTimePicker date_current;
        private System.Windows.Forms.DateTimePicker date_due;
        private System.Windows.Forms.Label lbl_status;
    }
}