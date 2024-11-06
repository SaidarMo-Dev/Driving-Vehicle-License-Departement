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
    public partial class frmUpdateTestType : Form
    {

      
        private clsTestType _TestType; 
        public frmUpdateTestType(int TestTypeID)
        {
            InitializeComponent();

            this._TestType = clsTestType.GetTestType(TestTypeID);
          
        }

        private void _LoadTestTypeData()
        {
            if (_TestType != null)
            {
                lblTestTypeID.Text = _TestType.TestTypeID.ToString();
                tbTitle.Text = _TestType.Title;
                tbDescription.Text = _TestType.Description;
                tbFees.Text = _TestType.Fees.ToString();

            }
            else
            {

                MessageBox.Show("There is no Test type Data, this Form Will Be closed !", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
        private void _CollecteNewTestTypeData()
        {
            _TestType.Description = tbDescription.Text.ToString();
            _TestType.Fees = Convert.ToDouble(tbFees.Text);
        }
        private bool _SaveData()
        {
            _CollecteNewTestTypeData();

            return _TestType.UpdateTestType();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            _LoadTestTypeData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           // if (MessageBox.Show("Are you sure you want to save New Data"))
            if (_SaveData())
            {
                MessageBox.Show("Data Saved Succssufuly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error : Failed to save Data ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }
    }
}
