using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLDWindowsForms.Applications.Licenses.Controls
{
    public partial class ucDiverLicenseInfo : UserControl
    {
        private clsLicense _LicenseInfo;
        private int _LicenseID = -1;



        public clsLicense SelectedLicenseInfo
        {
            get { return _LicenseInfo; }
        }
        public int SelectedLicenseID
        {
            get{ return _LicenseID; }
        }

        public ucDiverLicenseInfo()
        {
            InitializeComponent();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void LoadLicenseInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            
            _LicenseInfo = clsLicense.GetLicenseInfoBylicenseID(LicenseID);

            if (_LicenseInfo == null)
            {
                MessageBox.Show("There is no License with ID = "+_LicenseID,"No License ", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                _ResetLicenseInfo();

                return;
            }

            _FillLicenseInfo();
        
        }

        private void _FillLicenseInfo()
        {
            lblLicenseClassName.Text = _LicenseInfo.LicenseClassInfo.LicenseClassName;
            lblDriverName.Text = _LicenseInfo.DriverInfo.PersonInfo.FullName;
            lblLicenseID.Text = _LicenseInfo.LicenseID.ToString();
            lblNationalNo.Text = _LicenseInfo.DriverInfo.PersonInfo.NationalNo.ToString();
            lblGendor.Text = _LicenseInfo.DriverInfo.PersonInfo.GendorToString;
            lblIssueDate.Text = _LicenseInfo.IssueDate.ToShortDateString();
            lblIssueReason.Text = _LicenseInfo.IssuereasonToString;
            lblNotes.Text = _LicenseInfo.Notes == "" ? "No Note" : _LicenseInfo.Notes;
            lblIsActive.Text = (_LicenseInfo.IsActive) ? "Yes" : "No";
            lblDriverDateOfBirth.Text = _LicenseInfo.DriverInfo.PersonInfo.DateOfBirth.ToShortDateString();
            lblDriverID.Text = _LicenseInfo.DriverID.ToString();
            lblExpirationDate.Text = _LicenseInfo.ExpirationDate.ToShortDateString();
            lblIsDetained.Text = DetainedLicense.IsLicenseDetained(_LicenseInfo.LicenseID) ? "Yes" : "No";


            if (_LicenseInfo.DriverInfo.PersonInfo.ImagePath == "" && _LicenseInfo.DriverInfo.PersonInfo.Gendor == 0)
            {
                pbDriverPicture.BackgroundImage = Properties.Resources.Male_512;
            }
            else if (_LicenseInfo.DriverInfo.PersonInfo.ImagePath == "" && _LicenseInfo.DriverInfo.PersonInfo.Gendor == 1)
                pbDriverPicture.BackgroundImage = Properties.Resources.Female_512;
            else
                pbDriverPicture.Load(_LicenseInfo.DriverInfo.PersonInfo.ImagePath);

                


        }

        private void _ResetLicenseInfo()
        {

            lblLicenseClassName.Text ="N/A";
            lblDriverName.Text = "N/A";
            lblLicenseID.Text = "N/A";
            lblNationalNo.Text = "N/A";
            lblGendor.Text = "N/A";
            lblIssueDate.Text = "N/A";
            lblIssueReason.Text = "N/A";
            lblNotes.Text = "N/A";
            lblIsActive.Text = "N/A";
            lblDriverDateOfBirth.Text = "N/A";
            lblDriverID.Text = "N/A";
            lblExpirationDate.Text = "N/A";
            lblIsDetained.Text = "N/A";
                                     
            pbDriverPicture.ImageLocation = "";

        }
        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void ucDiverLicenseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
