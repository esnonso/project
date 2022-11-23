namespace STAAS
{
    partial class SuccessSignIn
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
            this.successSignPanel = new System.Windows.Forms.Panel();
            this.uniqueId_label = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeInLabel = new System.Windows.Forms.Label();
            this.greeting = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.successpictureBox = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.successSignPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.successpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // successSignPanel
            // 
            this.successSignPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.successSignPanel.Controls.Add(this.uniqueId_label);
            this.successSignPanel.Controls.Add(this.timeLabel);
            this.successSignPanel.Controls.Add(this.label1);
            this.successSignPanel.Controls.Add(this.timeInLabel);
            this.successSignPanel.Controls.Add(this.greeting);
            this.successSignPanel.Controls.Add(this.welcomeLabel);
            this.successSignPanel.Controls.Add(this.successpictureBox);
            this.successSignPanel.Location = new System.Drawing.Point(365, 118);
            this.successSignPanel.Name = "successSignPanel";
            this.successSignPanel.Size = new System.Drawing.Size(522, 514);
            this.successSignPanel.TabIndex = 0;
            // 
            // uniqueId_label
            // 
            this.uniqueId_label.AutoSize = true;
            this.uniqueId_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.uniqueId_label.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniqueId_label.Location = new System.Drawing.Point(59, 303);
            this.uniqueId_label.Name = "uniqueId_label";
            this.uniqueId_label.Size = new System.Drawing.Size(88, 23);
            this.uniqueId_label.TabIndex = 15;
            this.uniqueId_label.Text = "7:48 AM";
            this.uniqueId_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.timeLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(59, 195);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(79, 23);
            this.timeLabel.TabIndex = 14;
            this.timeLabel.Text = "Time In";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeInLabel
            // 
            this.timeInLabel.AutoSize = true;
            this.timeInLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.timeInLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInLabel.Location = new System.Drawing.Point(59, 221);
            this.timeInLabel.Name = "timeInLabel";
            this.timeInLabel.Size = new System.Drawing.Size(88, 23);
            this.timeInLabel.TabIndex = 9;
            this.timeInLabel.Text = "7:48 AM";
            this.timeInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting.Location = new System.Drawing.Point(59, 130);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(275, 23);
            this.greeting.TabIndex = 3;
            this.greeting.Text = "Do have a productive day";
            this.greeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(59, 106);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(110, 23);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome ";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // successpictureBox
            // 
            this.successpictureBox.Image = global::STAAS.Properties.Resources.Success_Icon2;
            this.successpictureBox.Location = new System.Drawing.Point(226, 29);
            this.successpictureBox.Name = "successpictureBox";
            this.successpictureBox.Size = new System.Drawing.Size(45, 45);
            this.successpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.successpictureBox.TabIndex = 0;
            this.successpictureBox.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.cancelButton.Location = new System.Drawing.Point(831, 69);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(55, 43);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "X";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SuccessSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::STAAS.Properties.Resources.Black_Background1;
            this.ClientSize = new System.Drawing.Size(1447, 1050);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.successSignPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuccessSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuccessSignIn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SuccessSignIn_Load);
            this.successSignPanel.ResumeLayout(false);
            this.successSignPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.successpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel successSignPanel;
        private System.Windows.Forms.Label timeInLabel;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox successpictureBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label uniqueId_label;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
    }
}