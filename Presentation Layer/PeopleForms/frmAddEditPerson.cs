﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.PeopleForms
{
    public partial class frmAddEditPerson : Form
    {
        public frmAddEditPerson(int PersonID = -1)
        {
            InitializeComponent();
            ucAddEditPerson1.PersonID = PersonID;
            if (PersonID != -1)
            {
                lblPersonAddEdit.Text = "Add New Person";
            }
            else
            {
                lblPersonAddEdit.Text = "Edit Person";
            }

        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
