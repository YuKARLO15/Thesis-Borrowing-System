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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_process
            // 
            this.txt_process.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_process.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_process.FormattingEnabled = true;
            this.txt_process.Items.AddRange(new object[] {
            "Borrowing",
            "Returning"});
            this.txt_process.Location = new System.Drawing.Point(199, 121);
            this.txt_process.Margin = new System.Windows.Forms.Padding(2);
            this.txt_process.Name = "txt_process";
            this.txt_process.Size = new System.Drawing.Size(145, 28);
            this.txt_process.TabIndex = 0;
            this.txt_process.SelectedIndexChanged += new System.EventHandler(this.txt_process_SelectedIndexChanged);
            // 
            // txt_studentnum
            // 
            this.txt_studentnum.Enabled = false;
            this.txt_studentnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_studentnum.Location = new System.Drawing.Point(309, 181);
            this.txt_studentnum.Margin = new System.Windows.Forms.Padding(2);
            this.txt_studentnum.Name = "txt_studentnum";
            this.txt_studentnum.ReadOnly = true;
            this.txt_studentnum.Size = new System.Drawing.Size(160, 23);
            this.txt_studentnum.TabIndex = 1;
            // 
            // cb_category
            // 
            this.cb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Items.AddRange(new object[] {
            "Transportation",
            "Web Application"});
            this.cb_category.Location = new System.Drawing.Point(310, 243);
            this.cb_category.Margin = new System.Windows.Forms.Padding(2);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(159, 25);
            this.cb_category.TabIndex = 2;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // txt_studentname
            // 
            this.txt_studentname.Enabled = false;
            this.txt_studentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_studentname.Location = new System.Drawing.Point(310, 211);
            this.txt_studentname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_studentname.Name = "txt_studentname";
            this.txt_studentname.ReadOnly = true;
            this.txt_studentname.Size = new System.Drawing.Size(231, 23);
            this.txt_studentname.TabIndex = 3;
            // 
            // cb_thesistitle
            // 
            this.cb_thesistitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_thesistitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_thesistitle.FormattingEnabled = true;
            this.cb_thesistitle.Location = new System.Drawing.Point(311, 280);
            this.cb_thesistitle.Margin = new System.Windows.Forms.Padding(2);
            this.cb_thesistitle.Name = "cb_thesistitle";
            this.cb_thesistitle.Size = new System.Drawing.Size(230, 25);
            this.cb_thesistitle.TabIndex = 4;
            this.cb_thesistitle.SelectedIndexChanged += new System.EventHandler(this.cb_thesistitle_SelectedIndexChanged);
            // 
            // date_current
            // 
            this.date_current.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_current.Location = new System.Drawing.Point(214, 350);
            this.date_current.Margin = new System.Windows.Forms.Padding(2);
            this.date_current.Name = "date_current";
            this.date_current.Size = new System.Drawing.Size(151, 20);
            this.date_current.TabIndex = 5;
            this.date_current.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.date_current_KeyPress);
            // 
            // date_due
            // 
            this.date_due.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_due.Location = new System.Drawing.Point(214, 382);
            this.date_due.Margin = new System.Windows.Forms.Padding(2);
            this.date_due.Name = "date_due";
            this.date_due.Size = new System.Drawing.Size(151, 20);
            this.date_due.TabIndex = 6;
            this.date_due.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.date_due_KeyPress);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.White;
            this.lbl_status.Location = new System.Drawing.Point(658, 288);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(73, 17);
            this.lbl_status.TabIndex = 7;
            this.lbl_status.Text = "available";
            this.lbl_status.Visible = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(588, 356);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(143, 46);
            this.btn_add.TabIndex = 12;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(56, 26);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(143, 46);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "LOG OUT";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // BorrowReturnPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thesis.Properties.Resources.Receipt__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.date_due);
            this.Controls.Add(this.date_current);
            this.Controls.Add(this.cb_thesistitle);
            this.Controls.Add(this.txt_studentname);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.txt_studentnum);
            this.Controls.Add(this.txt_process);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_back;
    }
}