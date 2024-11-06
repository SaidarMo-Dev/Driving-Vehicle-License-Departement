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

namespace DVLDWindowsForms.Detain_Licenses
{
    public partial class frmDetainLicense : Form
    {

        private int _LicenseID = -1;

        public frmDetainLicense()
        {
            InitializeComponent();
        }


        private void _HandleetainLicense()
        {

            DetainedLicense  DetainLicense = new DetainedLicense();

            DetainLicense.LicenseID = _LicenseID;
            DetainLicense.DetainDate = DateTime.Now;
            DetainLicense.FineFees = Convert.ToDouble(tbFineFees.Text.ToString());
            DetainLicense.CreatedByUserID = clsGlobal.CurrentUserInfo.UserID;

            if(!DetainLicense .Save ())
            {
                MessageBox.Show("Failed to Detain selected License",
                   "Can't Detain", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            lblDetainID.Text = DetainLicense.DetainID.ToString();

            MessageBox.Show("License Detained successfully ",
                   "License Detained", MessageBoxButtons.OK, MessageBoxIcon.Information);


            btnDetain.Enabled = false;

        }
      
        private bool _ValidateTextBoxFineFees()
        {
            epFillFineFees.SetError(tbFineFees, string.Empty);

            if(string .IsNullOrEmpty(tbFineFees .Text .ToString()))
            {
                epFillFineFees.SetError(tbFineFees, "This Field can not be empty!");
                return false;
            }


            return true;


        }
     
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucDrivingLicenseInfoWithFilterCard1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;

            lblSelectedLicenseID.Text = obj.ToString();

            linkLblShowLicense.Enabled = true;
            linkLblShowPersonLicensesHistory.Enabled = true;

            btnDetain.Enabled = true;

            if (DetainedLicense .IsLicenseDetained(obj))
            {
                MessageBox.Show("Selected License already Detained, Choose Another One", 
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnDetain.Enabled = false;
                return;

            }

            if (!clsLicense .IsLicenseActive (obj))
            {
                MessageBox.Show("Selected License Is Not Active, Choose Another One",
                   "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnDetain.Enabled = false;
                return;
            }




        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (this .ValidateChildren())
            {
                if (MessageBox.Show("Are You sure you want to detain this License!",
                "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    _HandleetainLicense();

                }
            }
            else
            {
                MessageBox.Show("Some fileds Are not valide put mouse ever the red icon to see the Problem",
                "No Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void tbFineFees_Validating(object sender, CancelEventArgs e)
        {
            if(!_ValidateTextBoxFineFees())
            {
                e.Cancel = true;
            }
        }

        private void ucDrivingLicenseInfoWithFilterCard1_Load(object sender, EventArgs e)
        {

        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            linkLblShowLicense.Enabled = false;
            linkLblShowPersonLicensesHistory.Enabled = false;

            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedby.Text = clsGlobal.CurrentUserInfo.UserID.ToString();



        }
    }
}
