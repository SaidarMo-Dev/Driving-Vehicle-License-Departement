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

namespace DVLDWindowsForms.Applications.ReplacementForLostOrDamaged
{
    public partial class frmReplacementForLostOrDamagedAplication : Form
    {

        private int _OldLicenseID = -1;
        private clsLicense _OldLicenseInfo;

        private int _NewLicenseID = -1;
 
        public frmReplacementForLostOrDamagedAplication()
        {
            InitializeComponent();
        }


        private void _HandleIssueReplacementLicense()
        {
            // first we handle an appliction of type Replacement 

            clsApplication ReplacementApplication = new clsApplication();

            ReplacementApplication.ApplicationPersonID = _OldLicenseInfo.DriverInfo.PersonID;
            ReplacementApplication.ApplicationDate = DateTime.Now;
            ReplacementApplication.ApplicationTypeID = _HandleApplicationType();
            ReplacementApplication.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            ReplacementApplication.LastStatusDate = DateTime.Now;
            ReplacementApplication.PaidFees = double.Parse(lblApplicationFees.Text.ToString());
            ReplacementApplication.CreatedByUserID = clsGlobal.CurrentUserInfo.UserID;



            if(!ReplacementApplication .Save ())
            {
                MessageBox.Show("Failed to save the application Info verify your information and try again!",
                   "Error to save", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnIssueReplacement.Enabled = false;

            }


            lblReplacementLicenseApplicationID.Text = ReplacementApplication.ApplicationID.ToString();


            clsLicense ReplacementLicense = new clsLicense();

            ReplacementLicense.ApplicationID = ReplacementApplication.ApplicationID;
            ReplacementLicense.DriverID = _OldLicenseInfo.DriverID;
            ReplacementLicense.LicenseClassID = _OldLicenseInfo.LicenseClassID;
            ReplacementLicense.IssueDate = _OldLicenseInfo.IssueDate;
            ReplacementLicense.ExpirationDate = _OldLicenseInfo.ExpirationDate;
            ReplacementLicense.Notes = _OldLicenseInfo.Notes;
            ReplacementLicense.PaidFees = _OldLicenseInfo.PaidFees;
            ReplacementLicense.IsActive = true;
            ReplacementLicense.IssueReason = _HandleIssueReason();
            ReplacementLicense.CreatedBuyUserID = clsGlobal.CurrentUserInfo.UserID;

            // we should deactivate the old license before issueing the new license 


            _OldLicenseInfo.DeactivateLicense();


            if(!ReplacementLicense .Save ())
            {
                MessageBox.Show("Failed to save Replacement License!",
                   "Failed To Save", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            MessageBox.Show("License Replaced Successfully With ID = "+ ReplacementLicense .LicenseID,
                   "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ucDrivingLicenseInfoWithFilterCard1.FilterEnabled = false;

            _NewLicenseID = ReplacementLicense.LicenseID;

            lblReplacementLicenseID.Text = ReplacementLicense.LicenseID.ToString();
            btnIssueReplacement.Enabled = false ;

            linkLblShowReplacedLicense.Enabled = true;



        }

        private int _HandleApplicationType()
        {
            if (rbRepDamagedLicense.Checked)
                return (int)clsApplication.enApplicationTypes.ReplacementForDamagedDrivingLicense;

            return (int)clsApplication.enApplicationTypes.ReplacementForLostDrivingLicense;

        }

        private clsLicense .enIssueReason _HandleIssueReason()
        {
            if (rbRepDamagedLicense.Checked)
                return clsLicense.enIssueReason.ReplacementForDamaged;

            return clsLicense.enIssueReason.ReplacementForLost;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReplacementForLostOrDamagedAplication_Load(object sender, EventArgs e)
        {
            rbRepDamagedLicense.Checked = true;

            linkLblShowReplacedLicense.Enabled = false;
            linkLblShowPersonLicensesHistory.Enabled = false;

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedby.Text = clsGlobal.CurrentUserInfo.UserName;
        


        }

        private void rbRepDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement for Damaged License";

            lblApplicationFees.Text = ApplicationType.GetApplicationType
                ((int)clsApplication.enApplicationTypes.ReplacementForDamagedDrivingLicense).ApplicationFees.ToString();

        }

        private void rbRepLostLicene_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement for Lost License";

            lblApplicationFees.Text = ApplicationType.GetApplicationType
                ((int)clsApplication.enApplicationTypes.ReplacementForLostDrivingLicense).ApplicationFees.ToString();


        }

        private void ucDrivingLicenseInfoWithFilterCard1_OnLicenseSelected(int obj)
        {

            _OldLicenseInfo = clsLicense.GetLicenseInfoBylicenseID(obj);

            _OldLicenseID = obj;

            lblOldLicenseID.Text = obj.ToString();


            linkLblShowPersonLicensesHistory.Enabled = true;

            btnIssueReplacement.Enabled = true;

            if(!_OldLicenseInfo .IsLicenseActive())
            {
                MessageBox.Show("Selected License is not Active, choose an active License",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnIssueReplacement.Enabled = false;

               

            }
            


        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("Are you sure you want to replace This License ?",
                    "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult .OK)
            {
                _HandleIssueReplacementLicense();

            }


        }

        private void linkLblShowPersonLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicensesHistory PersonLicenses = new frmPersonLicensesHistory(_OldLicenseInfo.DriverInfo.PersonID);

            PersonLicenses.ShowDialog();


        }

        private void linkLblShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense LicenseInfo = new frmShowLicense(_NewLicenseID);

            LicenseInfo.ShowDialog();

        }
    }
}
