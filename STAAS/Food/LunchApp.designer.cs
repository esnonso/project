namespace FoodAppSTAAS.Lunch
{
    partial class LunchApp
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
            this.Lunchpanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addMealButton = new System.Windows.Forms.Button();
            this.sideDishTextBox = new System.Windows.Forms.TextBox();
            this.foodTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodTextBox = new System.Windows.Forms.TextBox();
            this.proteinTextBox1 = new System.Windows.Forms.TextBox();
            this.soupLabel = new System.Windows.Forms.Label();
            this.proteinLabel = new System.Windows.Forms.Label();
            this.mainCouseLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.Lunchpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Lunchpanel
            // 
            this.Lunchpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lunchpanel.Controls.Add(this.textBox1);
            this.Lunchpanel.Controls.Add(this.addMealButton);
            this.Lunchpanel.Controls.Add(this.sideDishTextBox);
            this.Lunchpanel.Controls.Add(this.foodTextBox);
            this.Lunchpanel.Controls.Add(this.proteinTextBox1);
            this.Lunchpanel.Controls.Add(this.soupLabel);
            this.Lunchpanel.Controls.Add(this.proteinLabel);
            this.Lunchpanel.Controls.Add(this.mainCouseLabel);
            this.Lunchpanel.Controls.Add(this.dayLabel);
            this.Lunchpanel.Location = new System.Drawing.Point(308, 212);
            this.Lunchpanel.Name = "Lunchpanel";
            this.Lunchpanel.Size = new System.Drawing.Size(679, 336);
            this.Lunchpanel.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(50, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 37);
            this.textBox1.TabIndex = 1;
            // 
            // addMealButton
            // 
            this.addMealButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.addMealButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMealButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.addMealButton.Location = new System.Drawing.Point(50, 263);
            this.addMealButton.Name = "addMealButton";
            this.addMealButton.Size = new System.Drawing.Size(580, 48);
            this.addMealButton.TabIndex = 11;
            this.addMealButton.Text = "Add Meal";
            this.addMealButton.UseVisualStyleBackColor = false;
            this.addMealButton.Click += new System.EventHandler(this.addMealButton_Click);
            // 
            // sideDishTextBox
            // 
            this.sideDishTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.sideDishTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sideDishTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodTableBindingSource, "SideDish", true));
            this.sideDishTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideDishTextBox.Location = new System.Drawing.Point(375, 191);
            this.sideDishTextBox.Name = "sideDishTextBox";
            this.sideDishTextBox.Size = new System.Drawing.Size(255, 37);
            this.sideDishTextBox.TabIndex = 4;
            // 
            // foodTableBindingSource
            // 
            this.foodTableBindingSource.DataSource = typeof(STAAS.Food.FoodTable);
            // 
            // foodTextBox
            // 
            this.foodTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.foodTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodTableBindingSource, "Food", true));
            this.foodTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodTextBox.Location = new System.Drawing.Point(375, 75);
            this.foodTextBox.Name = "foodTextBox";
            this.foodTextBox.Size = new System.Drawing.Size(255, 37);
            this.foodTextBox.TabIndex = 3;
            // 
            // proteinTextBox1
            // 
            this.proteinTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.proteinTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proteinTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodTableBindingSource, "Protein", true));
            this.proteinTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinTextBox1.Location = new System.Drawing.Point(50, 191);
            this.proteinTextBox1.Name = "proteinTextBox1";
            this.proteinTextBox1.Size = new System.Drawing.Size(255, 37);
            this.proteinTextBox1.TabIndex = 2;
            // 
            // soupLabel
            // 
            this.soupLabel.AutoSize = true;
            this.soupLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soupLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.soupLabel.Location = new System.Drawing.Point(371, 153);
            this.soupLabel.Name = "soupLabel";
            this.soupLabel.Size = new System.Drawing.Size(166, 23);
            this.soupLabel.TabIndex = 7;
            this.soupLabel.Text = "Soup / Side Dish";
            // 
            // proteinLabel
            // 
            this.proteinLabel.AutoSize = true;
            this.proteinLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.proteinLabel.Location = new System.Drawing.Point(46, 153);
            this.proteinLabel.Name = "proteinLabel";
            this.proteinLabel.Size = new System.Drawing.Size(76, 23);
            this.proteinLabel.TabIndex = 6;
            this.proteinLabel.Text = "Protein";
            // 
            // mainCouseLabel
            // 
            this.mainCouseLabel.AutoSize = true;
            this.mainCouseLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCouseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mainCouseLabel.Location = new System.Drawing.Point(371, 37);
            this.mainCouseLabel.Name = "mainCouseLabel";
            this.mainCouseLabel.Size = new System.Drawing.Size(133, 23);
            this.mainCouseLabel.TabIndex = 1;
            this.mainCouseLabel.Text = "Main Course";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dayLabel.Location = new System.Drawing.Point(46, 37);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(49, 23);
            this.dayLabel.TabIndex = 0;
            this.dayLabel.Text = "Day";
            // 
            // LunchApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1044);
            this.Controls.Add(this.Lunchpanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LunchApp";
            this.Text = "LunchApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LunchApp_FormClosing);
            this.Load += new System.EventHandler(this.LunchApp_Load);
            this.Lunchpanel.ResumeLayout(false);
            this.Lunchpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Lunchpanel;
        private System.Windows.Forms.Label mainCouseLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label soupLabel;
        private System.Windows.Forms.Label proteinLabel;
        private System.Windows.Forms.Button addMealButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox sideDishTextBox;
        private System.Windows.Forms.BindingSource foodTableBindingSource;
        private System.Windows.Forms.TextBox foodTextBox;
        private System.Windows.Forms.TextBox proteinTextBox1;
    }
}