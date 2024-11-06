using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDWindowsForms.Tests;
using DVLDBusinessLayer;
using DVLDWindowsForms.Applications.IssueLicense;
using DVLDWindowsForms.Applications.Licenses;

namespace DVLDWindowsForms.Applications
{
    public partial class frmManageLocaleDrinvingLicenseAppplication : Form
    {
       

        public frmManageLocaleDrinvingLicenseAppplication()
        {
            InitializeComponent();
         
        }

        private void _RefreshListLocalDrivingLicenseApplication()
        {

            dgvListLocalDrivingLicenseApplications.DataSource = LocalDrivingLicenseApplication.GetListLocalDrivingLicenseApplications();
            lblTotalRecords.Text = dgvListLocalDrivingLicenseApplications.RowCount.ToString();

            if (dgvListLocalDrivingLicenseApplications.RowCount > 0)
            {

                dgvListLocalDrivingLicenseApplications.Columns[0].HeaderText = "L.D.L.AppID";
                dgvListLocalDrivingLicenseApplications.Columns[0].Width = 100;

                dgvListLocalDrivingLicenseApplications.Columns[1].HeaderText = "Driving Class";
                dgvListLocalDrivingLicenseApplications.Columns[1].Width = 200;

                dgvListLocalDrivingLicenseApplications.Columns[2].HeaderText = "National No.";
                dgvListLocalDrivingLicenseApplications.Columns[2].Width = 90;

                dgvListLocalDrivingLicenseApplications.Columns[3].HeaderText = "Full Name";
                dgvListLocalDrivingLicenseApplications.Columns[3].Width = 250;

                dgvListLocalDrivingLicenseApplications.Columns[4].HeaderText = "Application Date";
                dgvListLocalDrivingLicenseApplications.Columns[4].Width = 100;

                dgvListLocalDrivingLicenseApplications.Columns[5].HeaderText = "Passed Tests";
                dgvListLocalDrivingLicenseApplications.Columns[5].Width = 90;


            }

            cbFilter.SelectedIndex = 0;

        }

        private void _PeroformFilter()
        {
            DataView dvListlocalDrivingLicenseApplications = LocalDrivingLicenseApplication.GetListLocalDrivingLicenseApplications().DefaultView;


            switch (cbFilter.Text.ToString())
            {
                case "National.No":
                    dvListlocalDrivingLicenseApplications.RowFilter = "NationalNo = '" + tbValue.Text.ToString() + "'";
                    dgvListLocalDrivingLicenseApplications.DataSource = dvListlocalDrivingLicenseApplications;
                    lblTotalRecords.Text = dgvListLocalDrivingLicenseApplications.RowCount.ToString();

                    break;

                case "L.D.L.AppID":
                    dvListlocalDrivingLicenseApplications.RowFilter = "LocalDrivingLicenseApplicationID = '" + tbValue.Text.ToString() + "'";
                    dgvListLocalDrivingLicenseApplications.DataSource = dvListlocalDrivingLicenseApplications;
                    lblTotalRecords.Text = dgvListLocalDrivingLicenseApplications.RowCount.ToString();


                    break;

                case "Status" :
                    dvListlocalDrivingLicenseApplications.RowFilter = "Status = '" + tbValue.Text.ToString() + "'";
                    dgvListLocalDrivingLicenseApplications.DataSource = dvListlocalDrivingLicenseApplications;
                    lblTotalRecords.Text = dgvListLocalDrivingLicenseApplications.RowCount.ToString();

                    break;
                case "none" :

                    dgvListLocalDrivingLicenseApplications.DataSource = dvListlocalDrivingLicenseApplications;
                    lblTotalRecords.Text = dgvListLocalDrivingLicenseApplications.RowCount.ToString();

                    break;
            }
        }
      
      
        private void frmManageLocaleDrinvingLicenseAppplication_Load(object sender, EventArgs e)
        {
            _RefreshListLocalDrivingLicenseApplication();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAddNewLocalDrivingLicenseApplication_Click(object sender, EventArgs e)
        {
            var frmlocalDrivingLicensApplication = new frmAddEditLocalDrivingLicenseApplication();

            frmlocalDrivingLicensApplication.ShowDialog();

            _RefreshListLocalDrivingLicenseApplication();


        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLocalApplication = new frmAddEditLocalDrivingLicenseApplication(Convert.ToInt16(dgvListLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value));

            frmLocalApplication.ShowDialog();

            _RefreshListLocalDrivingLicenseApplication();
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ApplicationDetails = new frmLocalDrivingLicenseApplicationInfo(Convert.ToInt16(dgvListLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value));

            ApplicationDetails.ShowDialog();



        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

          

            if (MessageBox.Show("Are yo sure you want to delete this application ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {


                LocalDrivingLicenseApplication LocalApp = LocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(Convert.ToInt16(dgvListLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value));


                if (LocalApp.Delete())
                {
                    MessageBox.Show("this application Has been deleted!", "Deleted ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Error! Cannot delete this Application ", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            _RefreshListLocalDrivingLicenseApplication();
        
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            if (MessageBox.Show("Are yo sure you want to Cancel this application ?", "Cancel Application",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                LocalDrivingLicenseApplication LocalApp = LocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(Convert.ToInt16(dgvListLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value));

                if (LocalApp.Cancel())
                {
                    MessageBox.Show("this application Has been Canceled!", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Error! Cannot Cancel this Application ", "Cancel Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


            _RefreshListLocalDrivingLicenseApplication();

        }

        private void schduleStretTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CurrentRowLocalDrivingLicenseApplication = Convert.ToInt16(dgvListLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
          
            var VisionTest = new frmTestAppointements(clsTestType.enTestType.StreetTest , CurrentRowLocalDrivingLicenseApplication);


            VisionTest.ShowDialog();


            if (LocalDrivingLicenseApplication.DoesPassedTheTest (CurrentRowLocalDrivingLicenseApplication,(int)clsTestType .enTestType.StreetTest))
            {
                 if (!clsApplication.UpdateApplicationStatus(LocalDrivingLicenseApplication .GetLocalDrivingLicenseApplication(CurrentRowLocalDrivingLicenseApplication).ApplicationID, clsApplication.enApplicationStatus .Completed))
                 {
                     MessageBox.Show("We could not update the application status ", 
                            "Faild Update Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                 }
            }


            _RefreshListLocalDrivingLicenseApplication();

        }

        private void schduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var VisionTest = new frmTestAppointements(clsTestType.enTestType.VisionTest, Convert.ToInt16(dgvListLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value));
            
            
            VisionTest.ShowDialog();


            _RefreshListLocalDrivingLicenseApplication();

        }

        private void schduleWritenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var VisionTest = new frmTestAppointements(clsTestType.enTestType.WriteenTest, Convert.ToInt16(dgvListLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value));


            VisionTest.ShowDialog();

            _RefreshListLocalDrivingLicenseApplication();

        }

        private void dgvListLocalDrivingLicenseApplications_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
         
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueLicense issueLicenseForTheFisrtTime = new frmIssueLicense((int)dgvListLocalDrivingLicenseApplications .CurrentRow.Cells [0].Value);

            issueLicenseForTheFisrtTime.ShowDialog();

            _RefreshListLocalDrivingLicenseApplication();

        }

        private void cmsApplicatoins_Opening(object sender, CancelEventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)(dgvListLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);

            LocalDrivingLicenseApplication CurrentLocalDrivingLicenseApplication = LocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);


            int PassedTests = (int)dgvListLocalDrivingLicenseApplications.CurrentRow.Cells[5].Value;

            bool IsLicenseExiste = CurrentLocalDrivingLicenseApplication.IsLicenseIssued();

          
            // enabled only if the person pass all the tests and does not have a license 
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = (PassedTests == 3) && !IsLicenseExiste;

            showLicenseToolStripMenuItem.Enabled = IsLicenseExiste;

            // enable Delete Operation only if the status is Canceled or new 
            deleteApplicationToolStripMenuItem.Enabled = CurrentLocalDrivingLicenseApplication.ApplicationInfo.ApplicationStatus != clsApplication.enApplicationStatus.Completed;

            
            // enable edit / cancel operation only if the status is new 
            editApplicationToolStripMenuItem.Enabled = (CurrentLocalDrivingLicenseApplication.ApplicationInfo.ApplicationStatus == clsApplication.enApplicationStatus.New);
            cancelApplicationToolStripMenuItem.Enabled =( CurrentLocalDrivingLicenseApplication.ApplicationInfo.ApplicationStatus == clsApplication.enApplicationStatus.New );

            // if the status is new we activate the schdule test menu 
            sechduleTestToolStripMenuItem.Enabled = CurrentLocalDrivingLicenseApplication.ApplicationInfo.ApplicationStatus == clsApplication.enApplicationStatus.New;


            bool PassedVisionTest = LocalDrivingLicenseApplication.DoesPassedTheTest(LocalDrivingLicenseApplicationID, (int)clsTestType.enTestType.VisionTest);
            bool PassedWriteenTest = LocalDrivingLicenseApplication.DoesPassedTheTest(LocalDrivingLicenseApplicationID, (int)clsTestType.enTestType.WriteenTest);
            bool PassedStreetTest = LocalDrivingLicenseApplication.DoesPassedTheTest(LocalDrivingLicenseApplicationID, (int)clsTestType.enTestType.StreetTest);

            schduleVisionTestToolStripMenuItem.Enabled = !PassedVisionTest;
            schduleWritenTestToolStripMenuItem.Enabled = !PassedWriteenTest;
            schduleStretTestToolStripMenuItem.Enabled = !PassedStreetTest;

            // handle schdule tests 

            if(PassedVisionTest)
            {
              
                schduleVisionTestToolStripMenuItem.Enabled = !PassedVisionTest;

                if (PassedWriteenTest)
                {
                    schduleWritenTestToolStripMenuItem.Enabled = !PassedWriteenTest;

                    schduleStretTestToolStripMenuItem.Enabled = !PassedStreetTest;

                }
                else
                {
                    schduleWritenTestToolStripMenuItem.Enabled = !PassedWriteenTest;
                    schduleStretTestToolStripMenuItem.Enabled = PassedStreetTest;

                }
                
            }
            else
            {
                schduleVisionTestToolStripMenuItem.Enabled = !PassedVisionTest;
                schduleWritenTestToolStripMenuItem.Enabled = PassedWriteenTest;
                schduleStretTestToolStripMenuItem.Enabled = PassedStreetTest;
            }



        }

        private void tbValue_TextChanged(object sender, EventArgs e)
        {
            _PeroformFilter();

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbValue.Text = "";

            if (cbFilter.SelectedItem.ToString() != "none")
            {
                tbValue.Visible = true;
            }
            else
            {
                _RefreshListLocalDrivingLicenseApplication();
                tbValue.Visible = false;


            }
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LocalDrivingLicenseApplicationID = (int)dgvListLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            int LicenseID = LocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID).GetActiveLicenseID();


            if (LicenseID != -1)
            {
                frmShowLicense ShowLicense = new frmShowLicense(LicenseID);

                ShowLicense.ShowDialog();

        
            }
            else
            {
                MessageBox.Show("No License ID Found! ", "No LicenseID",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        
        }

        private void showPersonLicneseHestoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LocalDrinvngLicenseApp = (int)dgvListLocalDrivingLicenseApplications .CurrentRow.Cells[0].Value;


            frmPersonLicensesHistory PersonLicenseHistory = new frmPersonLicensesHistory(LocalDrivingLicenseApplication .GetLocalDrivingLicenseApplication (LocalDrinvngLicenseApp).ApplicationInfo .ApplicationPersonID);

            PersonLicenseHistory.ShowDialog();

        }
    }

}
