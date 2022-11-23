using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fingerprint;
using STAAS.Chinonso.Pages;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace STAAS
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            try
            {
                //VERIFY USER IS ORGANIZATION MEMBER WITH AD EMAIL AND PASSWORD
                DirectoryEntry de = new DirectoryEntry("LDAP://" + "HA-SHEM.com", email.Text, password.Text);
                DirectorySearcher dsearch = new DirectorySearcher(de);
                SearchResult results = null;
                results = dsearch.FindOne();

                //GET USER'S DETAILS AND CHECK IF USER IS ALLOWED TO OPEN APP
                DirectorySearcher ds = null;
                DirectoryEntry entry = new DirectoryEntry(GetCurrentDomainPath());
                SearchResult sr;
                ds = BuildUserSearcher(entry);
                ds.Filter = "(&(objectCategory=User)(objectClass=person)(mail=" + email.Text + "))";

                sr = ds.FindOne();
                if (sr.Properties["name"][0].ToString() != "Chinonso A. Nneli")
                {
                    MessageBox.Show("You are not Authorized to open this app");
                    return;
                }
                FormPage form = new FormPage();
                form.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DirectorySearcher BuildUserSearcher(DirectoryEntry de)
        {
            DirectorySearcher ds = null;

            ds = new DirectorySearcher(de);

            // Full Name
            ds.PropertiesToLoad.Add("name");

            // Email Address
            ds.PropertiesToLoad.Add("mail");

            //// First Name
            //ds.PropertiesToLoad.Add("givenname");

            //// Last Name (Surname)
            //ds.PropertiesToLoad.Add("sn");

            //// Login Name
            //ds.PropertiesToLoad.Add("userPrincipalName");

            //// Distinguished Name
            //ds.PropertiesToLoad.Add("distinguishedName");

            return ds;
        }

        private string GetCurrentDomainPath()
        {
            DirectoryEntry de = new DirectoryEntry("LDAP://RootDSE");
            return "LDAP://" + de.Properties["defaultNamingContext"][0].ToString();
        }
    }
}
