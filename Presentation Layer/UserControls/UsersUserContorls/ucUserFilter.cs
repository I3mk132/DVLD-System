using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.UserControls
{
    public partial class ucUserFilter : UserControl
    {
        public ucUserFilter()
        {
            InitializeComponent();

            cbFilterBy.SelectedIndex = 0;
        }
        public string FilterBy = "";
        public string FilterValue = "";



        private void gbFilter_Enter(object sender, EventArgs e)
        {

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            string filterMode = cbFilterBy.Text;
            FilterBy = filterMode;

            if (filterMode == "Is Active")
            {
                txtFilter.Visible = false;
                chkIsActive.Visible = true;
                chkIsActive.Focus();
            }
            else if (filterMode == "None")
            {
                txtFilter.Visible = false;
                chkIsActive.Visible = false;
                txtFilter.Text = "";
                chkIsActive.Checked = true;
            }
            else
            {
                txtFilter.Visible = true;
                chkIsActive.Visible = false;
                txtFilter.Focus();

                if (filterMode == "User ID" || filterMode == "Person ID")
                    txtFilter.KeyPress += txtFilter_KeyPress;
                else
                    txtFilter.KeyPress -= txtFilter_KeyPress;
            }
            
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            FilterValue = txtFilter.Text;
        }

    }
}
