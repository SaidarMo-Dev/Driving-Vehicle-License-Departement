using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;
using DVLD.Classes;

namespace DVLDWindowsForms
{
    public partial class LoginPage : Form
    {

        private User _UserLoginInfo;

        public LoginPage()
        {
            InitializeComponent();
        }
        
     

    
     
        private void _CheckUserLoginInfo()
        {


            _UserLoginInfo = User.GetUserInfoByUsernameAndPassword(tbUsername.Text.Trim(), tbPassword.Text.Trim());

            if (_UserLoginInfo != null)
            {

                if (_UserLoginInfo.IsActive)
                {

                    if(ckbRememberMe.Checked)
                    {


                        Task.Run(() => clsGlobal.RememberUsernameAndPassword(_UserLoginInfo.UserName, _UserLoginInfo.Password));

                    }
                    else
                    {
                        Task.Run(() => clsGlobal.RememberUsernameAndPassword("", ""));
                    }



                    clsGlobal.CurrentUserInfo = _UserLoginInfo;

                    frmMain frmLoginToSystem = new frmMain(this);

                    this.Hide();

                    frmLoginToSystem.ShowDialog();

                }
                else
                {
                    MessageBox.Show("This User is Desactivated Contact your Admin!",
                        "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }


            }
            else
            {
                MessageBox.Show("incorrect Username/Password!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
       

        }


        private void frmLoginPage_Load(object sender, EventArgs e)
        {


            string Username = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref Username, ref Password))
            {
                ckbRememberMe.Checked = true;

                tbUsername.Text = Username;
                tbPassword.Text = Password;

            }


        }

     
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    
        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ckbRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _CheckUserLoginInfo();

        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("this Option Not Emplemented Yet...");
        }
    }
}
