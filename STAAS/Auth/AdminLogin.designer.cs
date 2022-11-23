namespace STAAS
{
    partial class AdminLogin
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
            this.adminSignUpPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.haShemlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.pleaseFillLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.adminSignUpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminSignUpPanel
            // 
            this.adminSignUpPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adminSignUpPanel.Controls.Add(this.label1);
            this.adminSignUpPanel.Controls.Add(this.haShemlabel);
            this.adminSignUpPanel.Controls.Add(this.pictureBox1);
            this.adminSignUpPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.adminSignUpPanel.Location = new System.Drawing.Point(1033, 0);
            this.adminSignUpPanel.Name = "adminSignUpPanel";
            this.adminSignUpPanel.Size = new System.Drawing.Size(589, 1010);
            this.adminSignUpPanel.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(246, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // haShemlabel
            // 
            this.haShemlabel.AutoSize = true;
            this.haShemlabel.BackColor = System.Drawing.Color.Black;
            this.haShemlabel.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haShemlabel.ForeColor = System.Drawing.Color.White;
            this.haShemlabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.haShemlabel.Location = new System.Drawing.Point(227, 602);
            this.haShemlabel.Name = "haShemlabel";
            this.haShemlabel.Size = new System.Drawing.Size(297, 70);
            this.haShemlabel.TabIndex = 1;
            this.haShemlabel.Text = "HA-SHEM";
            this.haShemlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::STAAS.Properties.Resources.image_1;
            this.pictureBox1.Location = new System.Drawing.Point(-154, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(743, 1010);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.signupButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.signupButton.FlatAppearance.BorderSize = 0;
            this.signupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.signupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.signupButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.signupButton.Location = new System.Drawing.Point(135, 473);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(416, 48);
            this.signupButton.TabIndex = 23;
            this.signupButton.Text = "LOGIN";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(132, 386);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(128, 28);
            this.passwordLabel.TabIndex = 20;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.signUpLabel.Location = new System.Drawing.Point(280, 158);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(184, 70);
            this.signUpLabel.TabIndex = 0;
            this.signUpLabel.Text = "Login";
            this.signUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pleaseFillLabel
            // 
            this.pleaseFillLabel.AutoSize = true;
            this.pleaseFillLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pleaseFillLabel.Location = new System.Drawing.Point(244, 210);
            this.pleaseFillLabel.Name = "pleaseFillLabel";
            this.pleaseFillLabel.Size = new System.Drawing.Size(364, 30);
            this.pleaseFillLabel.TabIndex = 1;
            this.pleaseFillLabel.Text = "Please fill in the details below";
            this.pleaseFillLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(133, 297);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(82, 28);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(135, 328);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(416, 37);
            this.email.TabIndex = 24;
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(135, 417);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(416, 37);
            this.password.TabIndex = 25;
            this.password.UseSystemPasswordChar = true;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1622, 1010);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.adminSignUpPanel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.pleaseFillLabel);
            this.Controls.Add(this.signUpLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.adminSignUpPanel.ResumeLayout(false);
            this.adminSignUpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel adminSignUpPanel;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Label pleaseFillLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label haShemlabel;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
    }
}