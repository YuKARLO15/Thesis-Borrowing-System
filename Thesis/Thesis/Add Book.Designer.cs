namespace Thesis
{
    partial class Add_Book
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
            this.txt_category = new System.Windows.Forms.TextBox();
            this.txt_thesis = new System.Windows.Forms.TextBox();
            this.txt_copies = new System.Windows.Forms.TextBox();
            this.txt_publication = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_category
            // 
            this.txt_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_category.Location = new System.Drawing.Point(448, 253);
            this.txt_category.Margin = new System.Windows.Forms.Padding(4);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(212, 29);
            this.txt_category.TabIndex = 7;
            // 
            // txt_thesis
            // 
            this.txt_thesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thesis.Location = new System.Drawing.Point(447, 293);
            this.txt_thesis.Margin = new System.Windows.Forms.Padding(4);
            this.txt_thesis.Name = "txt_thesis";
            this.txt_thesis.Size = new System.Drawing.Size(212, 29);
            this.txt_thesis.TabIndex = 8;
            // 
            // txt_copies
            // 
            this.txt_copies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_copies.Location = new System.Drawing.Point(447, 332);
            this.txt_copies.Margin = new System.Windows.Forms.Padding(4);
            this.txt_copies.Name = "txt_copies";
            this.txt_copies.Size = new System.Drawing.Size(212, 29);
            this.txt_copies.TabIndex = 9;
            this.txt_copies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_copies_KeyPress);
            // 
            // txt_publication
            // 
            this.txt_publication.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_publication.Location = new System.Drawing.Point(447, 369);
            this.txt_publication.Margin = new System.Windows.Forms.Padding(4);
            this.txt_publication.Name = "txt_publication";
            this.txt_publication.Size = new System.Drawing.Size(212, 29);
            this.txt_publication.TabIndex = 10;
            this.txt_publication.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_publication_KeyPress);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(852, 473);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(191, 56);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(31, 473);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(191, 56);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // Add_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thesis.Properties.Resources.Add_new_book;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_publication);
            this.Controls.Add(this.txt_copies);
            this.Controls.Add(this.txt_thesis);
            this.Controls.Add(this.txt_category);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_Book";
            this.Text = "Add_Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.TextBox txt_thesis;
        private System.Windows.Forms.TextBox txt_copies;
        private System.Windows.Forms.TextBox txt_publication;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_back;
    }
}