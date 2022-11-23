using STAAS.Fingerprint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STAAS
{
    public partial class MovementRegister : Form
    {
        public MovementRegister()
        {
            InitializeComponent();
        }

       
        private void signOutButton_Click(object sender, EventArgs e)
        {
            MovementRegisterReason form = new MovementRegisterReason();
            form.ShowDialog();
            this.Close();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            MovementVerify form = new MovementVerify();
            form.ShowDialog();
            this.Close();
        }
    }
}
