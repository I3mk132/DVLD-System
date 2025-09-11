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
using Presentation_Layer.ApplicationForms.LicensesForms;

namespace Presentation_Layer.LicenseForms.DetainLicenseForms
{
    public partial class frmDetainLicense : Form
    {
        public frmDetainLicense()
        {
            InitializeComponent();
        }
        int LocalLicenseID = -1;

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to Detain license? ",
                "Detain License", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {

                //int DetainID, int LicenseID, DateTime? DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased,
                //DateTime? ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID
                clsDetainedLicenses DL = new clsDetainedLicenses();                

                DL.LicenseID = LocalLicenseID;
                DL.DetainDate = DateTime.Now;
                DL.FineFees = Convert.ToDecimal(txtFineFees.Text == "" ? "0" : txtFineFees.Text);
                DL.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                DL.IsReleased = false;

                if (DL.Save())
                {
                    MessageBox.Show(
                        " Licesne Detained Successfully with ID = " + DL.DetainID.ToString(),
                        "License Detain",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );

                    
                    lblDetainID.Text = DL.DetainID.ToString();
                    txtFineFees.Enabled = false;

                    lblShowLicenseInfo.Enabled = true;
                    lblSave.Enabled = false;

                }
                

            }
            else
            {
                MessageBox.Show(
                    "The License Couldn't be Detained. ",
                    "Detain Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFilter.Text == "")
                return;

            int LicenseID = Convert.ToInt32(txtFilter.Text);
            clsLicenses license = clsLicenses.Find(LicenseID);
            if (license != null)
            {
                if (license.IsDetained.Value)
                {
                    MessageBox.Show(
                        "License is already detainded. ",
                        "License Detain",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                ucLicenseCard1.LicenseID = LicenseID;
                LocalLicenseID = LicenseID;
                ucLicenseCard1.LoadData();

                lblLicenseID.Text = LocalLicenseID.ToString();
                lblDetainDate.Text = DateTime.Now.ToString("d");
                lblCreatedBy.Text = clsGlobal.CurrentUser.Username;


                lblShowLicenseHistory.Enabled = true;
                lblSave.Enabled = true;


            }
            else
            {
                MessageBox.Show("License not found. ");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(LocalLicenseID);
            frm.ShowDialog();
        }

        private void lblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsLicenses license = clsLicenses.Find(LocalLicenseID);

            frmLicenseHistory frm = new frmLicenseHistory(license.PersonID);
            frm.ShowDialog();
        }
    }
}
