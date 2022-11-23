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
    public partial class MovementRegisterReason : Form
    {
        public MovementRegisterReason()
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
            MovementVerify form = new MovementVerify();
            if (selectReasonRichTextBox.Visible)
            {
                form.SetMovementReason(selectReasonRichTextBox.Text);
            }
            else
            {
                form.SetMovementReason(selectReasonComboBox.Text);
            }
            form.SetRequestType("signOut");
            form.ShowDialog();
            this.Close();
        }
    }
}
