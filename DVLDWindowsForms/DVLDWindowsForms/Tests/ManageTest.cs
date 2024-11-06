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


namespace DVLDWindowsForms.Tests
{
    public partial class ManageTest : Form
    {
        public ManageTest()
        {
            InitializeComponent();
        }

        private void _LoadListTestTypes()
        {

            int rowIndex = 0;

            DataTable dtListTestTypes = clsTestType.GetAllTestTypes();

            foreach (DataRow row in dtListTestTypes.Rows)
            {
                rowIndex = dgvListTestTypes .Rows .Add();

                dgvListTestTypes.Rows[rowIndex].Cells["clmID"].Value = row["TestTypeID"];
                dgvListTestTypes.Rows[rowIndex].Cells["clmTitle"].Value = row["TestTypeTitle"];
                dgvListTestTypes.Rows[rowIndex].Cells["clmDescription"].Value = row["TestTypeDescription"];
                dgvListTestTypes.Rows[rowIndex].Cells["clmFees"].Value = row["TestTypeFees"];


            }

        }

        private void _RefreshListTestTypes()
        {
            dgvListTestTypes.Rows.Clear();
            _LoadListTestTypes();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ManageTest_Load(object sender, EventArgs e)
        {
            _LoadListTestTypes();

        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmUpdate = new frmUpdateTestType(Convert.ToInt16(dgvListTestTypes.CurrentRow.Cells[0].Value));

            frmUpdate.ShowDialog();

            _RefreshListTestTypes();


        }
    }
}
