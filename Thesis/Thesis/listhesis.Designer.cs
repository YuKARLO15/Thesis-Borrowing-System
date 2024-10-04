
namespace Thesis
{
    partial class listhesis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbSearchCriteria = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.ThesisGridView = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ThesisGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSearchCriteria
            // 
            this.cmbSearchCriteria.FormattingEnabled = true;
            this.cmbSearchCriteria.Items.AddRange(new object[] {
            "Title",
            "Category",
            "Status"});
            this.cmbSearchCriteria.Location = new System.Drawing.Point(282, 138);
            this.cmbSearchCriteria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSearchCriteria.Name = "cmbSearchCriteria";
            this.cmbSearchCriteria.Size = new System.Drawing.Size(92, 21);
            this.cmbSearchCriteria.TabIndex = 19;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(660, 35);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(68, 28);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // ThesisGridView
            // 
            this.ThesisGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ThesisGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ThesisGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ThesisGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ThesisGridView.Location = new System.Drawing.Point(63, 190);
            this.ThesisGridView.Name = "ThesisGridView";
            this.ThesisGridView.ReadOnly = true;
            this.ThesisGridView.RowHeadersWidth = 51;
            this.ThesisGridView.Size = new System.Drawing.Size(632, 225);
            this.ThesisGridView.TabIndex = 17;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(583, 138);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(163, 21);
            this.btn_search.TabIndex = 16;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(127, 138);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(135, 20);
            this.txt_search.TabIndex = 15;
            // 
            // listhesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thesis.Properties.Resources.Search__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 454);
            this.Controls.Add(this.cmbSearchCriteria);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.ThesisGridView);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.DoubleBuffered = true;
            this.Name = "listhesis";
            this.Text = "listhesis";
            ((System.ComponentModel.ISupportInitialize)(this.ThesisGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSearchCriteria;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView ThesisGridView;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
    }
}