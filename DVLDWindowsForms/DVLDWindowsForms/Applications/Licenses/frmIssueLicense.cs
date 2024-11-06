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


namespace DVLDWindowsForms.Applications.IssueLicense
{
    public partial class frmIssueLicense : Form
    {

        private int _LocalDrivingLicernseApplicationID;
        public frmIssueLicense(int LocalDrivingLicernseApplicationID)
        {

            _LocalDrivingLicernseApplicationID = LocalDrivingLicernseApplicationID;
            InitializeComponent();
        }
        
        private void _LoadLocalDrivingLicenseApplication()
        {
            ucDrivingLicenseApplicationInfo1.LoadDrivingLicenseInfo(_LocalDrivingLicernseApplicationID);
        }
      
        private void _HandleIssueLicense()
        {

            LocalDrivingLicenseApplication CurrentLocalDrivingLicenseApplicationInfo = LocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(_LocalDrivingLicernseApplicationID);


            // we make sure that the Local diriving license Application not null if it null we stope excuting 

            if (CurrentLocalDrivingLicenseApplicationInfo == null)
            {


                MessageBox.Show("Error : There is an Error when trying to access to the Local Driving License Application Info! This Form will be closed.",
                    "Access to Data Faild",MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;


            }



            int LicenseID = CurrentLocalDrivingLicenseApplicationInfo.IssueLicenseForTheFirstTime(tbNotes.Text.Trim(), clsGlobal.CurrentUserInfo.UserID);

            if (LicenseID == -1)
            {

                MessageBox.Show("An Error Ocured When trying to create the License ", "Error To Save",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

              
                return;

            }


            MessageBox.Show("License Has Been created successfully", "Saved successfully",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnIssue.Enabled = false;

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmIssueLicense_Load(object sender, EventArgs e)
        {
            _LoadLocalDrivingLicenseApplication();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            _HandleIssueLicense();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
