namespace fingerprint
{
    partial class FingerEnroll
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
            System.Windows.Forms.Label templateLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label4;
            this.pbFingerprint = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboReaders = new System.Windows.Forms.ComboBox();
            this.save_button = new System.Windows.Forms.Button();
            this.templateTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.fingerprintBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            templateLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFingerprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fingerprintBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // templateLabel
            // 
            templateLabel.AutoSize = true;
            templateLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            templateLabel.Location = new System.Drawing.Point(360, 580);
            templateLabel.Name = "templateLabel";
            templateLabel.Size = new System.Drawing.Size(165, 23);
            templateLabel.TabIndex = 13;
            templateLabel.Text = "Finger Template";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(360, 529);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(152, 23);
            label3.TabIndex = 16;
            label3.Text = "Scanner name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(360, 92);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 23);
            label1.TabIndex = 18;
            label1.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(360, 127);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(84, 23);
            label5.TabIndex = 19;
            label5.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(360, 22);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(70, 23);
            label7.TabIndex = 27;
            label7.Text = "Name";
            // 
            // pbFingerprint
            // 
            this.pbFingerprint.BackColor = System.Drawing.Color.Transparent;
            this.pbFingerprint.Location = new System.Drawing.Point(461, 212);
            this.pbFingerprint.Name = "pbFingerprint";
            this.pbFingerprint.Size = new System.Drawing.Size(362, 244);
            this.pbFingerprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFingerprint.TabIndex = 7;
            this.pbFingerprint.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Place your finger on the scanner";
            // 
            // cboReaders
            // 
            this.cboReaders.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReaders.FormattingEnabled = true;
            this.cboReaders.Location = new System.Drawing.Point(531, 525);
            this.cboReaders.Name = "cboReaders";
            this.cboReaders.Size = new System.Drawing.Size(373, 31);
            this.cboReaders.TabIndex = 9;
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.save_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.save_button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.ForeColor = System.Drawing.Color.White;
            this.save_button.Location = new System.Drawing.Point(402, 622);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(460, 58);
            this.save_button.TabIndex = 10;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // templateTextBox
            // 
            this.templateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.templateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fingerprintBindingSource1, "Template", true));
            this.templateTextBox.Enabled = false;
            this.templateTextBox.Location = new System.Drawing.Point(531, 576);
            this.templateTextBox.Name = "templateTextBox";
            this.templateTextBox.Size = new System.Drawing.Size(373, 27);
            this.templateTextBox.TabIndex = 21;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fingerprintBindingSource1, "Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(531, 91);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(373, 27);
            this.departmentTextBox.TabIndex = 22;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fingerprintBindingSource1, "Gender", true));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(531, 126);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(373, 29);
            this.genderComboBox.TabIndex = 23;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fingerprintBindingSource1, "Name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(531, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(373, 27);
            this.nameTextBox.TabIndex = 26;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fingerprintBindingSource1, "Email", true));
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(531, 55);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(373, 27);
            this.emailTextBox.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(360, 55);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 23);
            label4.TabIndex = 29;
            label4.Text = "Email";
            // 
            // fingerprintBindingSource1
            // 
            this.fingerprintBindingSource1.DataSource = typeof(STAAS.Fingerprint.Fingerprint);
            // 
            // FingerEnroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1044);
            this.Controls.Add(label4);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(label7);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.templateTextBox);
            this.Controls.Add(label5);
            this.Controls.Add(label1);
            this.Controls.Add(label3);
            this.Controls.Add(templateLabel);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.cboReaders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbFingerprint);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FingerEnroll";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFingerprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fingerprintBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.PictureBox pbFingerprint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboReaders;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.BindingSource fingerprintBindingSource1;
        private System.Windows.Forms.TextBox templateTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}

