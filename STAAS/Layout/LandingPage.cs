using System;
using System.DirectoryServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace STAAS.Chinonso.Pages
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin adminForm = new AdminLogin();
            adminForm.ShowDialog();
        }
    }
}
