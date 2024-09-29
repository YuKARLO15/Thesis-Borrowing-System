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
            this.SuspendLayout();
            // 
            // add_thesis
            // 
            this.add_thesis.BackgroundImage = global::Thesis.Properties.Resources._1;
            this.add_thesis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_thesis.Location = new System.Drawing.Point(98, 195);
            this.add_thesis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_thesis.Name = "add_thesis";
            this.add_thesis.Size = new System.Drawing.Size(126, 127);
            this.add_thesis.TabIndex = 0;
            this.add_thesis.UseVisualStyleBackColor = true;
            this.add_thesis.Click += new System.EventHandler(this.add_thesis_Click);
            // 
            // btn_adduser
            // 
            this.btn_adduser.BackgroundImage = global::Thesis.Properties.Resources._2;
            this.btn_adduser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_adduser.Location = new System.Drawing.Point(363, 195);
            this.btn_adduser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(126, 127);
            this.btn_adduser.TabIndex = 1;
            this.btn_adduser.UseVisualStyleBackColor = true;
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = global::Thesis.Properties.Resources._3;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Location = new System.Drawing.Point(595, 195);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(126, 127);
            this.btn_search.TabIndex = 2;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // admindashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thesis.Properties.Resources.dashboard__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_adduser);
            this.Controls.Add(this.add_thesis);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "admindashboard";
            this.Text = "admindashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_thesis;
        private System.Windows.Forms.Button btn_adduser;
        private System.Windows.Forms.Button btn_search;
    }
}