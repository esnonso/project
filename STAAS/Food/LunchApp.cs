using STAAS.Fingerprint;
using STAAS.Food;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodAppSTAAS.Lunch
{
    public partial class LunchApp : Form
    {
        STAAS_dbEntities1 db = new STAAS_dbEntities1();
        public LunchApp()
        {
            InitializeComponent();
        }

        private void LunchApp_Load(object sender, EventArgs e)
        {
            db.Foods.Load();
            this.foodTableBindingSource.DataSource = db.Foods.Local.ToBindingList();
            var foodExist = from data in db.Foods select data;
            if(foodExist.Count() == 0)
            {
                this.foodTableBindingSource.AddNew();
            }
            
        }

        private void LunchApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }

        private void addMealButton_Click(object sender, EventArgs e)
        {
            this.foodTableBindingSource.EndEdit();
            Int32 saved = db.SaveChanges();
            if(saved > 0)
            {
                MessageBox.Show("Lunch saved succesfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error Saving Food!");
            }
        }
    }
}
