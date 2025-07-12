using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace Presentation_Layer.ApplicationForms
{
    public partial class frmEditApplication : Form
    {
        private int _id = -1;
        public frmEditApplication(int Id)
        {
            InitializeComponent();
            _id = Id;
        }

        private void pbIDValue_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ErrorProvider error = new ErrorProvider();
        private void btnSave_Click(object sender, EventArgs e)
        {
            int fee = (txtFees.Text == "") ? 0 : Convert.ToInt32(txtFees.Text);
            bool flag = false;
            if (fee < 0 )
            {
                error.SetError(txtFees, "You can't use a negative number. ");
                flag = true;
            }
            else
            {
                error.SetError(txtFees, "");
                flag = false;
            }
            if (txtTitle.Text == string.Empty)
            {
                error.SetError(txtTitle, "Title can't be empty. ");
                flag = true;
            }
            else
            {
                error.SetError(txtTitle, "");
                flag = false;
            }
            

            if (!flag)
            {
                clsApplicationTypes applicationType = clsApplicationTypes.Find(_id);

                applicationType.Fees = fee;
                applicationType.ApplicationType = txtTitle.Text;

                if (applicationType.Update())
                {
                    MessageBox.Show("Changes saved successfully. ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong while saving. ");
                }
            }
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmEditApplication_Load(object sender, EventArgs e)
        {
            clsApplicationTypes at = clsApplicationTypes.Find(_id);

            lblIDTitle.Text = _id.ToString();
            txtTitle.Text = at.ApplicationType;
            txtFees.Text = at.Fees.ToString();
        }
    }
}
