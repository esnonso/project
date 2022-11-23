using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodAppSTAAS.Lunch
{
    public partial class BookLunch : Form
    {
        string name;
        string email;
        string time;
        public void SetName(string n)
        {
            this.label3.Text = this.label3.Text + " " + n;
            name = n;
        }
        public void SetEmail(string n)
        {
            email= n;
        }
        public void SetTime(string n)
        {
            time = n;
        }
        public BookLunch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LunchForm form = new LunchForm();
            form.GetName(name);
            form.GetTime(time);
            form.GetEmail(email);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
