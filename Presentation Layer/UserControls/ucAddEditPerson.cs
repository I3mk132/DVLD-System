using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.UserControls
{
    public partial class ucAddEditPerson : UserControl
    {
        private enum enMode { eAdd, eUpdate }
        private enMode _Mode;
        private int _PersonID;
        private ErrorProvider _FirstError, _SecondError,
            _ThirdError, _LastError, _NationalNoError,
            _EmailError, _AddressError, _PhoneError;
        private bool ErrorFlag = false;
        
        public ucAddEditPerson(int PersonID)
        {
            InitializeComponent();
            if (PersonID != -1)
                _Mode = enMode.eAdd;
            else
                _Mode = enMode.eUpdate;

            _PersonID = PersonID;

            DateTime date = DateTime.Now;
            dtpDateOfBirth.MaxDate = date.AddYears(-18);
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private string _OldEmail, _OldNationalNo; 
        private void ucAddEditPerson_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.eUpdate)
            {
                // clsPerson person = clsPerson.Find(_PersonID);
                txtFirst.Text = string.Empty;
                txtSecond.Text = string.Empty;
                txtThird.Text = string.Empty;
                txtLast.Text = string.Empty;
                txtNationalNo.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtAddress.Text = string.Empty;
                txtPhone.Text = string.Empty;
                
                dtpDateOfBirth.Value = DateTime.Now;
                cbCountry.SelectedIndex = 0;
                pbPerson.Image = null;
            }
            else
            {

            }
            _OldEmail = txtEmail.Text;
            _OldNationalNo = txtNationalNo.Text;

        }

        private void _setErrors()
        {
            if (txtEmail.Text != _OldEmail  && txtEmail.Text == "") // is  exists
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
        private void btnSave_Click(object sender, EventArgs e)
        {

            ErrorFlag = false;
            _setErrors();
            if (!ErrorFlag)
            {
                if (true) // save
                {
                    MessageBox.Show("Saved successfully. ");
                }
                else
                {
                    MessageBox.Show("Something went wrong while saving");
                }
            } 
        }
    }
}
