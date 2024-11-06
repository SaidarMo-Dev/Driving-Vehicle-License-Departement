using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWindowsForms.Applications.Licenses
{
    public partial class frmShowLicense : Form
    {

        private int _LicenseID = -1;


        public frmShowLicense(int LicenseID)
        {
            _LicenseID = LicenseID;
            InitializeComponent();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowLicens_Load(object sender, EventArgs e)
        {
            ucDiverLicenseInfo1.LoadLicenseInfo(_LicenseID);
        }
    }
}
