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
            this.add_thesis.Location = new System.Drawing.Point(130, 240);
            this.add_thesis.Name = "add_thesis";
            this.add_thesis.Size = new System.Drawing.Size(168, 156);
            this.add_thesis.TabIndex = 0;
            this.add_thesis.UseVisualStyleBackColor = true;
            // 
            // btn_adduser
            // 
            this.btn_adduser.BackgroundImage = global::Thesis.Properties.Resources._2;
            this.btn_adduser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_adduser.Location = new System.Drawing.Point(484, 240);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(168, 156);
            this.btn_adduser.TabIndex = 1;
            this.btn_adduser.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = global::Thesis.Properties.Resources._3;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Location = new System.Drawing.Point(793, 240);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(168, 156);
            this.btn_search.TabIndex = 2;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // admindashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thesis.Properties.Resources.dashboard__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_adduser);
            this.Controls.Add(this.add_thesis);
            this.DoubleBuffered = true;
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