namespace STAAS
{
    partial class MovementRegisterReason
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
            this.movementRegReasonPanel = new System.Windows.Forms.Panel();
            this.selectReasonRichTextBox = new System.Windows.Forms.RichTextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.selectReasonComboBox = new System.Windows.Forms.ComboBox();
            this.canelButton = new System.Windows.Forms.Button();
            this.selectReasonPanel = new System.Windows.Forms.Panel();
            this.selectReasonLabel = new System.Windows.Forms.Label();
            this.movementRegReasonPanel.SuspendLayout();
            this.selectReasonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // movementRegReasonPanel
            // 
            this.movementRegReasonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.movementRegReasonPanel.Controls.Add(this.selectReasonRichTextBox);
            this.movementRegReasonPanel.Controls.Add(this.doneButton);
            this.movementRegReasonPanel.Controls.Add(this.selectReasonComboBox);
            this.movementRegReasonPanel.Controls.Add(this.canelButton);
            this.movementRegReasonPanel.Controls.Add(this.selectReasonPanel);
            this.movementRegReasonPanel.Location = new System.Drawing.Point(426, 172);
            this.movementRegReasonPanel.Name = "movementRegReasonPanel";
            this.movementRegReasonPanel.Size = new System.Drawing.Size(452, 402);
            this.movementRegReasonPanel.TabIndex = 0;
            // 
            // selectReasonRichTextBox
            // 
            this.selectReasonRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.selectReasonRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectReasonRichTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectReasonRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.selectReasonRichTextBox.Location = new System.Drawing.Point(42, 186);
            this.selectReasonRichTextBox.Name = "selectReasonRichTextBox";
            this.selectReasonRichTextBox.Size = new System.Drawing.Size(360, 97);
            this.selectReasonRichTextBox.TabIndex = 5;
            this.selectReasonRichTextBox.Text = "";
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.doneButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.doneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.doneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.doneButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.doneButton.Location = new System.Drawing.Point(276, 327);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(120, 50);
            this.doneButton.TabIndex = 3;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // selectReasonComboBox
            // 
            this.selectReasonComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.selectReasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectReasonComboBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.selectReasonComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.selectReasonComboBox.FormattingEnabled = true;
            this.selectReasonComboBox.Items.AddRange(new object[] {
            "Client Visit",
            "Emergency",
            "Short Break",
            "Lunch",
            "Pick Delivery",
            "Others"});
            this.selectReasonComboBox.Location = new System.Drawing.Point(42, 124);
            this.selectReasonComboBox.Name = "selectReasonComboBox";
            this.selectReasonComboBox.Size = new System.Drawing.Size(360, 38);
            this.selectReasonComboBox.TabIndex = 2;
            this.selectReasonComboBox.SelectedValueChanged += new System.EventHandler(this.selectReasonComboBox_SelectedValueChanged);
            // 
            // canelButton
            // 
            this.canelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.canelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.canelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.canelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.canelButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.canelButton.Location = new System.Drawing.Point(42, 327);
            this.canelButton.Name = "canelButton";
            this.canelButton.Size = new System.Drawing.Size(120, 50);
            this.canelButton.TabIndex = 1;
            this.canelButton.Text = "Cancel";
            this.canelButton.UseVisualStyleBackColor = false;
            // 
            // selectReasonPanel
            // 
            this.selectReasonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.selectReasonPanel.Controls.Add(this.selectReasonLabel);
            this.selectReasonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectReasonPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.selectReasonPanel.Location = new System.Drawing.Point(0, 0);
            this.selectReasonPanel.Name = "selectReasonPanel";
            this.selectReasonPanel.Size = new System.Drawing.Size(452, 68);
            this.selectReasonPanel.TabIndex = 0;
            // 
            // selectReasonLabel
            // 
            this.selectReasonLabel.AutoSize = true;
            this.selectReasonLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectReasonLabel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.selectReasonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.selectReasonLabel.Location = new System.Drawing.Point(158, 25);
            this.selectReasonLabel.Name = "selectReasonLabel";
            this.selectReasonLabel.Size = new System.Drawing.Size(220, 37);
            this.selectReasonLabel.TabIndex = 1;
            this.selectReasonLabel.Text = "Select Reason";
            // 
            // MovementRegisterReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.BackgroundImage = global::STAAS.Properties.Resources.Background_Up;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1044);
            this.Controls.Add(this.movementRegReasonPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovementRegisterReason";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovementRegisterReason";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.movementRegReasonPanel.ResumeLayout(false);
            this.selectReasonPanel.ResumeLayout(false);
            this.selectReasonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel movementRegReasonPanel;
        private System.Windows.Forms.Panel selectReasonPanel;
        private System.Windows.Forms.Label selectReasonLabel;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.ComboBox selectReasonComboBox;
        private System.Windows.Forms.Button canelButton;
        private System.Windows.Forms.RichTextBox selectReasonRichTextBox;
    }
}