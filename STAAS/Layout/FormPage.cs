using fingerprint;
using STAAS.UserManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STAAS.Chinonso.Pages
{
    public partial class FormPage : Form
    {
        public FormPage()
        {
            InitializeComponent();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminDashboard form = new AdminDashboard();
            form.ShowDialog();
            this.Close();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            //TimeSpan start = new TimeSpan(9, 0, 0); //9 o'clock. Opens
            //TimeSpan end = new TimeSpan(16, 0, 0); //4 o'clock. Closes
            //TimeSpan now = DateTime.Now.TimeOfDay;
            TimeSpan start = new TimeSpan(9, 0, 0); 
            TimeSpan now = DateTime.Now.TimeOfDay;
            TimeSpan end = new TimeSpan(16, 0, 0); 
            if (now < start || now > end)
            {
                FingerVerify form = new FingerVerify();
                form.ShowDialog();
            }
            else
            {
                LatenessScreen screen = new LatenessScreen();
                screen.ShowDialog();
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            MovementRegister form = new MovementRegister();
            form.ShowDialog();
        }
    }
}
