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
    public partial class ucLicenseCard : UserControl
    {
        public int LicenseID = -1;
        public ucLicenseCard()
        {
            InitializeComponent();
        }

        private void gbLicenseInfo_Enter(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            clsLicenses license = clsLicenses.Find(LicenseID);

            if (license != null)
            {
                lblClass.Text = license.LicenseClassName;
                lblName.Text = license.Fullname;
                lblLicenseID.Text = license.LicenseID.ToString();
                lblNationalNo.Text = license.NationalNo.ToString();
                lblGender.Text = license.Gender.ToString();
                lblIssueDate.Text = license.IssueDate.Value.ToString("d");
                lblIssueReason.Text = license.IssueReason.ToString();
                lblNotes.Text = license.Notes.ToString();
                lblIsActive.Text = (license.IsActive.Value ? "Yes" : "No");
                lblDateOfBirth.Text = license.DateOfBirth.Value.ToString("d");
                lblDriverID.Text = license.DriverID.ToString();
                lblExpirationDate.Text = license.ExpirationDate.Value.ToString("d");
                lblIsDetained.Text = (license.IsDetained.Value ? "Yes" : "No");

                if (license.ImagePath == "")
                    pbIcon.Image = (license.Gender == "Male" ? Resources.AnonymousMan : Resources.AnonymousWoman);
                else
                    pbIcon.Image =
                        Image.FromFile(
                            Path.Combine(
                                AppDomain.CurrentDomain.BaseDirectory, "Pictures", license.ImagePath
                                )); // LoadImage

                pbGender.Image = (license.Gender == "Male" ? Resources.Male : Resources.Female);
            }

        }

        private void ucLicenseCard_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
