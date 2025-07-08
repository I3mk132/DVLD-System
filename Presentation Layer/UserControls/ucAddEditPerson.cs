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

namespace Presentation_Layer.UserControls
{
    public partial class ucAddEditPerson : UserControl
    {
        private enum enMode { eAdd, eUpdate }
        private enMode _Mode;
        public int PersonID = -1;
        private bool ErrorFlag = false;

        public ucAddEditPerson()
        {
            InitializeComponent();

            DateTime date = DateTime.Now;
            dtpDateOfBirth.MaxDate = date.AddYears(-18);
            dtpDateOfBirth.MinDate = date.AddYears(-100);
        }

        private void rbGender_CheckChanged(object sender, EventArgs e)
        {
            RadioButton rbGender = (RadioButton)sender;
            if (pbPersonImage.Image == null)
                pbPersonImage.Image =
                    (rbGender.Tag.ToString() == "Male" ? Resources.AnonymousMan : Resources.AnonymousWoman);

        }

        private string _OldEmail, _OldNationalNo;
        private void ucAddEditPerson_Load(object sender, EventArgs e)
        {
            // Determine mode based on PersonID
            if (PersonID == -1)
                _Mode = enMode.eAdd;
            else
                _Mode = enMode.eUpdate;

            if (_Mode == enMode.eUpdate)
            {
                clsPerson person = clsPerson.Find(PersonID);

                txtFirst.Text = person.Firstname.ToString();
                txtSecond.Text = person.Secondname.ToString();
                txtThird.Text = person.Thirdname.ToString();
                txtLast.Text = person.Lastname.ToString();
                txtNationalNo.Text = person.NationalNo.ToString();
                txtEmail.Text = person.Email.ToString();
                txtAddress.Text = person.Address.ToString();
                txtPhone.Text = person.Phone.ToString();

                dtpDateOfBirth.Value = person.DateOfBirth.Value;
                cbCountry.SelectedItem = person.Country;

                if (person.ImagePath == "")
                    pbPersonImage.Image = (person.Gender == "Male" ? Resources.AnonymousMan : Resources.AnonymousWoman);
                else
                    pbPersonImage.Image = 
                        Image.FromFile(
                            Path.Combine(
                                AppDomain.CurrentDomain.BaseDirectory, "Pictures", person.ImagePath
                                )); // LoadImage
                pbPersonImage.Tag = person.ImagePath.ToString();

                if (person.Gender == "Male")
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;
            }
            else
            {
                txtFirst.Text = string.Empty;
                txtSecond.Text = string.Empty;
                txtThird.Text = string.Empty;
                txtLast.Text = string.Empty;
                txtNationalNo.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtAddress.Text = string.Empty;
                txtPhone.Text = string.Empty;

                dtpDateOfBirth.Value = DateTime.Now.AddYears(-19);
                cbCountry.SelectedItem = "Turkey";

                pbPersonImage.Image = Resources.AnonymousMan;
                rbMale.Checked = true;

            }
            _OldEmail = txtEmail.Text;
            _OldNationalNo = txtNationalNo.Text;

        }

        private ErrorProvider _FirstError = new ErrorProvider(), _SecondError = new ErrorProvider(),
            _ThirdError = new ErrorProvider(), _LastError = new ErrorProvider(), _NationalNoError = new ErrorProvider(),
            _EmailError = new ErrorProvider(), _AddressError = new ErrorProvider(), _PhoneError = new ErrorProvider();


        private void _setErrors()
        {
            
            if (txtEmail.Text != _OldEmail && txtEmail.Text == "") // is  exists
            {
                _EmailError.SetError(txtEmail, "Email is already exists");
                ErrorFlag = true;
            }
            if (txtNationalNo.Text != _OldNationalNo && txtNationalNo.Text == "") // is exists 
            {
                _NationalNoError.SetError(txtNationalNo, "NationalNo is already exist");
                ErrorFlag = true;
            }

            // Check for Empty
            var ErrorSetter = new (TextBox TextBox, ErrorProvider ErrorProvider)[]
            {
                (txtFirst, _FirstError),
                (txtSecond, _SecondError),
                (txtThird, _ThirdError),
                (txtLast, _LastError),
                (txtNationalNo, _NationalNoError),
                (txtEmail, _EmailError),
                (txtAddress, _AddressError),
                (txtPhone, _PhoneError)
            };
            foreach (var (textBox, errorProvider) in ErrorSetter)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    errorProvider.SetError(textBox, "This option is mandatory");
                    ErrorFlag = true;
                }

                else
                    errorProvider.SetError(textBox, "");
            }
        }
        private void llblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select a photo: ";
            dialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            dialog.Multiselect = false;

            string ImagePath = "";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = dialog.FileName;

                Image image = Image.FromFile(ImagePath);

                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Pictures");
                if (!Directory.Exists("Pictures"))
                    Directory.CreateDirectory("Pictures");

                string Filename = Guid.NewGuid().ToString() + ".png";
                string FullPath = Path.Combine(folderPath, Filename);

                image.Save(FullPath);
                pbPersonImage.Tag = Filename;

                pbPersonImage.Image = image;
                pbPersonImage.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void rbGender_Chenged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (string.IsNullOrEmpty(pbPersonImage.Tag.ToString()))
                pbPersonImage.Image = (rb.Tag.ToString() == "Male" ? Resources.AnonymousMan : Resources.AnonymousWoman);

        }

        public delegate void DataBackEventHandler(object sender);
        public event DataBackEventHandler DataBack;
        private void btnSave_Click(object sender, EventArgs e)
        {

            ErrorFlag = false;
            _setErrors();
            if (!ErrorFlag)
            {
                clsPerson person;
                if (_Mode == enMode.eAdd)
                    person = new clsPerson();
                else
                    person = clsPerson.Find(PersonID: PersonID);

                person.Firstname = txtFirst.Text;
                person.Secondname = txtSecond.Text;
                person.Thirdname = txtThird.Text;
                person.Lastname = txtLast.Text;
                person.NationalNo = txtNationalNo.Text;
                person.Email = txtEmail.Text;
                person.Address = txtAddress.Text;
                person.Phone = txtPhone.Text;

                person.DateOfBirth = dtpDateOfBirth.Value;
                person.Country = cbCountry.SelectedItem.ToString();

                if (pbPersonImage.Image != null)
                    person.ImagePath = pbPersonImage.Tag.ToString();
                else
                    person.ImagePath = "";

                    person.Gender = (rbMale.Checked == true ? "Male" : "Female");

                if (person.Save()) // save
                {
                    MessageBox.Show("Saved successfully. ");
                    DataBack?.Invoke(this);
                }
                else
                {
                    MessageBox.Show("Something went wrong while saving");
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this);
        }
    }
}