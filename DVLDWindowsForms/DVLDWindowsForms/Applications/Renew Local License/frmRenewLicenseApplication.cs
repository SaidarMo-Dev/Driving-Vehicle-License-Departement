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


namespace DVLDWindowsForms.Applications.Renew_Local_License
{
    public partial class frmRenewLicenseApplication : Form
    {
        
        
        private int _OldLicenseID = -1;

        private clsLicense _OldLicenseInfo ;

        private int _NewLicenseID = -1;

        public frmRenewLicenseApplication()
        {
            InitializeComponent();
        }


        private void _FullBasicRenewApplicationInfo()
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString ();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = ApplicationType.GetApplicationType((int)clsApplication.enApplicationTypes.RenewDrivingLicenseService).ApplicationFees.ToString();
            lblCreatedby.Text = clsGlobal.CurrentUserInfo.UserName;

           
        }

        private void _HandleRenewLicense()
        {
            // first we handle an appliction of type Renew 

            clsApplication RenewApplication = new clsApplication();

            RenewApplication.ApplicationPersonID = _OldLicenseInfo.DriverInfo.PersonID;
            RenewApplication.ApplicationDate = DateTime.Now;
            RenewApplication.ApplicationTypeID = (int)clsApplication.enApplicationTypes.RenewDrivingLicenseService;
            RenewApplication.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            RenewApplication.LastStatusDate = DateTime.Now;
            RenewApplication.PaidFees = int.Parse(lblApplicationFees.Text.ToString());
            RenewApplication.CreatedByUserID = clsGlobal.CurrentUserInfo.UserID;


            if(!RenewApplication .Save ())
            {
                MessageBox.Show("There was a problem to save Renew License Application!", 
                    "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return;
            }

            lblRenewLicenseApplicationID.Text = RenewApplication.ApplicationID.ToString();

            // After we have successfully created an Application of type renew clsLicense 
            // we Moved to next step issueing a new Drivng clsLicense 

            clsLicense NewLicenseInfo = new clsLicense();

            NewLicenseInfo.ApplicationID = RenewApplication.ApplicationID;
            NewLicenseInfo.DriverID = _OldLicenseInfo.DriverID;
            NewLicenseInfo.LicenseClassID = _OldLicenseInfo.LicenseClassID;
            NewLicenseInfo.IssueDate = DateTime.Now;
            NewLicenseInfo.ExpirationDate = DateTime.Now.AddYears(_OldLicenseInfo.LicenseClassInfo.DefaultValidityLength);
            NewLicenseInfo.Notes = tbNotes.Text.ToString();
            NewLicenseInfo.PaidFees = double .Parse(lblTotalFees.Text);
            NewLicenseInfo.IsActive = true;
            NewLicenseInfo.IssueReason = clsLicense.enIssueReason.Renew;
            NewLicenseInfo.CreatedBuyUserID = clsGlobal.CurrentUserInfo.UserID;


            // before Issueing the new license we deactivate the old license 


            if(!_OldLicenseInfo.DeactivateLicense())
            {
                MessageBox.Show("Failed to Deactivate the old License try Later!",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if(!NewLicenseInfo.Save())
            {
                MessageBox.Show("Failed To save the new license Try Later!",
                    "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            lblRenewdLicenseID.Text = NewLicenseInfo.LicenseID.ToString();

            MessageBox.Show("License Renewed Successfully with ID = "+ NewLicenseInfo.LicenseID,
                    "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void frmRenewLicenseApplication_Load(object sender, EventArgs e)
        {
            _FullBasicRenewApplicationInfo();

        }

        private void ucDrivingLicenseInfoWithFilterCard1_OnLicenseSelected(int obj)
        {
            _OldLicenseID  = obj ;

            _OldLicenseInfo = clsLicense.GetLicenseInfoBylicenseID(obj);

            lblOldLicenseID.Text = _OldLicenseInfo.LicenseID.ToString();
            lblLicenseFees.Text = _OldLicenseInfo.PaidFees.ToString();
            lblExpirationDate.Text = DateTime.Now.AddYears(_OldLicenseInfo.LicenseClassInfo.DefaultValidityLength).ToShortDateString();

            lblTotalFees .Text = (double.Parse(lblApplicationFees .Text.ToString()) + _OldLicenseInfo.PaidFees).ToString();

            bool IsLicenseExpired = DateTime.Compare(DateTime.Now, _OldLicenseInfo.ExpirationDate) < 0;

            if(!_OldLicenseInfo .IsActive)
            {
                MessageBox.Show("Selected License is not Active, you can Renew only Active License",
                                 "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnRenew.Enabled = false;
                return;

            }
            if(!IsLicenseExpired)
            {
                MessageBox.Show("Selected License is not yet expired, it will exppired on : " 
                        + _OldLicenseInfo.ExpirationDate.ToShortDateString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnRenew.Enabled = false;
                return;

            }

            btnRenew.Enabled = true;


        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure you want to Renew the license", 
                    "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult .OK)
            {
                _HandleRenewLicense();
            }
        }



    }
}
