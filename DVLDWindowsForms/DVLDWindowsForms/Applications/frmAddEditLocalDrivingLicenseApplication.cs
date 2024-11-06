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

namespace DVLDWindowsForms.Applications
{
    public partial class frmAddEditLocalDrivingLicenseApplication : Form
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode;

        int LDLApplicationID = 0;

        private LocalDrivingLicenseApplication _LocalApplication;

        public LocalDrivingLicenseApplication localApplication
        {
            get
            {
                return _LocalApplication;
            }
           
        }


        public frmAddEditLocalDrivingLicenseApplication()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;

            _LocalApplication = new LocalDrivingLicenseApplication();

       
        }

        public frmAddEditLocalDrivingLicenseApplication(int LDLApplicationID )
        {
            InitializeComponent();
           
            this.LDLApplicationID = LDLApplicationID;
            
            _Mode = enMode.Update;

            _LocalApplication = LocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(LDLApplicationID);

        }




        private void _LoadLicenseClasses()
        {
             DataTable dtListLicenseClasses = LicenseClass.ListLicenseClasses();
            
            foreach (DataRow row in dtListLicenseClasses.Rows)
            {
                cbLicenseClasses.Items.Add(row["ClassName"]);

            }
            
            cbLicenseClasses.SelectedIndex = 0;

        }

        private void _LoadData()
        {
            _LoadLicenseClasses();

            if (_Mode == enMode.AddNew )
            {
                lblApplicationDate.Text = DateTime.Now.ToString();
                
                lblFees.Text = (ApplicationType.GetApplicationType(1)).ApplicationFees.ToString();
                lblCreatedByUser.Text = (clsGlobal.CurrentUserInfo != null) ? clsGlobal.CurrentUserInfo.UserName : "NULL";

                return;
            }
          
            // if you are here you are in Update mode

          //  LocalDrivingLicenseApplication LocalApplication = LocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(LDLApplicationID);


            ucFindPerson1.FilterEnabled = false;
           // ucPersonInfo.FilterEnabled = false;

            ucFindPerson1.LoadPersonInfo(_LocalApplication.ApplicationInfo.ApplicationPersonID);

            lblApplicationID.Text = _LocalApplication.ApplicationID.ToString();
            lblApplicationDate.Text = _LocalApplication.ApplicationInfo.ApplicationDate.ToString();
            cbLicenseClasses.SelectedIndex = _LocalApplication.LicenseClassID - 1;
            lblFees.Text = _LocalApplication.ApplicationInfo.ApplicationTypeInfo.ApplicationFees.ToString();
            lblCreatedByUser.Text = _LocalApplication.ApplicationInfo.CreaterUserInfo.UserName;

         
        }

        private clsApplication _CollectApplicationInfo()
        {
            clsApplication ApplicationInfo = new clsApplication();

            ApplicationInfo.ApplicationPersonID = ucFindPerson1.SelectedPersonInfo.PersonID; ;
            ApplicationInfo.ApplicationDate = DateTime.Now;
            ApplicationInfo.ApplicationTypeID = 1;
            ApplicationInfo.ApplicationStatus = clsApplication.enApplicationStatus.New;
            ApplicationInfo.LastStatusDate = DateTime.Now;
            ApplicationInfo.PaidFees = Convert.ToDouble(lblFees.Text);
            ApplicationInfo.CreatedByUserID = (clsGlobal.CurrentUserInfo != null) ? clsGlobal.CurrentUserInfo.UserID : 17;


            return ApplicationInfo;
        
        }

        private void _CollectLocalDrivingLicenseApplicationInfo()
        {

            _LocalApplication.LicenseClassID = cbLicenseClasses.SelectedIndex + 1;
            _LocalApplication.ApplicationInfo = _CollectApplicationInfo();


           

        }

        
        private void _SaveLocalDrivingLicenseApplicationInfo()
        {


            if (!this .ValidateChildren ())
            {
               
                    
                //Here we dont continue becuase the form is not valid
                
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            
            _CollectLocalDrivingLicenseApplicationInfo();

        
            if (!LocalDrivingLicenseApplication.IsPersonHasAnotherLocalApplicationWithSameLicenseClass(_LocalApplication.ApplicationInfo.ApplicationPersonID, _LocalApplication.LicenseClassID))
            {
                 if (_LocalApplication.Save())
                {
               
                    MessageBox.Show(" Application Saved successfuly!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
       
                // if we are here that means we couldn't save the informations.

                MessageBox.Show("Error! something wrong, verify Your informations! ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
            }
            else
            {
                MessageBox.Show("Error! This Person has another application with the same License class, try Another Class... ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
           
             tabControl1.SelectedIndex = 1;
        }

        private void cbLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmNewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            _LoadData();
        }


        private void lblCreatedByUser_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            LicenseClass LicenseClassInfo = LicenseClass .GetLicenseClassInfoByName (cbLicenseClasses.SelectedItem.ToString());

            if(ucFindPerson1 .SelectedPersonInfo.PersonAge < LicenseClassInfo .MinimumAllowedAge )
            {
                MessageBox.Show("This Person's Age  Does not allow him to apply for this type of License",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSave.Enabled = false;
                return;

            }

             if (LocalDrivingLicenseApplication .IsPersonHasAnotherLocalApplicationWithSameLicenseClass
                (ucFindPerson1 .SelectedPersonInfo.PersonID, LicenseClassInfo .LicenseClassID))
            {
                MessageBox.Show("This Person already have an application within this license class, choose another license",
                   "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSave.Enabled = false;

                return;
            }
            

            
            _SaveLocalDrivingLicenseApplicationInfo();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void ucGetPersonForApplication_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void ucFindPerson1_Load(object sender, EventArgs e)
        {

        }

        private void ucFindPerson1_OnPersonSelected(int obj)
        {
            btnNext.Enabled = true;
        }
    }
}
