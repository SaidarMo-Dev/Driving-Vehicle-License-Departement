using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWindowsForms.Applications
{
    public partial class frmLocalDrivingLicenseApplicationInfo : Form
    {

        private int _LocalDrivingLicenseApplicationID = -1;


        public frmLocalDrivingLicenseApplicationInfo(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            this._LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }

        private void ucDrivvingLicenseApplicationInfo1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmLocalDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
            ucDrivingLicenseApplicationInfo1.LoadDrivingLicenseInfo(_LocalDrivingLicenseApplicationID);
        }
    }
}
