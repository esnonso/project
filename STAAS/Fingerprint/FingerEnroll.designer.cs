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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label fingerTemplateLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label genderLabel;
            this.pbFingerprint = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboReaders = new System.Windows.Forms.ComboBox();
            this.save_button = new System.Windows.Forms.Button();
            this.fingerTemplateTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label3 = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            fingerTemplateLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFingerprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(44, 437);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(152, 23);
            label3.TabIndex = 16;
            label3.Text = "Scanner name";
            // 
            // pbFingerprint
            // 
            this.pbFingerprint.BackColor = System.Drawing.Color.Transparent;
            this.pbFingerprint.Location = new System.Drawing.Point(145, 120);
            this.pbFingerprint.Name = "pbFingerprint";
            this.pbFingerprint.Size = new System.Drawing.Size(362, 244);
            this.pbFingerprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFingerprint.TabIndex = 7;
            this.pbFingerprint.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Place your finger on the scanner";
            // 
            // cboReaders
            // 
            this.cboReaders.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReaders.FormattingEnabled = true;
            this.cboReaders.Location = new System.Drawing.Point(215, 433);
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
            this.save_button.Location = new System.Drawing.Point(87, 490);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(460, 58);
            this.save_button.TabIndex = 10;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(564, 233);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(112, 21);
            departmentLabel.TabIndex = 19;
            departmentLabel.Text = "Department:";
            // 
            // fingerTemplateTextBox
            // 
            this.fingerTemplateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fingerTemplateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "FingerTemplate", true));
            this.fingerTemplateTextBox.Enabled = false;
            this.fingerTemplateTextBox.Location = new System.Drawing.Point(761, 306);
            this.fingerTemplateTextBox.Name = "fingerTemplateTextBox";
            this.fingerTemplateTextBox.Size = new System.Drawing.Size(421, 27);
            this.fingerTemplateTextBox.TabIndex = 21;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(761, 230);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(421, 27);
            this.departmentTextBox.TabIndex = 20;
            this.departmentTextBox.TextChanged += new System.EventHandler(this.departmentTextBox_TextChanged);
            // 
            // fingerTemplateLabel
            // 
            fingerTemplateLabel.AutoSize = true;
            fingerTemplateLabel.Location = new System.Drawing.Point(564, 309);
            fingerTemplateLabel.Name = "fingerTemplateLabel";
            fingerTemplateLabel.Size = new System.Drawing.Size(140, 21);
            fingerTemplateLabel.TabIndex = 20;
            fingerTemplateLabel.Text = "Finger Template:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(564, 191);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(55, 21);
            emailLabel.TabIndex = 18;
            emailLabel.Text = "Email:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Gender", true));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(761, 267);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(421, 29);
            this.genderComboBox.TabIndex = 22;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.genderComboBox_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(564, 157);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(62, 21);
            nameLabel.TabIndex = 17;
            nameLabel.Text = "Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(564, 270);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(74, 21);
            genderLabel.TabIndex = 21;
            genderLabel.Text = "Gender:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(761, 151);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(421, 27);
            this.nameTextBox.TabIndex = 18;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Email", true));
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(761, 188);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(421, 27);
            this.emailTextBox.TabIndex = 19;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataSource = typeof(STAAS.Fingerprint.Staff);
            // 
            // FingerEnroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1044);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.save_button);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.cboReaders);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.pbFingerprint);
            this.Controls.Add(fingerTemplateLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.fingerTemplateTextBox);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FingerEnroll";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFingerprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.PictureBox pbFingerprint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboReaders;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.TextBox fingerTemplateTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}

