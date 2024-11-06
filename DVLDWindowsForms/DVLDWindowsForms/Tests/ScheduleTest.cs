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
    public partial class frmScheduleTest : Form
    {
        enum enMode { AddNew = 1, Update = 2 };
        enum enCreationMode { FirstCreationTest = 1, RetakeTest = 2 };

        enMode _Mode;
        enCreationMode _CreationMode = enCreationMode.FirstCreationTest;

        private int _AppointmentID = -1;
        private TestAppointement _AppoinetmentInfo;
        private int _LocalApplicationID = -1;
        public int LocalApplicationID
        {
            get
            {
                return _LocalApplicationID;

            }
        }

        private LocalDrivingLicenseApplication _LocalApplicationInfo;

        public LocalDrivingLicenseApplication SelectedLocalApplicationInfo
        {
            get
            {
                return _LocalApplicationInfo;
            }
        }

        private clsTestType.enTestType _TestType;

        public frmScheduleTest(clsTestType.enTestType TestType, int LocalApplicationID)
        {

            this._Mode = enMode.AddNew;
            this._TestType = TestType;
            this._LocalApplicationID = LocalApplicationID;

            InitializeComponent();
        }

        public frmScheduleTest(int AppointmentID,clsTestType.enTestType TestType, int LocalApplicationID)
        {

            this._Mode = enMode.Update;

            this._TestType = TestType;
            this._LocalApplicationID = LocalApplicationID;
            this._AppointmentID = AppointmentID;

            InitializeComponent();
        }



        private void _PrepareTestTypePicture()
        {
            switch (_TestType )
            {
                case clsTestType.enTestType.VisionTest:

                    pictureBox1.BackgroundImage = Properties.Resources.Vision_512;

                    break;
                case clsTestType.enTestType.WriteenTest:

                    pictureBox1.BackgroundImage = Properties.Resources.Written_Test_512;

                    break;
                case clsTestType.enTestType.StreetTest:

                    pictureBox1.BackgroundImage = Properties.Resources.driving_test_512;

                    break;
            }
        }
      
        private void _LoadData()
        {
            _PrepareTestTypePicture();

            _LocalApplicationInfo = LocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(_LocalApplicationID);


            if (_LocalApplicationInfo == null)
            {

                MessageBox.Show("Error : No Application With ID = " + _LocalApplicationID, 
                    "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSave.Enabled = false;
                return;


            }
                          
            lblLocalApplicationID.Text = _LocalApplicationInfo.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseClasssName.Text = _LocalApplicationInfo.LicenseClassInfo.LicenseClassName;
            lblPersonFullName.Text = _LocalApplicationInfo.ApplicationInfo.PersonInfo.FullName;

            lblAppointementFees.Text = clsTestType.GetTestType((int)_TestType).Fees.ToString();
            
            // triels for this test 
            lblTrials.Text = LocalDrivingLicenseApplication.TotalTrilesPerTest(_LocalApplicationID, (int)_TestType).ToString();

            if (!_LocalApplicationInfo.DoesAttendTest((int)_TestType))
                _CreationMode = enCreationMode.FirstCreationTest;
            else
                _CreationMode = enCreationMode.RetakeTest;


            if (_CreationMode == enCreationMode.FirstCreationTest)
            {
                gbRetakeTestInfo.Enabled = false;
               
                lblRetakeTestAppID.Text = "N/A";
                lblRetakeTestApplicationFees.Text = "0";
                lblTotalFees.Text = lblAppointementFees.Text;
                lblTitle.Text = "Schedule Test";
               
            }
            else
            {
                gbRetakeTestInfo.Enabled = true;
                lblRetakeTestAppID.Text = "N/A";
                lblRetakeTestApplicationFees.Text = ApplicationType.GetApplicationType((int)clsApplication.enApplicationTypes.RetakeTest).ApplicationFees.ToString();
                lblTitle.Text = "Schedule Retake Test";
            
            }

            if (this._Mode == enMode.AddNew)
            {
                _AppoinetmentInfo = new TestAppointement();

                dtpTestAppointmentDate.MinDate = DateTime.Now;
                lblAppointementFees.Text = clsTestType.GetTestType((int)_TestType).Fees.ToString();

                lblRetakeTestAppID.Text = "N/A";

            }
            else
            {
                if (!_FillAppoinetmentInfo())
                    return;
            }

            lblTotalFees.Text = (Convert.ToSingle(lblAppointementFees.Text) + Convert.ToSingle(lblRetakeTestApplicationFees.Text)).ToString();
            



        }
      

        private bool _FillAppoinetmentInfo()
        {
           
            _AppoinetmentInfo = TestAppointement.GetTestAppointementByID(_AppointmentID);


            if (_AppoinetmentInfo == null)
            {
                MessageBox.Show("Error : No Appointement With ID = " + _AppointmentID, 
                    "Appointement Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSave.Enabled = false;

                return false;
            }

            lblAppointementFees.Text = _AppoinetmentInfo.PaidFees.ToString();

            // here we compare the current date with the appointement date to set the MinDate 
            if (DateTime.Compare(_AppoinetmentInfo.AppointementDate,DateTime .Now ) < 0)
                dtpTestAppointmentDate.MinDate = _AppoinetmentInfo.AppointementDate;

            else
                dtpTestAppointmentDate.MinDate = DateTime.Now;

            dtpTestAppointmentDate.Value = _AppoinetmentInfo.AppointementDate;
          

            if (_AppoinetmentInfo.RetakeTestApplicationID == -1)
            {
                lblRetakeTestAppID.Text = "N/A";
                lblRetakeTestApplicationFees.Text = "0";
                gbRetakeTestInfo.Enabled = false;

            }
            else
            {
                lblRetakeTestAppID.Text = _AppoinetmentInfo.RetakeTestApplicationID.ToString();
                lblRetakeTestApplicationFees.Text = _AppoinetmentInfo.RetakeTestApplicationInfo.PaidFees.ToString();
                gbRetakeTestInfo.Enabled = true;
                lblTitle.Text = "Schedule Retake Test";

            }




            return true;

        }

        private bool _HandleRetakeTestApplication()
        {
            if (_Mode == enMode .AddNew && _CreationMode == enCreationMode.RetakeTest )
            {
                clsApplication ApplicationInfo = new clsApplication();

                ApplicationInfo.ApplicationPersonID = _LocalApplicationInfo.ApplicationInfo.ApplicationPersonID;
                ApplicationInfo.ApplicationDate = DateTime.Now;
                ApplicationInfo.ApplicationTypeID = (int)clsApplication.enApplicationTypes.RetakeTest;
                ApplicationInfo.ApplicationStatus = clsApplication.enApplicationStatus.New;
                ApplicationInfo.LastStatusDate = DateTime.Now;
                ApplicationInfo.PaidFees = ApplicationType.GetApplicationType((int)clsApplication.enApplicationTypes.RetakeTest).ApplicationFees;
                ApplicationInfo.CreatedByUserID = clsGlobal.CurrentUserInfo.UserID;


                if(!ApplicationInfo .Save())
                {
                    _AppoinetmentInfo.RetakeTestApplicationID = -1;
                    MessageBox.Show("Error : Faild to Save this Application!",
                                   "Faild to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

                _AppoinetmentInfo.RetakeTestApplicationID = ApplicationInfo.ApplicationID;

               


            }
            return true;
        }
     


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _LoadData();

        }

        private void grbReatkeTestInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeTestApplication())
                return;

            _AppoinetmentInfo.TestTypeID = (int)_TestType;
            _AppoinetmentInfo.LocalDrivingLicenseApplicationID =_LocalApplicationInfo.LocalDrivingLicenseApplicationID;
            _AppoinetmentInfo.AppointementDate = dtpTestAppointmentDate.Value;
            _AppoinetmentInfo.PaidFees = Convert.ToDouble(lblAppointementFees.Text);
            _AppoinetmentInfo.CreatedByUserID = clsGlobal.CurrentUserInfo.UserID;
            _AppoinetmentInfo.IsLocked = false;

            if (_AppoinetmentInfo .Save())
            {
                if (_AppoinetmentInfo .RetakeTestApplicationID != -1)
                    lblRetakeTestAppID.Text = _AppoinetmentInfo.RetakeTestApplicationID.ToString();

                MessageBox.Show("Appointment Saved Successfuly.",
                                  "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error : Faild to Save this Appointment!",
                                  "Faild to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSave.Enabled = false;

            }



        }
    }
}
