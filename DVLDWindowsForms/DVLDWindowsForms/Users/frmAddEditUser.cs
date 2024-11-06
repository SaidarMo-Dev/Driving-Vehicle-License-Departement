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

namespace DVLDWindowsForms
{
    public partial class frmAddEditUser : Form
    {
        enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private int UserID = -1;

        private User _User;


        bool IsPasswordValide = false;

        bool IsUsernameValide = false;

        public frmAddEditUser()
        {


            InitializeComponent();

            _Mode = enMode.AddNew;

           
        }


        public frmAddEditUser(int ID)
        {

            
            InitializeComponent();
          

            this.UserID = ID;
            
            if (ID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
                _Mode = enMode.Update;
        
        }




        private void _LoadUserData()
        {
 
            if (_Mode == enMode.AddNew )
            {
                lblTitle.Text = "Add New User";
                _User = new User();
                
                return;
            }


            _User = User.GetUserByID(UserID);

            lblTitle.Text = "Update User";
            ucFindPerson1.FilterEnabled = false;

            // Load user info 
            

            lblUserID.Text = _User.UserID.ToString();
            tbUserName.Text = _User.UserName.ToString();
            tbPassword.Text = _User.Password.ToString();
            tbConfirmPassword.Text = _User.Password.ToString();
            ckbIsActive.Checked = _User.IsActive;
            ucFindPerson1.LoadPersonInfo(_User.PersonID);


            
        }

        private bool _GetUserStatus()
        {
            return (ckbIsActive.Checked);
        }

        private void _CollecteUserInfo()
        {
            if (_Mode == enMode.AddNew)
            {
                _User.PersonID = ucFindPerson1.SelectedPersonID;
            }
            
            _User.UserName = tbUserName.Text.Trim();
            _User.Password = tbPassword.Text.Trim();
            _User.IsActive = _GetUserStatus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsPasswordValide && IsUsernameValide)
            {
                _CollecteUserInfo();

                if (_User.Save())
                {
                    lblUserID.Text = _User.UserID.ToString();

                    MessageBox.Show("User saved succssefully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error Couldn't save User", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Some fields are not valid", "", MessageBoxButtons .OK,MessageBoxIcon.Warning);


           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _LoadUserData();
       
        }

        private void ucFindPerson1_Load(object sender, EventArgs e)
        {

        }

        private void ucFindPerson1_OnPersonSelected(int obj)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ucFindPerson1_Load_1(object sender, EventArgs e)
        {

        }

        private void ucFindPerson1_OnPersonSelected_1(int obj)
        {
            if (User .IsPersonhaveUser(obj))
            {
                MessageBox.Show("This Person already Have a User, You can not Create More Than one User Within a Person",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSave.Enabled = false;
            }
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbPassword .Text.ToString() != tbConfirmPassword.Text.ToString ())
            {
                IsPasswordValide = false;
                epConfirmPassword.SetError(tbConfirmPassword, "Passwords Deosn't match");

            }
            else
            {
                
                epConfirmPassword.SetError(tbConfirmPassword, "");
                IsPasswordValide= true;
            }


        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text.ToString()))
            {
                IsPasswordValide = false;
                epConfirmPassword.SetError(tbPassword, "this field shouldn't be empty ");

            }
            else
            {

                epConfirmPassword.SetError(tbPassword, "");
                IsPasswordValide = true;
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabCUserInfo.SelectedIndex = 1;

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            if (User.IsUserExisteByUsername(tbUserName.Text.ToString()) &&  tbUserName.Text.ToString () !=  _User.UserName )
            {
                IsUsernameValide = false;
                epConfirmPassword.SetError(tbUserName, "This Username already Existe! Shose another One ");

            }
            else
            {

                epConfirmPassword.SetError(tbUserName, "");
                IsUsernameValide = true;
            }
        }
    }
}
