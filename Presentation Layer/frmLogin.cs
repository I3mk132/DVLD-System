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

namespace Presentation_Layer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        string FileName = "RememberedUser.txt";
        private (string Username, string Password) _ReadRememberedUser()
        {
            if (!File.Exists(FileName))
            {
                File.WriteAllText(FileName, ""); 
            }

            string UserDataLine = File.ReadAllText(FileName);


            string[] data = { "", "" };

            if (UserDataLine != "")
            {
                data = UserDataLine.Trim().Split(new[] { "#//#" }, StringSplitOptions.None);
            }
            return (data[0], data[1]);
        } 
        private void _WriteRememberedUser(string Username, string Password)
        {
            string Line = Username + "#//#" + Password;
            File.WriteAllText(FileName, Line);
        }
        private void _ClearRememberedUser()
        {
            File.WriteAllText(FileName, "");
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            (string, string) Userdata = _ReadRememberedUser();


            if (Userdata.Item1 != "")
            {
                txtUsername.Text = Userdata.Item1;
                txtPassword.Text = Userdata.Item2;
                chkRememberMe.Checked = true;
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            clsUsers user = clsUsers.Authenticate(Username, Password);
            if (user != null)
            {
                clsGlobal.CurrentUser = user;
                _ClearRememberedUser();
                if (chkRememberMe.Checked)
                    _WriteRememberedUser(Username, Password);

                this.Close();
 
            }
            else
            {
                MessageBox.Show(
                    "Username or Password is Invalid. ",
                    "Wrong Entry",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }
    }
}
