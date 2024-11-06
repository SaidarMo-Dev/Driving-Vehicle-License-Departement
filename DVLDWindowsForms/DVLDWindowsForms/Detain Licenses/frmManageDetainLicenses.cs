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
using DVLDWindowsForms.Applications.Release_Detain_License;
using DVLDWindowsForms.Applications.Licenses;


namespace DVLDWindowsForms.Detain_Licenses
{
    public partial class frmManageDetainLicenses : Form
    {
        public frmManageDetainLicenses()
        {
            InitializeComponent();
        }



        private void _PeroformFilter()
        {
            DataView dvListDetainedLicenses = DetainedLicense .GetListDetainedLicenses().DefaultView;



            switch (cbFilter.Text.ToString())
            {

                case "Detain ID":
                    dvListDetainedLicenses.RowFilter = "DetainID = '" + tbValue.Text.ToString() + "'";
                    dgvListDetainedLicenses.DataSource = dvListDetainedLicenses;
                    lblTotalRecords.Text = dgvListDetainedLicenses.RowCount.ToString();

                    break;

             
                case "National.No":
                    
                    dvListDetainedLicenses.RowFilter = "NationalNo = '" + tbValue.Text.ToString() + "'";
                    dgvListDetainedLicenses.DataSource = dvListDetainedLicenses;
                    lblTotalRecords.Text = dgvListDetainedLicenses.RowCount.ToString();

                    break;

                case "Full Name":

                    dvListDetainedLicenses.RowFilter = "FullName= '" + tbValue.Text.ToString() + "'";
                    dgvListDetainedLicenses.DataSource = dvListDetainedLicenses;
                    lblTotalRecords.Text = dgvListDetainedLicenses.RowCount.ToString();

                    break;

                case "Release Application ID":

                    dvListDetainedLicenses.RowFilter = "ReleaseApplicationID = '" + tbValue.Text.ToString() + "'";
                    dgvListDetainedLicenses.DataSource = dvListDetainedLicenses;
                    lblTotalRecords.Text = dgvListDetainedLicenses.RowCount.ToString();

                    break;


            }
        }
      


    
        private void _LoadListDetainedLicenses()
        {
            DataTable dtListDetainedLisenses = DetainedLicense.GetListDetainedLicenses();

            dgvListDetainedLicenses.DataSource = dtListDetainedLisenses;

            if (dgvListDetainedLicenses .RowCount > 0 )
            {
                dgvListDetainedLicenses.Columns[0].HeaderText = "Detain ID";
                dgvListDetainedLicenses.Columns[0].Width = 100;

                dgvListDetainedLicenses.Columns[1].HeaderText = "License ID";
                dgvListDetainedLicenses.Columns[1].Width = 100;

                dgvListDetainedLicenses.Columns[2].HeaderText = "Detain Date";
                dgvListDetainedLicenses.Columns[2].Width = 150;

                dgvListDetainedLicenses.Columns[3].HeaderText = "Fine Fees";
                dgvListDetainedLicenses.Columns[3].Width = 100;

                dgvListDetainedLicenses.Columns[4].HeaderText = "Is.Released";
                dgvListDetainedLicenses.Columns[4].Width = 80;

                dgvListDetainedLicenses.Columns[5].HeaderText = "Relese Date";
                dgvListDetainedLicenses.Columns[5].Width = 120;

                dgvListDetainedLicenses.Columns[6].HeaderText = "N.NO";
                dgvListDetainedLicenses.Columns[6].Width = 50;

                dgvListDetainedLicenses.Columns[7].HeaderText = "Full Name";
                dgvListDetainedLicenses.Columns[7].Width = 150;

                dgvListDetainedLicenses.Columns[8].HeaderText = "R.App.ID";
                dgvListDetainedLicenses.Columns[8].Width = 70;






            }


            lblTotalRecords.Text = dgvListDetainedLicenses.RowCount.ToString();

        }

        private void frmManageDetainLicenses_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            cbIsReleased.SelectedIndex = 0;


            cbIsReleased.Visible = false;
            tbValue.Visible = false;

            _LoadListDetainedLicenses();

        }

        private void btnAddNewInternationalLicenseApplication_Click(object sender, EventArgs e)
        {
            frmDetainLicense DetainLicense = new frmDetainLicense();

            DetainLicense.ShowDialog();

            _LoadListDetainedLicenses();


        }

        private void btnReleseLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense ReleaseLicense = new frmReleaseDetainedLicense();

            ReleaseLicense.ShowDialog();

            _LoadListDetainedLicenses();


        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense ReleaseLicense = new frmReleaseDetainedLicense(Convert.ToInt16(dgvListDetainedLicenses.CurrentRow.Cells[0].Value));

            ReleaseLicense.ShowDialog();

            _LoadListDetainedLicenses();

        
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicense DetainedLicenseInfo = new frmShowLicense((int)dgvListDetainedLicenses .CurrentRow .Cells [1].Value);

            DetainedLicenseInfo.ShowDialog();



        }

        private void showPersonLicneseHestoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonLicensesHistory PersonLicenesesHistory = new frmPersonLicensesHistory
                                            (clsLicense.GetLicenseInfoBylicenseID
                                      ((int)dgvListDetainedLicenses.CurrentRow.Cells[1].Value).DriverInfo.PersonID);




            PersonLicenesesHistory.ShowDialog();

        }

        private void cmsApplicatoins_Opening(object sender, CancelEventArgs e)
        {
            bool IsLicenseDetained = DetainedLicense.IsLicenseDetained((int)dgvListDetainedLicenses.CurrentRow.Cells[1].Value);

            releaseDetainedLicenseToolStripMenuItem.Enabled = IsLicenseDetained;


            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void tbValue_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbValue.Text.ToString()))
                return;


            _PeroformFilter();

        }

        private void tbValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedItem.ToString() == "Detain ID" || cbFilter.SelectedItem.ToString() == "Release Application ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
          
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            _LoadListDetainedLicenses();

            tbValue.Text = "";

            switch (cbFilter .SelectedItem.ToString())
            {
                case "none" :
                    cbIsReleased.Visible = false;
                    tbValue.Visible = false;
                    break;

                case "Is Released" :
                    tbValue.Visible = false;
                    cbIsReleased.Visible = true;
                    break;

                default :
                    tbValue.Visible = true;
                    cbIsReleased.Visible = false;
                    break;
            }
        }

        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                DataView dvListDetainedLicenses = DetainedLicense.GetListDetainedLicenses().DefaultView;

                if(cbIsReleased .SelectedIndex ==0 )
                {
                    dvListDetainedLicenses.RowFilter = "IsReleased = true";
                    dgvListDetainedLicenses.DataSource = dvListDetainedLicenses;
                    lblTotalRecords.Text = dgvListDetainedLicenses.RowCount.ToString();

                    return;


                }

                dvListDetainedLicenses.RowFilter = "IsReleased = false";
                dgvListDetainedLicenses.DataSource = dvListDetainedLicenses;
                lblTotalRecords.Text = dgvListDetainedLicenses.RowCount.ToString();

            
        }
   
    
    }
}
