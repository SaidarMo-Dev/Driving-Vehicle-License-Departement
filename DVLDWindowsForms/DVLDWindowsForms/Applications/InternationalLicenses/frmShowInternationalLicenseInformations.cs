using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWindowsForms.Applications.InternationalLicenses
{
    public partial class frmShowInternationalLicenseInformations : Form
    {

        private int _InternationalLicenseID = -1;

        public frmShowInternationalLicenseInformations(int InternationalLicenseID)
        {

            _InternationalLicenseID = InternationalLicenseID;

            InitializeComponent();
        }

        private void _LoadLicenseInfo()
        {
            ucDriverInternationalLicenseInfo1.LoadInternationalLicenseInformations(_InternationalLicenseID);

        }
        private void frmShowInternationalLicenseInformations_Load(object sender, EventArgs e)
        {
            _LoadLicenseInfo();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
