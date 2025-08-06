using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.LicenseForms
{
    public partial class frmIssueLicenseFirstTime : Form
    {
        public frmIssueLicenseFirstTime(int LDLAppID, int AppID)
        {
            InitializeComponent();
            ucApplicaitonBasicInfo1.AppID = AppID;
            ucDLApplicationInfo1.AppID = LDLAppID;

        }

        private void frmIssueLicenseFirstTime_Load(object sender, EventArgs e)
        {

        }

        private void lblSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
