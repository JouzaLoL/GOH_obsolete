namespace GOH.Zastupovani
{
    partial class Credits
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
            this.creditsBox = new System.Windows.Forms.RichTextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.author = new MaterialSkin.Controls.MaterialLabel();
            this.versionLabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // creditsBox
            // 
            this.creditsBox.Location = new System.Drawing.Point(12, 128);
            this.creditsBox.Name = "creditsBox";
            this.creditsBox.Size = new System.Drawing.Size(260, 121);
            this.creditsBox.TabIndex = 0;
            this.creditsBox.Text = "Speciální poděkování:\nKačka Ambrůzová - Beta tester\nLada Karasková - Beta tester";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.White;
            this.logo.Location = new System.Drawing.Point(209, 70);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(63, 52);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.BackColor = System.Drawing.SystemColors.Window;
            this.author.Depth = 0;
            this.author.Font = new System.Drawing.Font("Roboto", 11F);
            this.author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.author.Location = new System.Drawing.Point(12, 70);
            this.author.MouseState = MaterialSkin.MouseState.HOVER;
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(145, 19);
            this.author.TabIndex = 2;
            this.author.Text = "© 2016 Josef Vacek";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.SystemColors.Window;
            this.versionLabel.Depth = 0;
            this.versionLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.versionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.versionLabel.Location = new System.Drawing.Point(12, 89);
            this.versionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(0, 19);
            this.versionLabel.TabIndex = 3;
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.author);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.creditsBox);
            this.Name = "Credits";
            this.Text = "Credits";
            this.Load += new System.EventHandler(this.Credits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox creditsBox;
        private System.Windows.Forms.PictureBox logo;
        private MaterialSkin.Controls.MaterialLabel author;
        private MaterialSkin.Controls.MaterialLabel versionLabel;
    }
}