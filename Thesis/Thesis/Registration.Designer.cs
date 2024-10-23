namespace Thesis
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.txt_studentnumber = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_studentname = new System.Windows.Forms.TextBox();
            this.txt_course = new System.Windows.Forms.TextBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_studentnumber
            // 
            this.txt_studentnumber.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_studentnumber.Location = new System.Drawing.Point(315, 136);
            this.txt_studentnumber.MaxLength = 10;
            this.txt_studentnumber.Name = "txt_studentnumber";
            this.txt_studentnumber.Size = new System.Drawing.Size(193, 32);
            this.txt_studentnumber.TabIndex = 3;
            this.txt_studentnumber.TextChanged += new System.EventHandler(this.txt_studentnumber_TextChanged);
            this.txt_studentnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_studentnumber_KeyPress);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(315, 173);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(193, 32);
            this.txt_password.TabIndex = 4;
            // 
            // txt_studentname
            // 
            this.txt_studentname.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_studentname.Location = new System.Drawing.Point(315, 210);
            this.txt_studentname.Name = "txt_studentname";
            this.txt_studentname.Size = new System.Drawing.Size(315, 32);
            this.txt_studentname.TabIndex = 5;
            // 
            // txt_course
            // 
            this.txt_course.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_course.Location = new System.Drawing.Point(315, 301);
            this.txt_course.Name = "txt_course";
            this.txt_course.Size = new System.Drawing.Size(160, 32);
            this.txt_course.TabIndex = 6;
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_signup.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.Color.White;
            this.btn_signup.Location = new System.Drawing.Point(606, 366);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(122, 40);
            this.btn_signup.TabIndex = 7;
            this.btn_signup.Text = "SIGN UP";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.BackColor = System.Drawing.Color.Transparent;
            this.lblerror.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.White;
            this.lblerror.Location = new System.Drawing.Point(311, 374);
            this.lblerror.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(114, 22);
            this.lblerror.TabIndex = 8;
            this.lblerror.Text = "Invalid Show";
            this.lblerror.UseMnemonic = false;
            this.lblerror.Visible = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(75, 366);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(122, 40);
            this.btn_back.TabIndex = 14;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.txt_course);
            this.Controls.Add(this.txt_studentname);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_studentnumber);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_studentnumber;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_studentname;
        private System.Windows.Forms.TextBox txt_course;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Button btn_back;
    }
}