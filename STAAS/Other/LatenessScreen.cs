using fingerprint;
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
    public partial class LatenessScreen : Form
    {
        public LatenessScreen()
        {
            InitializeComponent();
            selectReasonRichTextBox.Visible = false;
        }

        private void selectReasonComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            string expected = "Others";
            if (selectReasonComboBox.Text == expected)
            {
                selectReasonRichTextBox.Visible = true;
            }

            else { selectReasonRichTextBox.Visible = false; }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if(selectReasonRichTextBox.Text == "")
            {
                FingerVerify form = new FingerVerify();
                form.SetLateReason(selectReasonComboBox.Text);
                
                form.ShowDialog();
                this.Close();
            }else
            {
                FingerVerify form = new FingerVerify();
                form.SetLateReason(selectReasonRichTextBox.Text);
                form.ShowDialog();
                this.Close();
            }
        }
    }
}
