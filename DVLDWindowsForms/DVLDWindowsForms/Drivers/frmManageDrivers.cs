using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DVLDBusinessLayer;



namespace DVLDWindowsForms.Drivers
{
    public partial class frmManageDrivers : Form
    {
        public frmManageDrivers()
        {
            InitializeComponent();
        }


        private void _PerformFilter()
        {
            DataView dvListDrivers = Driver.GetListDrivers().DefaultView;

            switch (cbFilter .SelectedItem .ToString())
            {
                case "Driver ID":
                    dvListDrivers.RowFilter = "DriverID = '" + tbValue.Text.ToString() + "'";
                    dgvListDrivers.DataSource = dvListDrivers;
                    lblTotalRecords.Text = dgvListDrivers.RowCount.ToString();
                    break;

                case "National No" :
                     
                    dvListDrivers.RowFilter = "NationalNo = '" + tbValue.Text.ToString() + "'";
                    dgvListDrivers.DataSource = dvListDrivers;
                    lblTotalRecords.Text = dgvListDrivers.RowCount.ToString();
                   
                    break;


            }
               


        }
        private void _LoadListDrivers()
        {
            DataTable dtListDrivers = Driver.GetListDrivers();

            dgvListDrivers.DataSource = dtListDrivers;

            if (dgvListDrivers.RowCount > 0)
            {
                dgvListDrivers.Columns[0].HeaderText = "Driver ID";
                dgvListDrivers.Columns[0].Width = 100;

                dgvListDrivers.Columns[1].HeaderText = "Person ID";
                dgvListDrivers.Columns[1].Width = 100;

                dgvListDrivers.Columns[2].HeaderText = "National No";
                dgvListDrivers.Columns[2].Width = 100;

                dgvListDrivers.Columns[3].HeaderText = " Full Name";
                dgvListDrivers.Columns[3].Width = 300;

                dgvListDrivers.Columns[4].HeaderText = "Create Date";
                dgvListDrivers.Columns[4].Width = 200;


            }


            lblTotalRecords.Text = dgvListDrivers.RowCount.ToString();


        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            tbValue.Visible = false;

            _LoadListDrivers();
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonDetails PersonDetails = new frmShowPersonDetails((int)dgvListDrivers.CurrentRow.Cells[1].Value);

            PersonDetails.ShowDialog();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LoadListDrivers();

            tbValue.Text = "";

            if(cbFilter .SelectedIndex == 0)
            {
                tbValue.Visible = false;
                return;
            }

            tbValue.Visible = true;


        }

        private void tbValue_TextChanged(object sender, EventArgs e)
        {
            if (!string .IsNullOrEmpty (tbValue .Text .ToString()))
            {
                _PerformFilter();

            }
        }

        private void tbValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl (e.KeyChar ) && ! char.IsDigit (e.KeyChar) && cbFilter .SelectedItem.ToString() == "Driver ID")
            {
                e.Handled = true;
            }


        }
    }
}
