using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLDWindowsForms.Controls
{

  
    public partial class ucDrivingLicenseApplicationInfo : UserControl
    {


        private int _LocalDrivingLicenseApplicationID = -1;
        public int LocalDrivingLicenseApplicationID
        {
            get
            {
                return _LocalDrivingLicenseApplicationID;

            }
        }
        private LocalDrivingLicenseApplication _LocalApplication;
        public LocalDrivingLicenseApplication SelectedLocalApplicationInfo
        {
            get
            {
                return _LocalApplication;
            }
        }

      
        
        public ucDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadDrivingLicenseInfo(int LocalDrivingLicenseApplicationID)
        {
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;

            _LocalApplication = LocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);

            if (_LocalApplication != null)
            {
                ucApplicationBasicInfo1.LoadApplicationBasicInfo(_LocalApplication.ApplicationID);
                _FullDrivingLicenseInfo();

                return;

            }

            _ResetDrivingLicenseInfo();

            MessageBox.Show("There's no Driving License Application with this ID = " + LocalDrivingLicenseApplicationID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void _FullDrivingLicenseInfo()
        {
            lblLocalDrivingLicenseApplicationID.Text = _LocalApplication.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseTitle.Text = _LocalApplication.LicenseClassInfo.LicenseClassName;
            lblPassedTests.Text = LocalDrivingLicenseApplication.PassedTestsCount(_LocalDrivingLicenseApplicationID).ToString() + "/3";
        }
        

        private void _ResetDrivingLicenseInfo()
        {
            lblLocalDrivingLicenseApplicationID.Text = "[????]";
            lblLicenseTitle.Text = "[????]";
            lblPassedTests.Text = "0/3";
        }
        

        private void ucApplicationBasicInfo1_Load(object sender, EventArgs e)
        {

        
        
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblPassedTests_Click(object sender, EventArgs e)
        {

        }
    }
}
