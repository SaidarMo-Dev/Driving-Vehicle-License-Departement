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


namespace DVLDWindowsForms.Applications.InternationalLicenses
{
    public partial class frmNewInternationalLicenseApplication : Form
    {


        private int _LocalLicenseID = -1;

        private int _InternaionalLicenseID = -1;

        public frmNewInternationalLicenseApplication()
        {
            InitializeComponent();
        }



        private bool _HandleInternationalLicene()
        {
            // first we Create An application of type International license 

            clsApplication InternationalLicenseApplication = new clsApplication();

            InternationalLicenseApplication.ApplicationPersonID = ucDrivingLicenseInfoWithFilterCard1.SelectedLicenseInfo.DriverInfo.PersonID;
            InternationalLicenseApplication.ApplicationDate = DateTime.Now;
            InternationalLicenseApplication.ApplicationTypeID = (int)clsApplication.enApplicationTypes.NewInternationalLicense;
            InternationalLicenseApplication.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            InternationalLicenseApplication.LastStatusDate = DateTime.Now;
            InternationalLicenseApplication.PaidFees = ApplicationType.GetApplicationType((int)clsApplication.enApplicationTypes.NewInternationalLicense).ApplicationFees;
            InternationalLicenseApplication.CreatedByUserID = clsGlobal.CurrentUserInfo.UserID;

            if (!InternationalLicenseApplication.Save ())
            {
                MessageBox.Show("Faild to save International License Application!", 
                        "Save Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;


            }

            lblINternationalApplicationID.Text = InternationalLicenseApplication.ApplicationID.ToString();


            InternatinalLicense InternationalLicense = new InternatinalLicense();

            InternationalLicense.ApplicationID = InternationalLicenseApplication.ApplicationID;
            InternationalLicense.DriverID = ucDrivingLicenseInfoWithFilterCard1.SelectedLicenseInfo.DriverID;
            InternationalLicense.IssuedUsingLocalLicenseID = _LocalLicenseID;
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            InternationalLicense.IsActive = true;
            InternationalLicense.CreatedByUserID = clsGlobal.CurrentUserInfo.UserID;

            if(!InternationalLicense.Save())
            {
                MessageBox.Show("Faild to save International License !",
                        "Save Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;

            }


            MessageBox.Show("International License Saved Successfull.",
                      "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        
            _InternaionalLicenseID = InternationalLicense.InternationalLiceneID;

            lblInternatinalLicenseID.Text = InternationalLicense.InternationalLiceneID.ToString();

            linkLblShowInternationalLicene.Enabled = true;

            return true;


        }


        private void _FilInternationalLicenseApplicationInfo()
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = ApplicationType.GetApplicationType((int)clsApplication.enApplicationTypes.NewInternationalLicense).ApplicationFees.ToString();
            //lblLocalLicenseID.Text = _LocalLicenseID.ToString();
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            lblCreatedby.Text = clsGlobal.CurrentUserInfo.UserID.ToString();



        }

     

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            _FilInternationalLicenseApplicationInfo();

            linkLblShowPersonLicensesHistory.Enabled = false;
            linkLblShowInternationalLicene.Enabled = false;
        }

        private void ucDrivingLicenseInfoWithFilterCard1_OnLicenseSelected(int obj)
        {

            int LicenseID = obj;

            // first we ensure that the license is existe
            //active and with class 3


            bool IsLicenseActive =  clsLicense.IsLicenseActive(LicenseID);

            bool IsPersonHaveActiveInternatinalLicense = InternatinalLicense.IsDriverHaveActiveInternationalLicense(clsLicense.GetDriverID(LicenseID));

            bool IsLicenseInExecptedClass = clsLicense.GetLicenseInfoBylicenseID(LicenseID).LicenseClassID == 3;


            if (IsPersonHaveActiveInternatinalLicense)
            {

                MessageBox.Show("Person Already have an active International License ",
                    "Person Have License", MessageBoxButtons.OK, MessageBoxIcon.Error);


                btnIssue.Enabled = false;
                return;

            }
            else if (!IsLicenseActive)
            {
                MessageBox.Show("This License Desactivated You Can Not Create an International License",
                    "License Not Active", MessageBoxButtons.OK, MessageBoxIcon.Error);



                btnIssue.Enabled = false;
                return;


            }
            else if (!IsLicenseInExecptedClass)
            {
                MessageBox.Show("You Should Have a license of class 3 to Create an International License",
                    "License class Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                btnIssue.Enabled = false;

                return;

            }

           



            linkLblShowPersonLicensesHistory.Enabled = true;
            lblLocalLicenseID.Text = obj.ToString();

            _LocalLicenseID = obj;



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show("Are you sure you want to issue this License!",
                     "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (!ucDrivingLicenseInfoWithFilterCard1.IsDataValide)
                {
                    MessageBox.Show("There was a problem make sure that the license id is correct!",
                             "Error With The Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;


                }



                    if (!_HandleInternationalLicene())
                        return;

                    linkLblShowInternationalLicene.Enabled = true;

                    lblInternatinalLicenseID.Text = _InternaionalLicenseID.ToString();

            
            }
           
        }

        private void linkLblShowInternationalLicene_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicenseInformations frmShowLicenseInfo = new frmShowInternationalLicenseInformations(_InternaionalLicenseID);

            frmShowLicenseInfo.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLblShowPersonLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicensesHistory PersonLicenseHistory = new frmPersonLicensesHistory(ucDrivingLicenseInfoWithFilterCard1.SelectedLicenseInfo.DriverInfo.PersonID);

            PersonLicenseHistory.ShowDialog();


        
        
        }
    }
}
