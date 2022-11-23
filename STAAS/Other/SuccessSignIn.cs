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
    public partial class SuccessSignIn : Form
    {
        string request;
        string name;
        public void SetName(string n)
        {
            name = n; 
        }
        public void SetTime(string n)
        {
            this.timeInLabel.Text = n;
        }

        public void SetEmail(string n)
        {
            this.uniqueId_label.Text = n;
        }
        public void SetRequest(string n)
        {
          request = n;
        }
        public SuccessSignIn()
        {
            InitializeComponent();
        }

        private void SuccessSignIn_Load(object sender, EventArgs e)
        {
            if(request == "signIn")
            {
                this.welcomeLabel.Text = "Welcome " + name;
                this.greeting.Text = "Do have a productive day";
                this.timeLabel.Text = "Time In";
            }
            else
            {
                this.welcomeLabel.Text = "Goodbye " + name;
                this.greeting.Text = "Do have a wonderful evening";
                this.timeLabel.Text = "Time Out";
            }
            if (request == "signOutMovt")
            {
                this.welcomeLabel.Text = "Hello " + name ;
                this.greeting.Text = "Do have a productive time and stay safe";
                this.timeLabel.Text = "Time Out";
            }
            if (request == "signInMovt")
            {
                this.welcomeLabel.Text = "Welcome back " + name;
                this.greeting.Text = "Hope you had a nice time out";
                this.timeLabel.Text = "Time In";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
