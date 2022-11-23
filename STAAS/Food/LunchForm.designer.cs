namespace FoodAppSTAAS.Lunch
{
    partial class LunchForm
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
            System.Windows.Forms.Label staff_emailLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.proteinTextBox = new System.Windows.Forms.TextBox();
            this.staff_nameTextBox = new System.Windows.Forms.TextBox();
            this.lunchRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.time_bookedTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.soupTextBox = new System.Windows.Forms.TextBox();
            this.soupLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.mainCourseTextBox = new System.Windows.Forms.TextBox();
            this.mainCouseLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.bookLunchLabel = new System.Windows.Forms.Label();
            this.staff_emailTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox1 = new System.Windows.Forms.TextBox();
            staff_emailLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lunchRegisterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // staff_emailLabel
            // 
            staff_emailLabel.AutoSize = true;
            staff_emailLabel.Location = new System.Drawing.Point(1691, 270);
            staff_emailLabel.Name = "staff_emailLabel";
            staff_emailLabel.Size = new System.Drawing.Size(96, 21);
            staff_emailLabel.TabIndex = 3;
            staff_emailLabel.Text = "Staff email:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTextBox1);
            this.panel1.Controls.Add(this.proteinTextBox);
            this.panel1.Controls.Add(this.staff_nameTextBox);
            this.panel1.Controls.Add(this.time_bookedTextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.employeeNameLabel);
            this.panel1.Controls.Add(this.soupTextBox);
            this.panel1.Controls.Add(this.soupLabel);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.mainCourseTextBox);
            this.panel1.Controls.Add(this.mainCouseLabel);
            this.panel1.Controls.Add(this.dayLabel);
            this.panel1.Location = new System.Drawing.Point(160, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 498);
            this.panel1.TabIndex = 0;
            // 
            // proteinTextBox
            // 
            this.proteinTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.proteinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proteinTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.proteinTextBox.Location = new System.Drawing.Point(517, 296);
            this.proteinTextBox.Name = "proteinTextBox";
            this.proteinTextBox.Size = new System.Drawing.Size(376, 37);
            this.proteinTextBox.TabIndex = 36;
            // 
            // staff_nameTextBox
            // 
            this.staff_nameTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.staff_nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staff_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lunchRegisterBindingSource, "Staff_name", true));
            this.staff_nameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_nameTextBox.Location = new System.Drawing.Point(57, 300);
            this.staff_nameTextBox.Name = "staff_nameTextBox";
            this.staff_nameTextBox.Size = new System.Drawing.Size(370, 37);
            this.staff_nameTextBox.TabIndex = 5;
            // 
            // lunchRegisterBindingSource
            // 
            this.lunchRegisterBindingSource.DataSource = typeof(STAAS.Food.LunchRegister);
            // 
            // time_bookedTextBox
            // 
            this.time_bookedTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.time_bookedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.time_bookedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lunchRegisterBindingSource, "time_booked", true));
            this.time_bookedTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_bookedTextBox.Location = new System.Drawing.Point(57, 192);
            this.time_bookedTextBox.Name = "time_bookedTextBox";
            this.time_bookedTextBox.Size = new System.Drawing.Size(370, 37);
            this.time_bookedTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.button1.Location = new System.Drawing.Point(730, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 53);
            this.button1.TabIndex = 35;
            this.button1.Text = "Book lunch";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(513, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Protein";
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.employeeNameLabel.Location = new System.Drawing.Point(53, 265);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(186, 23);
            this.employeeNameLabel.TabIndex = 21;
            this.employeeNameLabel.Text = "Employee’s name";
            // 
            // soupTextBox
            // 
            this.soupTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.soupTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soupTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soupTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.soupTextBox.Location = new System.Drawing.Point(517, 192);
            this.soupTextBox.Name = "soupTextBox";
            this.soupTextBox.Size = new System.Drawing.Size(376, 37);
            this.soupTextBox.TabIndex = 18;
            // 
            // soupLabel
            // 
            this.soupLabel.AutoSize = true;
            this.soupLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soupLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.soupLabel.Location = new System.Drawing.Point(513, 154);
            this.soupLabel.Name = "soupLabel";
            this.soupLabel.Size = new System.Drawing.Size(154, 23);
            this.soupLabel.TabIndex = 17;
            this.soupLabel.Text = "Soup/Side Dish";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dateLabel.Location = new System.Drawing.Point(53, 154);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(55, 23);
            this.dateLabel.TabIndex = 16;
            this.dateLabel.Text = "Time";
            // 
            // mainCourseTextBox
            // 
            this.mainCourseTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.mainCourseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainCourseTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCourseTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mainCourseTextBox.Location = new System.Drawing.Point(517, 88);
            this.mainCourseTextBox.Name = "mainCourseTextBox";
            this.mainCourseTextBox.Size = new System.Drawing.Size(370, 37);
            this.mainCourseTextBox.TabIndex = 14;
            // 
            // mainCouseLabel
            // 
            this.mainCouseLabel.AutoSize = true;
            this.mainCouseLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCouseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mainCouseLabel.Location = new System.Drawing.Point(513, 50);
            this.mainCouseLabel.Name = "mainCouseLabel";
            this.mainCouseLabel.Size = new System.Drawing.Size(133, 23);
            this.mainCouseLabel.TabIndex = 13;
            this.mainCouseLabel.Text = "Main Course";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dayLabel.Location = new System.Drawing.Point(53, 50);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(49, 23);
            this.dayLabel.TabIndex = 12;
            this.dayLabel.Text = "Day";
            // 
            // bookLunchLabel
            // 
            this.bookLunchLabel.AutoSize = true;
            this.bookLunchLabel.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLunchLabel.ForeColor = System.Drawing.Color.Red;
            this.bookLunchLabel.Location = new System.Drawing.Point(469, 78);
            this.bookLunchLabel.Name = "bookLunchLabel";
            this.bookLunchLabel.Size = new System.Drawing.Size(365, 70);
            this.bookLunchLabel.TabIndex = 0;
            this.bookLunchLabel.Text = "Book Lunch";
            // 
            // staff_emailTextBox
            // 
            this.staff_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lunchRegisterBindingSource, "Staff_email", true));
            this.staff_emailTextBox.Location = new System.Drawing.Point(1793, 267);
            this.staff_emailTextBox.Name = "staff_emailTextBox";
            this.staff_emailTextBox.Size = new System.Drawing.Size(100, 27);
            this.staff_emailTextBox.TabIndex = 4;
            // 
            // dateTextBox1
            // 
            this.dateTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dateTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lunchRegisterBindingSource, "Date", true));
            this.dateTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox1.Location = new System.Drawing.Point(57, 95);
            this.dateTextBox1.Name = "dateTextBox1";
            this.dateTextBox1.Size = new System.Drawing.Size(370, 37);
            this.dateTextBox1.TabIndex = 37;
            // 
            // LunchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1030);
            this.Controls.Add(staff_emailLabel);
            this.Controls.Add(this.staff_emailTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bookLunchLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LunchForm";
            this.Text = "LunchForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LunchForm_FormClosing);
            this.Load += new System.EventHandler(this.LunchForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lunchRegisterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bookLunchLabel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.TextBox soupTextBox;
        private System.Windows.Forms.Label soupLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox mainCourseTextBox;
        private System.Windows.Forms.Label mainCouseLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox staff_nameTextBox;
        private System.Windows.Forms.BindingSource lunchRegisterBindingSource;
        private System.Windows.Forms.TextBox time_bookedTextBox;
        private System.Windows.Forms.TextBox staff_emailTextBox;
        private System.Windows.Forms.TextBox proteinTextBox;
        private System.Windows.Forms.TextBox dateTextBox1;
    }
}