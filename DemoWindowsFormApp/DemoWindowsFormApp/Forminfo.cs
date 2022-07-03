using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWindowsFormApp
{
    public partial class Forminfo : Form
    {
        public Forminfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lBoxInfo.Items.Add(txtName.Text);
            /* MessageBox.Show(txtName.Text);*/

            if (rbtnMale.Checked == true)
            {
                lBoxInfo.Items.Add(txtName.Text);
                /*ShowOutput.Text = rbtnMale.Text;
                ShowOutput.Visible = true;*/
            }
            if (rbtnFemale.Checked == true)
            {
                lBoxInfo.Items.Add(txtName.Text);
                /*ShowOutput.Text = rbtnFemale.Text;
                ShowOutput.Visible = true;*/
            }

            if (chkBangla.Checked == true)
            {
                lBoxInfo.Items.Add(chkBangla.Text);
            }
            if (chkEnglish.Checked == true)
            {
                lBoxInfo.Items.Add(chkEnglish.Text);
            }
            lBoxInfo.Items.Add(cBoxCountry.Text);
        }
    }
    /*private void lblGender_Click(object sender, EventArgs e)
            {

            }

            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
        }
    }*/
}
