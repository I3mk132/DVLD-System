using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.UserForms
{
    public partial class frmUserDetails : Form
    {
        public frmUserDetails(int UserID, int PersonID)
        {
            InitializeComponent();
            ucPersonDetails1.PersonID = PersonID;
            ucLoginInfo1.UserID = UserID;
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
