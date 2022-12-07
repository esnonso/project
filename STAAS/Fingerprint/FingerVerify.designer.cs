namespace fingerprint
{
    partial class FingerVerify
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label latenessReasonLabel;
            System.Windows.Forms.Label timeInLabel;
            System.Windows.Forms.Label timeOutLabel;
            System.Windows.Forms.Label staffIDLabel;
            this.cboReaders = new System.Windows.Forms.ComboBox();
            this.signinUsingFingerprintTextLabel = new System.Windows.Forms.Label();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbFingerprint = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTextBox1 = new System.Windows.Forms.TextBox();
            this.latenessReasonTextBox = new System.Windows.Forms.TextBox();
            this.timeInTextBox = new System.Windows.Forms.TextBox();
            this.timeOutTextBox = new System.Windows.Forms.TextBox();
            this.staffIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            dateLabel = new System.Windows.Forms.Label();
            latenessReasonLabel = new System.Windows.Forms.Label();
            timeInLabel = new System.Windows.Forms.Label();
            timeOutLabel = new System.Windows.Forms.Label();
            staffIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFingerprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffIDNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(853, 219);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(54, 21);
            dateLabel.TabIndex = 21;
            dateLabel.Text = "Date:";
            // 
            // cboReaders
            // 
            this.cboReaders.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReaders.FormattingEnabled = true;
            this.cboReaders.Location = new System.Drawing.Point(48, 390);
            this.cboReaders.Name = "cboReaders";
            this.cboReaders.Size = new System.Drawing.Size(362, 31);
            this.cboReaders.TabIndex = 12;
            // 
            // signinUsingFingerprintTextLabel
            // 
            this.signinUsingFingerprintTextLabel.AutoSize = true;
            this.signinUsingFingerprintTextLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinUsingFingerprintTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.signinUsingFingerprintTextLabel.Location = new System.Drawing.Point(53, 52);
            this.signinUsingFingerprintTextLabel.Name = "signinUsingFingerprintTextLabel";
            this.signinUsingFingerprintTextLabel.Size = new System.Drawing.Size(402, 43);
            this.signinUsingFingerprintTextLabel.TabIndex = 13;
            this.signinUsingFingerprintTextLabel.Text = "RECORD ATTENDANCE";
            this.signinUsingFingerprintTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataSource = typeof(STAAS.Fingerprint.Attendance);
            // 
            // pbFingerprint
            // 
            this.pbFingerprint.BackColor = System.Drawing.Color.Transparent;
            this.pbFingerprint.Location = new System.Drawing.Point(75, 145);
            this.pbFingerprint.Name = "pbFingerprint";
            this.pbFingerprint.Size = new System.Drawing.Size(309, 214);
            this.pbFingerprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFingerprint.TabIndex = 10;
            this.pbFingerprint.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Place your finger on the scanner";
            // 
            // dateTextBox1
            // 
            this.dateTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendanceBindingSource, "Date", true));
            this.dateTextBox1.Location = new System.Drawing.Point(982, 213);
            this.dateTextBox1.Name = "dateTextBox1";
            this.dateTextBox1.Size = new System.Drawing.Size(100, 27);
            this.dateTextBox1.TabIndex = 26;
            // 
            // latenessReasonLabel
            // 
            latenessReasonLabel.AutoSize = true;
            latenessReasonLabel.Location = new System.Drawing.Point(859, 268);
            latenessReasonLabel.Name = "latenessReasonLabel";
            latenessReasonLabel.Size = new System.Drawing.Size(142, 21);
            latenessReasonLabel.TabIndex = 26;
            latenessReasonLabel.Text = "Lateness Reason:";
            // 
            // latenessReasonTextBox
            // 
            this.latenessReasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendanceBindingSource, "LatenessReason", true));
            this.latenessReasonTextBox.Location = new System.Drawing.Point(1007, 265);
            this.latenessReasonTextBox.Name = "latenessReasonTextBox";
            this.latenessReasonTextBox.Size = new System.Drawing.Size(100, 27);
            this.latenessReasonTextBox.TabIndex = 27;
            // 
            // timeInLabel
            // 
            timeInLabel.AutoSize = true;
            timeInLabel.Location = new System.Drawing.Point(861, 338);
            timeInLabel.Name = "timeInLabel";
            timeInLabel.Size = new System.Drawing.Size(69, 21);
            timeInLabel.TabIndex = 28;
            timeInLabel.Text = "Time In:";
            // 
            // timeInTextBox
            // 
            this.timeInTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendanceBindingSource, "TimeIn", true));
            this.timeInTextBox.Location = new System.Drawing.Point(936, 335);
            this.timeInTextBox.Name = "timeInTextBox";
            this.timeInTextBox.Size = new System.Drawing.Size(100, 27);
            this.timeInTextBox.TabIndex = 29;
            // 
            // timeOutLabel
            // 
            timeOutLabel.AutoSize = true;
            timeOutLabel.Location = new System.Drawing.Point(861, 380);
            timeOutLabel.Name = "timeOutLabel";
            timeOutLabel.Size = new System.Drawing.Size(85, 21);
            timeOutLabel.TabIndex = 29;
            timeOutLabel.Text = "Time Out:";
            // 
            // timeOutTextBox
            // 
            this.timeOutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendanceBindingSource, "TimeOut", true));
            this.timeOutTextBox.Location = new System.Drawing.Point(952, 377);
            this.timeOutTextBox.Name = "timeOutTextBox";
            this.timeOutTextBox.Size = new System.Drawing.Size(100, 27);
            this.timeOutTextBox.TabIndex = 30;
            // 
            // staffIDLabel
            // 
            staffIDLabel.AutoSize = true;
            staffIDLabel.Location = new System.Drawing.Point(849, 423);
            staffIDLabel.Name = "staffIDLabel";
            staffIDLabel.Size = new System.Drawing.Size(71, 21);
            staffIDLabel.TabIndex = 30;
            staffIDLabel.Text = "Staff ID:";
            // 
            // staffIDNumericUpDown
            // 
            this.staffIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.attendanceBindingSource, "StaffID", true));
            this.staffIDNumericUpDown.Location = new System.Drawing.Point(926, 423);
            this.staffIDNumericUpDown.Name = "staffIDNumericUpDown";
            this.staffIDNumericUpDown.Size = new System.Drawing.Size(120, 27);
            this.staffIDNumericUpDown.TabIndex = 31;
            // 
            // FingerVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 587);
            this.ControlBox = false;
            this.Controls.Add(staffIDLabel);
            this.Controls.Add(this.staffIDNumericUpDown);
            this.Controls.Add(timeOutLabel);
            this.Controls.Add(this.timeOutTextBox);
            this.Controls.Add(timeInLabel);
            this.Controls.Add(this.timeInTextBox);
            this.Controls.Add(latenessReasonLabel);
            this.Controls.Add(this.latenessReasonTextBox);
            this.Controls.Add(this.dateTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.signinUsingFingerprintTextLabel);
            this.Controls.Add(this.cboReaders);
            this.Controls.Add(this.pbFingerprint);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FingerVerify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FingerVerify_FormClosing);
            this.Load += new System.EventHandler(this.FingerVerify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFingerprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffIDNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboReaders;
        internal System.Windows.Forms.PictureBox pbFingerprint;
        private System.Windows.Forms.Label signinUsingFingerprintTextLabel;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dateTextBox1;
        private System.Windows.Forms.TextBox latenessReasonTextBox;
        private System.Windows.Forms.TextBox timeInTextBox;
        private System.Windows.Forms.TextBox timeOutTextBox;
        private System.Windows.Forms.NumericUpDown staffIDNumericUpDown;
    }
}