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
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label staffLabel;
            System.Windows.Forms.Label timeInLabel;
            System.Windows.Forms.Label timeOutLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label latenessReasonLabel;
            System.Windows.Forms.Label emailLabel;
            this.cboReaders = new System.Windows.Forms.ComboBox();
            this.signinUsingFingerprintTextLabel = new System.Windows.Forms.Label();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.staffTextBox = new System.Windows.Forms.TextBox();
            this.timeInTextBox = new System.Windows.Forms.TextBox();
            this.timeOutTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.pbFingerprint = new System.Windows.Forms.PictureBox();
            this.latenessReasonTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            staffLabel = new System.Windows.Forms.Label();
            timeInLabel = new System.Windows.Forms.Label();
            timeOutLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            latenessReasonLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFingerprint)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(853, 251);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(112, 21);
            departmentLabel.TabIndex = 15;
            departmentLabel.Text = "Department:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(853, 295);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(74, 21);
            genderLabel.TabIndex = 16;
            genderLabel.Text = "Gender:";
            // 
            // staffLabel
            // 
            staffLabel.AutoSize = true;
            staffLabel.Location = new System.Drawing.Point(853, 331);
            staffLabel.Name = "staffLabel";
            staffLabel.Size = new System.Drawing.Size(50, 21);
            staffLabel.TabIndex = 17;
            staffLabel.Text = "Staff:";
            // 
            // timeInLabel
            // 
            timeInLabel.AutoSize = true;
            timeInLabel.Location = new System.Drawing.Point(853, 370);
            timeInLabel.Name = "timeInLabel";
            timeInLabel.Size = new System.Drawing.Size(69, 21);
            timeInLabel.TabIndex = 18;
            timeInLabel.Text = "Time In:";
            // 
            // timeOutLabel
            // 
            timeOutLabel.AutoSize = true;
            timeOutLabel.Location = new System.Drawing.Point(853, 413);
            timeOutLabel.Name = "timeOutLabel";
            timeOutLabel.Size = new System.Drawing.Size(85, 21);
            timeOutLabel.TabIndex = 19;
            timeOutLabel.Text = "Time Out:";
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
            // latenessReasonLabel
            // 
            latenessReasonLabel.AutoSize = true;
            latenessReasonLabel.Location = new System.Drawing.Point(870, 491);
            latenessReasonLabel.Name = "latenessReasonLabel";
            latenessReasonLabel.Size = new System.Drawing.Size(142, 21);
            latenessReasonLabel.TabIndex = 22;
            latenessReasonLabel.Text = "Lateness Reason:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(861, 449);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(55, 21);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "Email:";
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
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendanceBindingSource, "Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(1052, 246);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(100, 27);
            this.departmentTextBox.TabIndex = 16;
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataSource = typeof(STAAS.Fingerprint.Attendance);
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendanceBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(1052, 290);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(100, 27);
            this.genderTextBox.TabIndex = 17;
            // 
            // staffTextBox
            // 
            this.staffTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendanceBindingSource, "Staff", true));
            this.staffTextBox.Location = new System.Drawing.Point(1052, 326);
            this.staffTextBox.Name = "staffTextBox";
            this.staffTextBox.Size = new System.Drawing.Size(100, 27);
            this.staffTextBox.TabIndex = 18;
            // 
            // timeInTextBox
            // 
            this.timeInTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendanceBindingSource, "TimeIn", true));
            this.timeInTextBox.Location = new System.Drawing.Point(1052, 365);
            this.timeInTextBox.Name = "timeInTextBox";
            this.timeInTextBox.Size = new System.Drawing.Size(100, 27);
            this.timeInTextBox.TabIndex = 19;
            // 
            // timeOutTextBox
            // 
            this.timeOutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendanceBindingSource, "TimeOut", true));
            this.timeOutTextBox.Location = new System.Drawing.Point(1052, 408);
            this.timeOutTextBox.Name = "timeOutTextBox";
            this.timeOutTextBox.Size = new System.Drawing.Size(100, 27);
            this.timeOutTextBox.TabIndex = 20;
            // 
            // dateTextBox
            // 
            this.dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendanceBindingSource, "Date", true));
            this.dateTextBox.Location = new System.Drawing.Point(1052, 213);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 27);
            this.dateTextBox.TabIndex = 22;
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
            // latenessReasonTextBox
            // 
            this.latenessReasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendanceBindingSource, "LatenessReason", true));
            this.latenessReasonTextBox.Location = new System.Drawing.Point(1018, 488);
            this.latenessReasonTextBox.Name = "latenessReasonTextBox";
            this.latenessReasonTextBox.Size = new System.Drawing.Size(100, 27);
            this.latenessReasonTextBox.TabIndex = 23;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendanceBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(1052, 443);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 27);
            this.emailTextBox.TabIndex = 24;
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
            // FingerVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 500);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(latenessReasonLabel);
            this.Controls.Add(this.latenessReasonTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(timeOutLabel);
            this.Controls.Add(this.timeOutTextBox);
            this.Controls.Add(timeInLabel);
            this.Controls.Add(this.timeInTextBox);
            this.Controls.Add(staffLabel);
            this.Controls.Add(this.staffTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.departmentTextBox);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboReaders;
        internal System.Windows.Forms.PictureBox pbFingerprint;
        private System.Windows.Forms.Label signinUsingFingerprintTextLabel;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox staffTextBox;
        private System.Windows.Forms.TextBox timeInTextBox;
        private System.Windows.Forms.TextBox timeOutTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox latenessReasonTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label2;
    }
}