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
using Business_Layer;
using Presentation_Layer.Properties;

namespace Presentation_Layer.UserControls.LicensesUserControls
{
    public partial class ucLicenseInfo : UserControl
    {
        public int LicenseID = -1; 
        public ucLicenseInfo()
        {
            InitializeComponent();
        }

        private void ucLicenseInfo_Load(object sender, EventArgs e)
        {
            LoadLicenseData();
        }

        private void LoadLicenseData()
        {
            clsLicenses license = clsLicenses.Find(LicenseID);
            if (license != null )
            {
                lblClass.Text = license.LicenseClassName;
                lblName.Text = license.Fullname;
                lblLicenseID.Text = license.LicenseID.ToString();
                lblNationalNo.Text = license.NationalNo;
                lblGender.Text = license.Gender;
                lblIssueDate.Text = license.IssueDate.Value.ToString("d");
                lblIssueReason.Text = license.IssueReason;
                lblNotes.Text = license.Notes;
                lblDriverID.Text = license.DriverID.ToString();
                lblExpirationDate.Text = license.ExpirationDate.Value.ToString("d");
                lblDateOfBirth.Text = license.DateOfBirth.Value.ToString("d");
                lblIsActive.Text = (license.IsActive.Value) ? "Yes" : "No";
                lblIsDetained.Text = (license.IsDetained.Value) ? "Yes" : "No";

                if (license.ImagePath == "")
                    pbPicture.Image = (license.Gender == "Male" ? Resources.AnonymousMan : Resources.AnonymousWoman);
                else
                    pbPicture.Image =
                        Image.FromFile(
                            Path.Combine(
                                AppDomain.CurrentDomain.BaseDirectory, "Pictures", license.ImagePath
                                )); // LoadImage

                pbGender.Image = (license.Gender == "Male" ? Resources.Male : Resources.Female);

            }
            else
            {
                MessageBox.Show("License not found.");
            }
        }
    }
}
