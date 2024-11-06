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
using DVLDWindowsForms.Applications.Licenses;

namespace DVLDWindowsForms.Applications.Release_Detain_License
{
    public partial class frmReleaseDetainedLicense : Form
    {
        enum enMode { AddNew = 1, Update = -1 };

        private enMode _Mode;

        private int _LicenseID = -1;
        private int _DetainID = -1;

        private DetainedLicense _DetainedLicenseInfo;


        public frmReleaseDetainedLicense(int DetainID = -1)
        {
            _DetainID = DetainID;

            _Mode = (DetainID != -1) ? enMode.Update : enMode.AddNew;
 

            InitializeComponent();
        }

        private void _LoadDetainLicenseInfo()
        {


            lblCreatedby.Text = clsGlobal.CurrentUserInfo.UserName;
            lblApplicationFees.Text = ApplicationType.GetApplicationType((int)clsApplication.enApplicationTypes.ReleaseDetainedDrivingLicsense).ApplicationFees.ToString();


            if (_Mode == enMode.AddNew)
            {
                _DetainedLicenseInfo = new DetainedLicense();

                return;

                
            }



            _DetainedLicenseInfo = DetainedLicense.GetDetainedLicenseInfoByDetainID(_DetainID);


            ucDrivingLicenseInfoWithFilterCard1.LoadLicenseData(_DetainedLicenseInfo.LicenseID);

            ucDrivingLicenseInfoWithFilterCard1.FilterEnabled = false;


            lblDetainID.Text = _DetainedLicenseInfo.DetainID.ToString();
            lblDetainDate.Text = _DetainedLicenseInfo.DetainDate.ToShortDateString();
            lblDetainedLicenseID.Text = _DetainedLicenseInfo.LicenseID.ToString();
            lblFineFeesFees.Text = _DetainedLicenseInfo.FineFees.ToString();

            lblTotalFees.Text = ((double.Parse(lblApplicationFees.Text.ToString())) + _DetainedLicenseInfo.FineFees).ToString();




        }


        private void _HandleReleaseDetainedLicense()
        {

            // first we create an application of type Release detained license service 

            clsApplication ReleaseDeatinedLicenseApp = new clsApplication();

            ReleaseDeatinedLicenseApp.ApplicationPersonID = _DetainedLicenseInfo.LicenseInfo.DriverInfo.PersonID;
            ReleaseDeatinedLicenseApp.ApplicationDate = DateTime.Now;
            ReleaseDeatinedLicenseApp.ApplicationTypeID = (int)clsApplication.enApplicationTypes.ReleaseDetainedDrivingLicsense;
            ReleaseDeatinedLicenseApp.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            ReleaseDeatinedLicenseApp.LastStatusDate = DateTime.Now;
            ReleaseDeatinedLicenseApp.PaidFees =  Convert.ToDouble(lblApplicationFees.Text);
            ReleaseDeatinedLicenseApp.CreatedByUserID = clsGlobal.CurrentUserInfo.UserID;

            if(!ReleaseDeatinedLicenseApp .Save ())
            {
                MessageBox.Show("Fieled To save Release Application!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            lblReleaseAppID.Text = ReleaseDeatinedLicenseApp.ApplicationID.ToString();

            _DetainedLicenseInfo.ReleaseDate = DateTime.Now;
            _DetainedLicenseInfo.ReleasedByUserID = clsGlobal.CurrentUserInfo.UserID;
            _DetainedLicenseInfo.ReleaseApplicationID = ReleaseDeatinedLicenseApp.ApplicationID;

            
            if(!_DetainedLicenseInfo .Save())
            {
                MessageBox.Show("Fieled To Release Selected License!", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("This License Released Successfully","License Released",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }


        private void ucDrivingLicenseInfoWithFilterCard1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;

            linkLblShowDetainedLicene.Enabled = true;
            linkLblShowPersonLicensesHistory.Enabled = true;

            if(_Mode == enMode .AddNew)
            {

                if (!DetainedLicense.IsLicenseDetained(obj))
                {
                    MessageBox.Show("Selected License Is Not Detained, Choose another One", "Not Allowed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return ;
                }


                _DetainedLicenseInfo = DetainedLicense.GetDetainedLicenseInfoByLicenseID(obj);

                lblDetainID.Text = _DetainedLicenseInfo.DetainID.ToString();
                lblDetainDate.Text = _DetainedLicenseInfo.DetainDate.ToShortDateString();
                lblDetainedLicenseID.Text = _DetainedLicenseInfo.LicenseID.ToString();
                lblFineFeesFees.Text = _DetainedLicenseInfo.FineFees.ToString();

                lblTotalFees.Text =(Convert .ToDouble(lblApplicationFees .Text .ToString()) + _DetainedLicenseInfo.FineFees).ToString();


            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (this .ValidateChildren())
            {
                if (MessageBox.Show("Are You Sure you want to Release This License?", "Confirm",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    _HandleReleaseDetainedLicense();

                    btnRelease.Enabled = false;

                }
            }


            
        }

        private void linkLblShowDetainedLicene_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense DetainedLicenseInfo = new frmShowLicense(_LicenseID);

            DetainedLicenseInfo.ShowDialog();


        }

        private void linkLblShowPersonLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicensesHistory personLicensesHistory = new frmPersonLicensesHistory(_DetainedLicenseInfo.LicenseInfo.DriverInfo.PersonID);

            personLicensesHistory.ShowDialog();


        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            _LoadDetainLicenseInfo();
        }





    }
}
