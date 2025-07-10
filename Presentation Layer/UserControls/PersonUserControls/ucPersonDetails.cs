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
using Presentation_Layer.PeopleForms;
using Presentation_Layer.Properties;

namespace Presentation_Layer.UserControls
{
    public partial class ucPersonDetails : UserControl
    {
        public ucPersonDetails()
        {
            InitializeComponent();
        }

        private void llblEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(_personID);
            frm.ShowDialog();
            _LoadPersonData();
        }

        public clsPerson person;

        private int _personID = -1;
        public int PersonID
        {
            get => _personID;
            set
            {
                _personID = value;
                lblPersonID.Text = value.ToString();
            }
        }
        private void _LoadPersonData()
        {
            if (_personID <= 0)
            {
                return;
            }

            person = clsPerson.Find(PersonID: _personID);
            if (person != null)
            {
                lblName.Text = person.GetPersonFullName();
                lblNationalNo.Text = person.NationalNo.ToString();
                lblGender.Text = person.Gender.ToString();
                lblEmail.Text = person.Email.ToString();
                lblAddress.Text = person.Address.ToString();
                lblDateOfBirth.Text = person.DateOfBirth.Value.ToString("d");
                lblPhone.Text = person.Phone.ToString();
                lblCountry.Text = person.Country.ToString();

                if (person.ImagePath == "")
                    pbPicture.Image = (person.Gender == "Male" ? Resources.AnonymousMan : Resources.AnonymousWoman);
                else
                    pbPicture.Image =
                        Image.FromFile(
                            Path.Combine(
                                AppDomain.CurrentDomain.BaseDirectory, "Pictures", person.ImagePath
                                )); // LoadImage

                pbGender.Image = (person.Gender == "Male" ? Resources.Male : Resources.Female);
            }
        }
        private void ucPersonDetails_Load(object sender, EventArgs e)
        {
            _LoadPersonData();
        }
        public void LoadPersonData()
        {
            _LoadPersonData();
        }
    }
}