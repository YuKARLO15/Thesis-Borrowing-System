using System;

namespace Thesis
{
    partial class thesislogs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thesislogs));
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.ThesisGridView = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.cmbSearchCriteria = new System.Windows.Forms.ComboBox();
            this.btn_Sall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ThesisGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(161, 171);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(179, 22);
            this.txt_search.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(631, 164);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(215, 47);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ThesisGridView
            // 
            this.ThesisGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ThesisGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ThesisGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ThesisGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ThesisGridView.Location = new System.Drawing.Point(116, 225);
            this.ThesisGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ThesisGridView.Name = "ThesisGridView";
            this.ThesisGridView.ReadOnly = true;
            this.ThesisGridView.RowHeadersWidth = 51;
            this.ThesisGridView.Size = new System.Drawing.Size(843, 277);
            this.ThesisGridView.TabIndex = 9;
            this.ThesisGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ThesisGridView_CellContentClick);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(912, 34);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(91, 34);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cmbSearchCriteria
            // 
            this.cmbSearchCriteria.FormattingEnabled = true;
            this.cmbSearchCriteria.Items.AddRange(new object[] {
            "Title",
            "Status",
            "Date_Borrowed",
            "Student_Name",
            "Student_ID"});
            this.cmbSearchCriteria.Location = new System.Drawing.Point(368, 171);
            this.cmbSearchCriteria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSearchCriteria.Name = "cmbSearchCriteria";
            this.cmbSearchCriteria.Size = new System.Drawing.Size(121, 24);
            this.cmbSearchCriteria.TabIndex = 14;
            // 
            // btn_Sall
            // 
            this.btn_Sall.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Sall.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sall.ForeColor = System.Drawing.Color.White;
            this.btn_Sall.Location = new System.Drawing.Point(853, 165);
            this.btn_Sall.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sall.Name = "btn_Sall";
            this.btn_Sall.Size = new System.Drawing.Size(105, 46);
            this.btn_Sall.TabIndex = 15;
            this.btn_Sall.Text = "ALL";
            this.btn_Sall.UseVisualStyleBackColor = false;
            this.btn_Sall.Click += new System.EventHandler(this.btn_Sall_Click);
            // 
            // thesislogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_Sall);
            this.Controls.Add(this.cmbSearchCriteria);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.ThesisGridView);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "thesislogs";
            this.Text = "Thesis Logs";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThesisGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView ThesisGridView;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cmbSearchCriteria;
        private System.Windows.Forms.Button btn_Sall;
    }
}