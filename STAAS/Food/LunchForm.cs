using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;
using STAAS.Food;
using System.Data.Entity;

namespace FoodAppSTAAS.Lunch
{
    public partial class LunchForm : Form
    {
        STAAS_dbEntities1 db = new STAAS_dbEntities1();
        string name;
        string email;
        string time;
        string date;
        public void GetName(string n)
        {
           name = n;
        }
        public void GetEmail(string n)
        {
           email = n;
        }
        public void GetTime(string n)
        {
            time= n;
        }
        public LunchForm()
        {
            InitializeComponent();
        }

        private void LunchForm_Load(object sender, EventArgs e)
        {
            db.FoodTables.Load();
            db.LunchRegisters.Load();
            var myDate = DateTime.Now;
            var dateString = myDate.Date.ToShortDateString();
            date = dateString;
            var foods = from data in db.FoodTables select data;
            this.lunchRegisterBindingSource.DataSource = db.LunchRegisters.Local.ToBindingList();
            this.lunchRegisterBindingSource.AddNew();
            foreach (var food in foods)
            {
                this.mainCourseTextBox.Text = food.Food;
                this.soupTextBox.Text = food.SideDish;
                this.proteinTextBox.Text = food.Protein;
            }
            this.staff_nameTextBox.Text = name;
            this.time_bookedTextBox.Text = time;
            this.staff_emailTextBox.Text = email;   
            this.dateTextBox1.Text = dateString;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.time_bookedTextBox.Text = time;
            this.staff_emailTextBox.Text = email;
            this.dateTextBox1.Text = date;
            this.lunchRegisterBindingSource.EndEdit();
            Int32 saved = db.SaveChanges();
            if(saved > 0)
            {
                MessageBox.Show("Lunch booked! Have a wonderful day!");
                this.Close();
            }else
            {
                MessageBox.Show("Error booking lunch. Try Again!");
            }
        }

        private void LunchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }
    }
}
