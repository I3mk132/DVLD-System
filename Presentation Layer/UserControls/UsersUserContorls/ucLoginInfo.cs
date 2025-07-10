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
    public partial class ucLoginInfo : UserControl
    {
        public ucLoginInfo()
        {
            InitializeComponent();
        }
        public clsUsers User;

        private int _UserID = -1;
        public int UserID
        {
            get => _UserID;
            set
            {
                _UserID = value;
            }
        }

        private void _LoadUserData()
        {
            if (_UserID <= 0)
            {
                return;
            }

            User = clsUsers.Find(UserID: _UserID);
            if (User != null)
            {
                lblUserIDValue.Text = User.UserID.ToString();
                lblUsernameValue.Text = User.Username.ToString();
                lblIsActiveValue.Text = User.IsActive.ToString();

            }
        }

        private void ucLoginInfo_Load(object sender, EventArgs e)
        {
            _LoadUserData();
        }
    }
}
