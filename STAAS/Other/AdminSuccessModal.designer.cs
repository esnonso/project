namespace STAAS
{
    partial class AdminSuccessModal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.successIconPictureBox = new System.Windows.Forms.PictureBox();
            this.successTextLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.successIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.successIconPictureBox);
            this.panel1.Controls.Add(this.successTextLabel);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(392, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 441);
            this.panel1.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(60, 297);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(339, 48);
            this.loginButton.TabIndex = 24;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // successIconPictureBox
            // 
            this.successIconPictureBox.Image = global::STAAS.Properties.Resources.success_icon;
            this.successIconPictureBox.Location = new System.Drawing.Point(178, 96);
            this.successIconPictureBox.Name = "successIconPictureBox";
            this.successIconPictureBox.Size = new System.Drawing.Size(100, 100);
            this.successIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.successIconPictureBox.TabIndex = 1;
            this.successIconPictureBox.TabStop = false;
            // 
            // successTextLabel
            // 
            this.successTextLabel.AutoSize = true;
            this.successTextLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successTextLabel.Location = new System.Drawing.Point(6, 229);
            this.successTextLabel.Name = "successTextLabel";
            this.successTextLabel.Size = new System.Drawing.Size(463, 56);
            this.successTextLabel.TabIndex = 0;
            this.successTextLabel.Text = "You have successfully signed up.\r\nProceed to log in with your credentials.";
            this.successTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.successTextLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SignUpSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::STAAS.Properties.Resources.image_1;
            this.ClientSize = new System.Drawing.Size(1924, 804);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpSuccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpSuccess";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.successIconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox successIconPictureBox;
        private System.Windows.Forms.Label successTextLabel;
        private System.Windows.Forms.Button loginButton;
    }
}