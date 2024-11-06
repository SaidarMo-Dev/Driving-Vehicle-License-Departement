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


namespace DVLDWindowsForms.Users
{
    public partial class frmChangePassword : Form
    {
        private User  _User;
        private bool IsPasswordValide = false;


        public frmChangePassword(int UserID)
        {
            InitializeComponent();

            this._User = User.GetUserByID(UserID);

            //ucShowPersonInfo1.PersonID = User.GetUserByID(UserID).PersonID;

            ucShowPersonInfo1.LoadPersonData(User.GetUserByID(UserID).PersonID);

            ucUserInfo1.UserID = UserID;


        }


        private void _CheckValidateOfPassword()
        {
            if (tbCurrentPasword.Text.ToString() != _User.Password)
            {
                IsPasswordValide = false;

            }
            else if (tbNewPassword.Text.ToString() == _User.Password)
            {
                IsPasswordValide = false;

            }
            else if (tbNewPassword.Text.ToString() != tbConfirmPassword.Text.ToString())
            {
                IsPasswordValide = false;

            }
            else
                IsPasswordValide = true;

        }

        private void _SaveNewPassword()
        {

            _CheckValidateOfPassword();

            if (IsPasswordValide)
            {

                _User.Password = tbNewPassword.Text.ToString();



                if (_User.Save())
                {
                    MessageBox.Show("Password Saved Successfuly", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Password was not saved ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Some fields are not valide","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

       
        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void ucShowPersonInfo1_Load(object sender, EventArgs e)
        {

        }

        private void tbCurrentPasword_TextChanged(object sender, EventArgs e)
        {

            if (tbCurrentPasword .Text .ToString() != _User.Password)
            {
                IsPasswordValide = false;
                epValidateOfPassword .SetError(tbCurrentPasword, "Wrong Pasword");

            }
            else
            {

               epValidateOfPassword .SetError(tbCurrentPasword, "");
                IsPasswordValide = true;
            }
            
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {

            if ( tbConfirmPassword.Text.ToString() != tbNewPassword.Text.ToString ())
            {
                IsPasswordValide = false;
                epValidateOfPassword.SetError(tbConfirmPassword, " Passwords Doesn't Match");

            }
            else
            {

                epValidateOfPassword.SetError(tbConfirmPassword, "");
               
                if (tbNewPassword.Text .ToString () != _User .Password)
                {
                    IsPasswordValide = true;
                }

             
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveNewPassword();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ucUserInfo1_Load(object sender, EventArgs e)
        {

        }

        private void tbNewPassword_TextChanged(object sender, EventArgs e)
        {

            if (tbNewPassword.Text.ToString() == _User.Password)
            {
                IsPasswordValide = false;
                epValidateOfPassword.SetError(tbNewPassword, "New Password can not be the current password !!");

            }
            else
            {

                epValidateOfPassword.SetError(tbNewPassword, "");
                IsPasswordValide = true;
            }
        }
    
    
    
    }
}
