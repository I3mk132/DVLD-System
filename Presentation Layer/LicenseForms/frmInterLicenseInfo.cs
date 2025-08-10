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

namespace Presentation_Layer.LicenseForms
{
    public partial class frmInterLicenseInfo : Form
    {
        
        public frmInterLicenseInfo(int InternationalLicenseID)
        {
            InitializeComponent();
            ucInterLicenseCard1.InternationalLicenseID =InternationalLicenseID;
        }

        private void frmInterLicenseInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
