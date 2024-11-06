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

namespace DVLDWindowsForms.Tests
{
    public partial class frmTakeTest : Form
    {


        private int _TestAppointmentID = 0;
        private clsTestType.enTestType _TestType;

        private TestAppointement _TestAppointmentInfo;
        
        public frmTakeTest(int AppointmentID, clsTestType .enTestType TestType )
        {
        
            this._TestAppointmentID = AppointmentID;
            this._TestType = TestType;

         
            
            InitializeComponent();


            switch (TestType)
            {
                case clsTestType.enTestType.VisionTest:
                    gbTestTypeTitle.Text = "Vision Test";
                    pbTestTypeImage.BackgroundImage = Properties.Resources.Vision_512;
                    break;

                case clsTestType.enTestType.WriteenTest:

                    gbTestTypeTitle.Text = "Writeen Test";
                    pbTestTypeImage.BackgroundImage = Properties.Resources.Written_Test_512;
                    break;

                case clsTestType.enTestType.StreetTest:


                    gbTestTypeTitle.Text = "Street Test";
                    pbTestTypeImage.BackgroundImage = Properties.Resources.driving_test_512;

                    break;
            }

        }

        private void _LoadData()
        {

            _TestAppointmentInfo = TestAppointement.GetTestAppointementByID(_TestAppointmentID);

            if (_TestAppointmentInfo == null)
            {
                MessageBox.Show("There is no Appointment With ID = " + _TestAppointmentID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = false;
                return;
            }

            lblLocalDrovongLicenseApplicationID.Text = _TestAppointmentInfo.LocalDrivingLicenseApplicationID.ToString();
            lblClassName.Text = _TestAppointmentInfo.LocalDrivingLicenseApplicationInfo.LicenseClassInfo.LicenseClassName;
            lblPersonFullName.Text = _TestAppointmentInfo.LocalDrivingLicenseApplicationInfo.ApplicationInfo.PersonInfo.FullName;
            lblTrials.Text = LocalDrivingLicenseApplication.TotalTrilesPerTest(_TestAppointmentInfo.LocalDrivingLicenseApplicationID, _TestAppointmentInfo.TestTypeID).ToString();
            lblAppointmentDate.Text = _TestAppointmentInfo.AppointementDate.ToShortDateString();
            lblAppointmentFees.Text = _TestAppointmentInfo.PaidFees.ToString();


        }

        private bool _HandleTestInfo()
        {
            clsTest _Test = new clsTest();

            _Test.TestAppointmentID = _TestAppointmentID;
            _Test.TestResult = (rbPass.Checked) ? true : false;
            _Test.Notes = tbNotes.Text.ToString ();
            _Test.CreatedByUserID = clsGlobal.CurrentUserInfo.UserID;

            if (!_Test .Save ())
            {
                MessageBox.Show("Error : Couldn't Save Test Information Verifie Your Informations and Try Later", 
                    "Faild Save Test ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSave.Enabled = false;
                return false;

            }

            lblTestID.Text = _Test.TestID.ToString();

            return true;

        }
       

        
        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            rbPass.Checked = true;

            _LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ( MessageBox.Show("Are you sure you want to save? After that you can not change the Pass/Fail Results ! ",
                   "AddNew Test ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (!_HandleTestInfo())
                    return;

                MessageBox.Show("Test Saved Successfuly ",
                       "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
            }
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
