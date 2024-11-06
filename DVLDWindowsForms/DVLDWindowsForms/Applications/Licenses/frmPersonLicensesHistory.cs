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

namespace DVLDWindowsForms.Applications.Licenses
{
    public partial class frmPersonLicensesHistory : Form
    {

       
        private int _PersonID = -1;

        public frmPersonLicensesHistory(int PersonID)
        {

            _PersonID = PersonID;

            InitializeComponent();
        }



        private void _LoadPersonLicenses()
        {

            _LoadPersonLocalLicenses();

            _LoadPersonInternationalLicenses();


        }
        private void _LoadPersonLocalLicenses()
        {
            DataTable dtListPersonLocalLicenses = clsLicense.LoadPersonLicenses(_PersonID);



            dgvListILocalLicenses.DataSource = dtListPersonLocalLicenses;

            if(dgvListILocalLicenses .RowCount > 0)
            {
                dgvListILocalLicenses.Columns[0].HeaderText = "License ID";
                dgvListILocalLicenses.Columns[0].Width = 100;

                dgvListILocalLicenses.Columns[1].HeaderText = "App.ID";
                dgvListILocalLicenses.Columns[1].Width = 90;

                dgvListILocalLicenses.Columns[2].HeaderText = "License Class Name";
                dgvListILocalLicenses.Columns[2].Width = 250;

                dgvListILocalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvListILocalLicenses.Columns[3].Width = 150;

                dgvListILocalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvListILocalLicenses.Columns[4].Width = 150;

                dgvListILocalLicenses.Columns[5].HeaderText = "IsActive";
                dgvListILocalLicenses.Columns[5].Width = 80;


            }
        }

        private void _LoadPersonInternationalLicenses()
        {
            DataTable dtListPersonInternationalLicenses = InternatinalLicense.LoadPersonInternationalLicenses(_PersonID);



            dgvListInternationalLicenses.DataSource = dtListPersonInternationalLicenses;

            if (dgvListInternationalLicenses.RowCount > 0)
            {
                dgvListInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
                dgvListInternationalLicenses.Columns[0].Width = 100;

                dgvListInternationalLicenses.Columns[1].HeaderText = "App.ID";
                dgvListInternationalLicenses.Columns[1].Width = 90;

                dgvListInternationalLicenses.Columns[2].HeaderText = "Local License ID";
                dgvListInternationalLicenses.Columns[2].Width = 150;

                dgvListInternationalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvListInternationalLicenses.Columns[3].Width = 150;

                dgvListInternationalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvListInternationalLicenses.Columns[4].Width = 150;

                dgvListInternationalLicenses.Columns[5].HeaderText = "IsActive";
                dgvListInternationalLicenses.Columns[5].Width = 80;


            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPersonLicensesHistory_Load(object sender, EventArgs e)
        {
            ucFindPerson1.LoadPersonInfo(_PersonID);
            ucFindPerson1.FilterEnabled = false;


            _LoadPersonLicenses();

        }
    
    }
}
