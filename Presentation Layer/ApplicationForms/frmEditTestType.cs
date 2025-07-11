﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace Presentation_Layer.ApplicationForms
{
    public partial class frmEditTestType : Form
    {
        private int _id;
        public frmEditTestType(int ID)
        {
            InitializeComponent();
            _id = ID;
        }

        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            clsTestTypes at = clsTestTypes.Find(_id);

            lblIDTitle.Text = _id.ToString();
            txtTitle.Text = at.Title;
            txtDescription.Text = at.Description;
            txtFees.Text = at.Fees.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ErrorProvider error = new ErrorProvider();
        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal fee = (txtFees.Text == "") ? 0 : Convert.ToDecimal(txtFees.Text);

            bool flag = false;
            if (fee < 0)
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

            if (txtDescription.Text == string.Empty)
            {
                error.SetError(txtDescription, "Description can't be empty.");
                flag = true;
            }
            else
            {
                error.SetError(txtDescription, "");
                flag = false;
            }

            if (!flag)
            {
                clsTestTypes testType = clsTestTypes.Find(_id);


                testType.Fees = fee;
                testType.Title = txtTitle.Text;
                testType.Description = txtDescription.Text;

                if (testType.Update())
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

    }
}
