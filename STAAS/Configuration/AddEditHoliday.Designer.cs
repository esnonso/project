namespace STAAS.UserManagement
{
    partial class AddEditHoliday
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
            this.assEditHolidaypanel = new System.Windows.Forms.Panel();
            this.enddateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.startdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.holidayTypecomboBox = new System.Windows.Forms.ComboBox();
            this.endDayslabel = new System.Windows.Forms.Label();
            this.startDayLabel = new System.Windows.Forms.Label();
            this.holidayTypelabel = new System.Windows.Forms.Label();
            this.holidayNametextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.holidayNamelabel = new System.Windows.Forms.Label();
            this.addHolidaypanel = new System.Windows.Forms.Panel();
            this.addHolidaylabel = new System.Windows.Forms.Label();
            this.assEditHolidaypanel.SuspendLayout();
            this.addHolidaypanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // assEditHolidaypanel
            // 
            this.assEditHolidaypanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.assEditHolidaypanel.Controls.Add(this.enddateTimePicker2);
            this.assEditHolidaypanel.Controls.Add(this.startdateTimePicker);
            this.assEditHolidaypanel.Controls.Add(this.holidayTypecomboBox);
            this.assEditHolidaypanel.Controls.Add(this.endDayslabel);
            this.assEditHolidaypanel.Controls.Add(this.startDayLabel);
            this.assEditHolidaypanel.Controls.Add(this.holidayTypelabel);
            this.assEditHolidaypanel.Controls.Add(this.holidayNametextBox);
            this.assEditHolidaypanel.Controls.Add(this.saveButton);
            this.assEditHolidaypanel.Controls.Add(this.holidayNamelabel);
            this.assEditHolidaypanel.Controls.Add(this.addHolidaypanel);
            this.assEditHolidaypanel.Location = new System.Drawing.Point(371, 105);
            this.assEditHolidaypanel.Name = "assEditHolidaypanel";
            this.assEditHolidaypanel.Size = new System.Drawing.Size(518, 525);
            this.assEditHolidaypanel.TabIndex = 2;
            // 
            // enddateTimePicker2
            // 
            this.enddateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddateTimePicker2.Location = new System.Drawing.Point(50, 389);
            this.enddateTimePicker2.Name = "enddateTimePicker2";
            this.enddateTimePicker2.Size = new System.Drawing.Size(424, 32);
            this.enddateTimePicker2.TabIndex = 17;
            // 
            // startdateTimePicker
            // 
            this.startdateTimePicker.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdateTimePicker.Location = new System.Drawing.Point(50, 299);
            this.startdateTimePicker.Name = "startdateTimePicker";
            this.startdateTimePicker.Size = new System.Drawing.Size(424, 32);
            this.startdateTimePicker.TabIndex = 4;
            // 
            // holidayTypecomboBox
            // 
            this.holidayTypecomboBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holidayTypecomboBox.FormattingEnabled = true;
            this.holidayTypecomboBox.Items.AddRange(new object[] {
            "General",
            "Internal"});
            this.holidayTypecomboBox.Location = new System.Drawing.Point(50, 209);
            this.holidayTypecomboBox.Name = "holidayTypecomboBox";
            this.holidayTypecomboBox.Size = new System.Drawing.Size(424, 31);
            this.holidayTypecomboBox.TabIndex = 16;
            // 
            // endDayslabel
            // 
            this.endDayslabel.AutoSize = true;
            this.endDayslabel.BackColor = System.Drawing.Color.Transparent;
            this.endDayslabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDayslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.endDayslabel.Location = new System.Drawing.Point(46, 357);
            this.endDayslabel.Name = "endDayslabel";
            this.endDayslabel.Size = new System.Drawing.Size(93, 23);
            this.endDayslabel.TabIndex = 14;
            this.endDayslabel.Text = "End Day";
            // 
            // startDayLabel
            // 
            this.startDayLabel.AutoSize = true;
            this.startDayLabel.BackColor = System.Drawing.Color.Transparent;
            this.startDayLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.startDayLabel.Location = new System.Drawing.Point(46, 266);
            this.startDayLabel.Name = "startDayLabel";
            this.startDayLabel.Size = new System.Drawing.Size(100, 23);
            this.startDayLabel.TabIndex = 12;
            this.startDayLabel.Text = "Start Day";
            this.startDayLabel.Click += new System.EventHandler(this.monthLabel_Click);
            // 
            // holidayTypelabel
            // 
            this.holidayTypelabel.AutoSize = true;
            this.holidayTypelabel.BackColor = System.Drawing.Color.Transparent;
            this.holidayTypelabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holidayTypelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.holidayTypelabel.Location = new System.Drawing.Point(46, 178);
            this.holidayTypelabel.Name = "holidayTypelabel";
            this.holidayTypelabel.Size = new System.Drawing.Size(136, 23);
            this.holidayTypelabel.TabIndex = 10;
            this.holidayTypelabel.Text = "Holiday Type";
            // 
            // holidayNametextBox
            // 
            this.holidayNametextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holidayNametextBox.Location = new System.Drawing.Point(50, 116);
            this.holidayNametextBox.Name = "holidayNametextBox";
            this.holidayNametextBox.Size = new System.Drawing.Size(424, 32);
            this.holidayNametextBox.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.saveButton.Location = new System.Drawing.Point(46, 458);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(428, 42);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // holidayNamelabel
            // 
            this.holidayNamelabel.AutoSize = true;
            this.holidayNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.holidayNamelabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holidayNamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.holidayNamelabel.Location = new System.Drawing.Point(46, 86);
            this.holidayNamelabel.Name = "holidayNamelabel";
            this.holidayNamelabel.Size = new System.Drawing.Size(151, 23);
            this.holidayNamelabel.TabIndex = 1;
            this.holidayNamelabel.Text = "Holiday Name";
            // 
            // addHolidaypanel
            // 
            this.addHolidaypanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.addHolidaypanel.Controls.Add(this.addHolidaylabel);
            this.addHolidaypanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addHolidaypanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.addHolidaypanel.Location = new System.Drawing.Point(0, 0);
            this.addHolidaypanel.Name = "addHolidaypanel";
            this.addHolidaypanel.Size = new System.Drawing.Size(518, 57);
            this.addHolidaypanel.TabIndex = 0;
            // 
            // addHolidaylabel
            // 
            this.addHolidaylabel.AutoSize = true;
            this.addHolidaylabel.BackColor = System.Drawing.Color.Transparent;
            this.addHolidaylabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addHolidaylabel.Location = new System.Drawing.Point(190, 18);
            this.addHolidaylabel.Name = "addHolidaylabel";
            this.addHolidaylabel.Size = new System.Drawing.Size(158, 28);
            this.addHolidaylabel.TabIndex = 0;
            this.addHolidaylabel.Text = "Add Holiday";
            // 
            // AddEditHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1030);
            this.Controls.Add(this.assEditHolidaypanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEditHoliday";
            this.Text = "AddEditHoliday";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.assEditHolidaypanel.ResumeLayout(false);
            this.assEditHolidaypanel.PerformLayout();
            this.addHolidaypanel.ResumeLayout(false);
            this.addHolidaypanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel assEditHolidaypanel;
        private System.Windows.Forms.ComboBox holidayTypecomboBox;
        private System.Windows.Forms.Label endDayslabel;
        private System.Windows.Forms.Label startDayLabel;
        private System.Windows.Forms.Label holidayTypelabel;
        private System.Windows.Forms.TextBox holidayNametextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label holidayNamelabel;
        private System.Windows.Forms.Panel addHolidaypanel;
        private System.Windows.Forms.Label addHolidaylabel;
        private System.Windows.Forms.DateTimePicker startdateTimePicker;
        private System.Windows.Forms.DateTimePicker enddateTimePicker2;
    }
}