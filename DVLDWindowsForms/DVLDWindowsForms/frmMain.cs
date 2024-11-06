using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDWindowsForms.Users;
using DVLDWindowsForms.Applications;
using DVLDWindowsForms.Tests;
using DVLDBusinessLayer;
//using DVLDWindowsForms.Applications;
using DVLDWindowsForms.Applications.InternationalLicenses;
using DVLDWindowsForms.Applications.Renew_Local_License;
using DVLDWindowsForms.Applications.ReplacementForLostOrDamaged;
using DVLDWindowsForms.Applications.Release_Detain_License;
using DVLDWindowsForms.Drivers;


using DVLDWindowsForms.Detain_Licenses;




namespace DVLDWindowsForms
{
    public partial class frmMain : Form 
    {

       
        private Form _Login; 
        public frmMain(LoginPage frmLogin)
        {

            InitializeComponent();

            _Login = frmLogin;
        
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmPeople = new frManagePeople();
            frmPeople.ShowDialog();
           
        }

     
        private void ParentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDrivers Drivers = new frmManageDrivers();

            Drivers.ShowDialog();

        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmManageUsers = new frmManageUsers();

            frmManageUsers.ShowDialog();
        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplacementForLostOrDamagedAplication ReplacementApp = new frmReplacementForLostOrDamagedAplication();

            ReplacementApp.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            clsGlobal.CurrentUserInfo = null;
            this.Close();
         
            _Login.Show();
     

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void accountUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmShowCurrentAccountDetails = new frmShowUserDetails(clsGlobal.CurrentUserInfo.UserID);

            frmShowCurrentAccountDetails.ShowDialog();


        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmChangeCurrentAccountPassword = new frmChangePassword(clsGlobal.CurrentUserInfo.UserID);

            frmChangeCurrentAccountPassword.ShowDialog();

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAppTypes = new frmListApplicationTypes();

            frmAppTypes.ShowDialog();

        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmManageTests = new ManageTest();
            frmManageTests.ShowDialog();


        }

        private void localeLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NewLocalDrLApplication = new frmAddEditLocalDrivingLicenseApplication();
            NewLocalDrLApplication.ShowDialog();

        }

        private void manageApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmManageLocalApplications = new frmManageLocaleDrinvingLicenseAppplication();
            frmManageLocalApplications.ShowDialog();


        }

        private void internationalDrivingApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageInternationalLicense InternationalLicenses = new frmManageInternationalLicense();


            InternationalLicenses.ShowDialog();

        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication NewIntLicenses = new frmNewInternationalLicenseApplication();

            NewIntLicenses.ShowDialog();

        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLicenseApplication RenewLicense = new frmRenewLicenseApplication();

            RenewLicense.ShowDialog();


        }

        private void manageDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDetainLicenses ListDetainLicenses = new frmManageDetainLicenses();

            ListDetainLicenses.ShowDialog();

        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense DetainLicense = new frmDetainLicense();

            DetainLicense.ShowDialog();

        }

        private void releaseDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense ReleaseLicense = new frmReleaseDetainedLicense();

            ReleaseLicense.ShowDialog();


        }
    }
}
