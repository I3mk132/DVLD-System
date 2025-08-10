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

namespace Presentation_Layer.UserControls.LicenseUserControls
{
    public partial class ucInterLicenseCard : UserControl
    {

        public int InternationalLicenseID = -1;
        public ucInterLicenseCard()
        {
            InitializeComponent();
        }

        private void gbLicenseInfo_Enter(object sender, EventArgs e)
        {

        }


        private void LoadData()
        {
            clsInternationalLicenses license = clsInternationalLicenses.Find(InternationalLicenseID);
            if (license != null)
            {
                lblClass.Text = license.LocalLicense.LicenseClassName;
                lblName.Text = license.LocalLicense.Fullname;
                lblLicenseID.Text = license.IssuedUsingLocalLicenseID.ToString();
                lblNationalNo.Text = license.LocalLicense.NationalNo;
                lblGender.Text = license.LocalLicense.Gender;
                lblIsActive.Text = (license.IsActive ? "Yes":"No");
                lblIssueDate.Text = license.IssueDate.Value.ToString("d");
                lblIntLicenseID.Text = license.InternationalLicenseID.ToString();
                lblDateOfBirth.Text = license.LocalLicense.DateOfBirth.Value.ToString("d");
                lblDriverID.Text = license.DriverID.ToString();
                lblApplicationID.Text = license.ApplicationID.ToString();
                lblExpirationDate.Text = license.ExpirationDate.Value.ToString("d");

                if (license.LocalLicense.ImagePath == "")
                    pbIcon.Image = (license.LocalLicense.Gender == "Male" ? Resources.AnonymousMan : Resources.AnonymousWoman);
                else
                    pbIcon.Image =
                        Image.FromFile(
                            Path.Combine(
                                AppDomain.CurrentDomain.BaseDirectory, "Pictures", license.LocalLicense.ImagePath
                                )); // LoadImage

                pbGender.Image = (license.LocalLicense.Gender == "Male" ? Resources.Male : Resources.Female);

            }
        }

        private void ucInterLicenseCard_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
