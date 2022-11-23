using System.DirectoryServices;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using fingerprint;
using FoodAppSTAAS.Lunch;
using STAAS.Food;
using System.Data.Entity;

namespace STAAS.UserManagement
{
    public partial class AdminDashboard : MaterialForm
    {
        STAAS_dbEntities1 db = new STAAS_dbEntities1();
        public AdminDashboard()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo500, Primary.Indigo500, Accent.Indigo700, TextShade.WHITE);
           
        }
        SearchResultCollection results;
        private string GetCurrentDomainPath()
        {
            DirectoryEntry de = new DirectoryEntry("LDAP://RootDSE");
            return "LDAP://" + de.Properties["defaultNamingContext"][0].ToString();
        }

        private void GetAllUsers()
        {
            DirectorySearcher ds = null;
            DirectoryEntry de = new
            DirectoryEntry(GetCurrentDomainPath());


            ds = new DirectorySearcher(de);
            ds.Filter = "(&(objectCategory=User)(objectClass=person))";

            results = ds.FindAll();
            materialListView1.Items.Clear();
            foreach (SearchResult sr in results)
            {
                // Using the index zero (0) is required!
                if (sr.Properties["name"].Count > 0 && sr.Properties["mail"].Count > 0)
                {
                    ListViewItem item = new ListViewItem(sr.Properties["name"][0].ToString());
                    item.SubItems.Add(sr.Properties["mail"][0].ToString());
                    materialListView1.Items.Add(item);
                }
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {        
            GetAllUsers();
            db.FoodTables.Load();
            db.LunchRegisters.Load();
            var food = from data in db.FoodTables select data;
            
            var myDate = DateTime.Now;
            var dateString = myDate.Date.ToShortDateString();

            var booked = from data in db.LunchRegisters where data.Date == dateString select data;
            this.materialLabel2.Text = booked.Count().ToString();
            foreach (var item in food)
            {
                this.mainCourse_label.Text = item.Food;
                this.protien_label.Text = item.Protein;
                this.sideDish_label.Text = item.SideDish;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                ReloadUsers();
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user");
                return;
            }
            FingerEnroll form = new FingerEnroll();
            form.SetName(materialListView1.SelectedItems[0].Text);
            form.SetEmail(materialListView1.SelectedItems[0].SubItems[1].Text);
            form.ShowDialog();
        }

        private void ReloadUsers()
        {
            materialListView1.Items.Clear();
            foreach (SearchResult sr in results)
            {
                // Using the index zero (0) is required!
                if (sr.Properties["name"].Count > 0 && sr.Properties["mail"].Count > 0)
                {
                    ListViewItem item = new ListViewItem(sr.Properties["name"][0].ToString());
                    item.SubItems.Add(sr.Properties["mail"][0].ToString());
                    materialListView1.Items.Add(item);
                }
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                for (int i = materialListView1.Items.Count - 1; i >= 0; i--)
                {
                    var item = materialListView1.Items[i];
                    if (item.Text.ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        materialListView1.Items.Remove(item);
                    }
                }
            }
            else
            {
                return;
            }
           
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.edit_btn.Enabled = true;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            LunchApp form = new LunchApp();
            form.ShowDialog();
        }
    }
}
