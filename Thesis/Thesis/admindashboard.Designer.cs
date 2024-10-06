namespace Thesis
{
    partial class admindashboard
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
            this.add_thesis = new System.Windows.Forms.Button();
            this.btn_adduser = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lBLADDUSER = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_thesis
            // 
            this.add_thesis.BackgroundImage = global::Thesis.Properties.Resources._1;
            this.add_thesis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_thesis.Location = new System.Drawing.Point(81, 277);
            this.add_thesis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_thesis.Name = "add_thesis";
            this.add_thesis.Size = new System.Drawing.Size(149, 130);
            this.add_thesis.TabIndex = 0;
            this.add_thesis.UseVisualStyleBackColor = true;
            this.add_thesis.Click += new System.EventHandler(this.add_thesis_Click);
            // 
            // btn_adduser
            // 
            this.btn_adduser.BackgroundImage = global::Thesis.Properties.Resources._2;
            this.btn_adduser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_adduser.Location = new System.Drawing.Point(836, 274);
            this.btn_adduser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(149, 130);
            this.btn_adduser.TabIndex = 1;
            this.btn_adduser.UseVisualStyleBackColor = true;
            this.btn_adduser.Visible = false;
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = global::Thesis.Properties.Resources._31;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Location = new System.Drawing.Point(355, 274);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(149, 130);
            this.btn_search.TabIndex = 2;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(851, 471);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(191, 57);
            this.btn_back.TabIndex = 14;
            this.btn_back.Text = "LOG OUT";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Thesis.Properties.Resources._21;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(609, 274);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 130);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lBLADDUSER
            // 
            this.lBLADDUSER.AutoSize = true;
            this.lBLADDUSER.BackColor = System.Drawing.Color.Transparent;
            this.lBLADDUSER.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLADDUSER.ForeColor = System.Drawing.Color.White;
            this.lBLADDUSER.Location = new System.Drawing.Point(855, 409);
            this.lBLADDUSER.Name = "lBLADDUSER";
            this.lBLADDUSER.Size = new System.Drawing.Size(114, 36);
            this.lBLADDUSER.TabIndex = 16;
            this.lBLADDUSER.Text = "ADD USER";
            this.lBLADDUSER.Visible = false;
            // 
            // admindashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thesis.Properties.Resources.dashboard__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lBLADDUSER);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_adduser);
            this.Controls.Add(this.add_thesis);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "admindashboard";
            this.Text = "admindashboard";
            this.Load += new System.EventHandler(this.admindashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_thesis;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btn_adduser;
        private System.Windows.Forms.Label lBLADDUSER;
    }
}