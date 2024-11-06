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
    public partial class frmListApplicationTypes : Form
    {
        public frmListApplicationTypes()
        {
            InitializeComponent();
        }

        private void _LoadApplicationTypesData()
        {
            DataTable dtListApplicationTypes = ApplicationType.GetAllApplicationTypes();


            int rowIndex = 0;
            foreach (DataRow row in dtListApplicationTypes.Rows)
            {
                rowIndex = dgvListApplicationTypes.Rows.Add();

                dgvListApplicationTypes.Rows[rowIndex].Cells["clmID"].Value = row["ApplicationTypeID"];
                dgvListApplicationTypes.Rows[rowIndex].Cells["clmTitle"].Value = row["ApplicationTypeTitle"];
                dgvListApplicationTypes.Rows[rowIndex].Cells["clmFees"].Value = row["ApplicationFees"];
            }


            lblTotalRecords.Text = dgvListApplicationTypes.RowCount.ToString();


        }

        private void _RefrechListApplicationTypes()
        {
            dgvListApplicationTypes.Rows.Clear();

            _LoadApplicationTypesData();

        }

        private void dgvListApplicationTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void frmListApplicationTypes_Load(object sender, EventArgs e)
        {

            _LoadApplicationTypesData();
            
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void editFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmUpdateAppType = new frmUpdateApplicatioType(Convert .ToInt16(dgvListApplicationTypes .CurrentRow .Cells [0].Value));

            frmUpdateAppType.ShowDialog();


            _RefrechListApplicationTypes();

        
        }
    }
}
