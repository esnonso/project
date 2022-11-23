namespace STAAS
{
    partial class MovementRegister
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
            this.signOutPanel = new System.Windows.Forms.Panel();
            this.signOutButton = new System.Windows.Forms.Button();
            this.signOutPictureBox = new System.Windows.Forms.PictureBox();
            this.signInPanel = new System.Windows.Forms.Panel();
            this.signInButton = new System.Windows.Forms.Button();
            this.signInPictureBox = new System.Windows.Forms.PictureBox();
            this.movementRegLabel = new System.Windows.Forms.Label();
            this.kindlySelectLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.arrowBackbutton = new System.Windows.Forms.Button();
            this.signOutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signOutPictureBox)).BeginInit();
            this.signInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signInPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // signOutPanel
            // 
            this.signOutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signOutPanel.Controls.Add(this.signOutButton);
            this.signOutPanel.Controls.Add(this.signOutPictureBox);
            this.signOutPanel.Location = new System.Drawing.Point(652, 310);
            this.signOutPanel.Name = "signOutPanel";
            this.signOutPanel.Size = new System.Drawing.Size(217, 254);
            this.signOutPanel.TabIndex = 1;
            // 
            // signOutButton
            // 
            this.signOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.signOutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.signOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.signOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.signOutButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.signOutButton.Location = new System.Drawing.Point(50, 178);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(107, 47);
            this.signOutButton.TabIndex = 1;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // signOutPictureBox
            // 
            this.signOutPictureBox.Image = global::STAAS.Properties.Resources.Sign_Out;
            this.signOutPictureBox.Location = new System.Drawing.Point(68, 41);
            this.signOutPictureBox.Name = "signOutPictureBox";
            this.signOutPictureBox.Size = new System.Drawing.Size(64, 64);
            this.signOutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.signOutPictureBox.TabIndex = 0;
            this.signOutPictureBox.TabStop = false;
            // 
            // signInPanel
            // 
            this.signInPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signInPanel.Controls.Add(this.signInButton);
            this.signInPanel.Controls.Add(this.signInPictureBox);
            this.signInPanel.Location = new System.Drawing.Point(982, 310);
            this.signInPanel.Name = "signInPanel";
            this.signInPanel.Size = new System.Drawing.Size(217, 254);
            this.signInPanel.TabIndex = 2;
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.signInButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.signInButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.signInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.signInButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.signInButton.Location = new System.Drawing.Point(55, 178);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(105, 47);
            this.signInButton.TabIndex = 2;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // signInPictureBox
            // 
            this.signInPictureBox.Image = global::STAAS.Properties.Resources.Sign_In;
            this.signInPictureBox.Location = new System.Drawing.Point(74, 43);
            this.signInPictureBox.Name = "signInPictureBox";
            this.signInPictureBox.Size = new System.Drawing.Size(60, 62);
            this.signInPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.signInPictureBox.TabIndex = 1;
            this.signInPictureBox.TabStop = false;
            // 
            // movementRegLabel
            // 
            this.movementRegLabel.AutoSize = true;
            this.movementRegLabel.BackColor = System.Drawing.Color.Transparent;
            this.movementRegLabel.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movementRegLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.movementRegLabel.Location = new System.Drawing.Point(844, 112);
            this.movementRegLabel.Name = "movementRegLabel";
            this.movementRegLabel.Size = new System.Drawing.Size(395, 47);
            this.movementRegLabel.TabIndex = 3;
            this.movementRegLabel.Text = "Movement Register";
            // 
            // kindlySelectLabel
            // 
            this.kindlySelectLabel.AutoSize = true;
            this.kindlySelectLabel.BackColor = System.Drawing.Color.Transparent;
            this.kindlySelectLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kindlySelectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.kindlySelectLabel.Location = new System.Drawing.Point(809, 151);
            this.kindlySelectLabel.Name = "kindlySelectLabel";
            this.kindlySelectLabel.Size = new System.Drawing.Size(516, 30);
            this.kindlySelectLabel.TabIndex = 4;
            this.kindlySelectLabel.Text = "Kindly select any of the two options below";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.BackgroundImage = global::STAAS.Properties.Resources.Background_Right;
            this.panel1.Controls.Add(this.arrowBackbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 1050);
            this.panel1.TabIndex = 0;
            // 
            // arrowBackbutton
            // 
            this.arrowBackbutton.BackColor = System.Drawing.Color.Black;
            this.arrowBackbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.arrowBackbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.arrowBackbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arrowBackbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.arrowBackbutton.Image = global::STAAS.Properties.Resources.arrow_back_white;
            this.arrowBackbutton.Location = new System.Drawing.Point(23, 30);
            this.arrowBackbutton.Name = "arrowBackbutton";
            this.arrowBackbutton.Size = new System.Drawing.Size(56, 50);
            this.arrowBackbutton.TabIndex = 0;
            this.arrowBackbutton.UseVisualStyleBackColor = false;
            // 
            // MovementRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.kindlySelectLabel);
            this.Controls.Add(this.movementRegLabel);
            this.Controls.Add(this.signInPanel);
            this.Controls.Add(this.signOutPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovementRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovementRegister";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.signOutPanel.ResumeLayout(false);
            this.signOutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signOutPictureBox)).EndInit();
            this.signInPanel.ResumeLayout(false);
            this.signInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signInPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button arrowBackbutton;
        private System.Windows.Forms.Panel signOutPanel;
        private System.Windows.Forms.Panel signInPanel;
        private System.Windows.Forms.Label movementRegLabel;
        private System.Windows.Forms.Label kindlySelectLabel;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.PictureBox signOutPictureBox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.PictureBox signInPictureBox;
    }
}