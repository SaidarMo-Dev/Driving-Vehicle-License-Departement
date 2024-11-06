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
    public partial class frmManageInternationalLicense : Form
    {

      
        public frmManageInternationalLicense()
        {
            InitializeComponent();
        }


        private void _LoadInternationalLicenses()
        {
            DataTable dtListInternationalLicenses = InternatinalLicense.GetListInternationalLicenses();

            dgvListInternationalLicenses.DataSource = dtListInternationalLicenses;

            if(dgvListInternationalLicenses .RowCount > 0)
            {
                dgvListInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
                dgvListInternationalLicenses.Columns[0].Width = 100;

                dgvListInternationalLicenses.Columns[1].HeaderText = "Application ID";
                dgvListInternationalLicenses.Columns[1].Width = 100;

                dgvListInternationalLicenses.Columns[2].HeaderText = "Driver ID";
                dgvListInternationalLicenses.Columns[2].Width = 100;

                
                dgvListInternationalLicenses.Columns[3].HeaderText = "License ID";
                dgvListInternationalLicenses.Columns[3].Width = 100;

                dgvListInternationalLicenses.Columns[4].HeaderText = "Issue Date";
                dgvListInternationalLicenses.Columns[4].Width = 150;

                dgvListInternationalLicenses.Columns[5].HeaderText = "expiration Date";
                dgvListInternationalLicenses.Columns[5].Width = 150;

                dgvListInternationalLicenses.Columns[6].HeaderText = "Is Active";
                dgvListInternationalLicenses.Columns[6].Width = 100;


            }

            lblTotalRecords.Text = dgvListInternationalLicenses.RowCount.ToString();


        }

        private void _PeroformFilter()
        {
            DataView dvListInternationalLicenses = InternatinalLicense.GetListInternationalLicenses().DefaultView;



            switch (cbFilter.Text.ToString())
            {

                case "Int.LicenseID":
                    dvListInternationalLicenses.RowFilter = "InternationalLicenseID = '" + tbValue.Text.ToString() + "'";
                    dgvListInternationalLicenses.DataSource = dvListInternationalLicenses;
                    lblTotalRecords.Text = dgvListInternationalLicenses.RowCount.ToString();

                    break;

                case "DriverID":
                    dvListInternationalLicenses.RowFilter = "DriverID = '" + tbValue.Text.ToString() + "'";
                    dgvListInternationalLicenses.DataSource = dvListInternationalLicenses;
                    lblTotalRecords.Text = dgvListInternationalLicenses.RowCount.ToString();

                    break;

                case "ApplicationID":
                    dvListInternationalLicenses.RowFilter = "ApplicationID = '" + tbValue.Text.ToString() + "'";
                    dgvListInternationalLicenses.DataSource = dvListInternationalLicenses;
                    lblTotalRecords.Text = dgvListInternationalLicenses.RowCount.ToString();
                   
                    break;

                case "LicenseID":
                    dvListInternationalLicenses.RowFilter = "IssuedUsingLocalLicenseID = '" + tbValue.Text.ToString() + "'";
                    dgvListInternationalLicenses.DataSource = dvListInternationalLicenses;
                    lblTotalRecords.Text = dgvListInternationalLicenses.RowCount.ToString();
                    break;

            }
        }
      
      

        private void frmManageInternationalLicense_Load(object sender, EventArgs e)
        {
            tbValue.Visible = false;

            _LoadInternationalLicenses();



        }

        private void btnAddNewInternationalLicenseApplication_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication NewIntLicense = new frmNewInternationalLicenseApplication();

            NewIntLicense.ShowDialog();

            _LoadInternationalLicenses();

        }

        private void tbValue_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbValue .Text .ToString()) )
            {
                _PeroformFilter();
            }
            

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilter .SelectedItem.ToString() == "none")
            {
                tbValue.Visible = false;
                _LoadInternationalLicenses();

            }
            else
            {
                tbValue.Text = "";

                tbValue.Visible = true;

                _LoadInternationalLicenses();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonDetails PersonDetails = new frmShowPersonDetails(Driver.GetDriverInfo((int)dgvListInternationalLicenses.CurrentRow.Cells[2].Value).PersonID);

            PersonDetails.ShowDialog();


        
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowInternationalLicenseInformations IntLicenseInfo = new frmShowInternationalLicenseInformations((int)dgvListInternationalLicenses.CurrentRow.Cells[0].Value);

            IntLicenseInfo.ShowDialog();

        }

        private void showPersonLicneseHestoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonLicensesHistory PersonLicensesHistory = new frmPersonLicensesHistory(Driver.GetDriverInfo((int)dgvListInternationalLicenses.CurrentRow.Cells[2].Value).PersonID);

            PersonLicensesHistory.ShowDialog();

        
        }
    
    
    }
}
