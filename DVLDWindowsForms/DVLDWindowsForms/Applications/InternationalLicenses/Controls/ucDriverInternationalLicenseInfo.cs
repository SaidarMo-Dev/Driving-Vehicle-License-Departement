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


namespace DVLDWindowsForms.Applications.InternationalLicenses.Controls
{
    public partial class ucDriverInternationalLicenseInfo : UserControl
    {
        private int _InternationalLicenseID = -1;
        public int SelectedIntenationalLicenseID
        {
            get { return _InternationalLicenseID; }
        }

        private InternatinalLicense _InternationalLicense;
        public InternatinalLicense SelectedInternationalLicenseInfo
        {
            get { return _InternationalLicense; }
        }



        public ucDriverInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        private void _HandleDriverImage()
        {
            if (_InternationalLicense.DriverInfo.PersonInfo.ImagePath == "" && _InternationalLicense.DriverInfo.PersonInfo.Gendor == 0)
            {
                pbDriverPicture.BackgroundImage = Properties.Resources.Male_512;
            }
            else if (_InternationalLicense.DriverInfo.PersonInfo.ImagePath == "" && _InternationalLicense.DriverInfo.PersonInfo.Gendor == 1)
                pbDriverPicture.BackgroundImage = Properties.Resources.Female_512;
            else
                pbDriverPicture.Load(_InternationalLicense.DriverInfo.PersonInfo.ImagePath);

                
        }
      
        private void _FillIntenationalLicense()
        {
            lblDriverName.Text = _InternationalLicense.DriverInfo.PersonInfo.FullName;
            lblInternationalLicenseID.Text = _InternationalLicense.InternationalLiceneID.ToString();
            lblLicnseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblNationalNo.Text = _InternationalLicense.DriverInfo.PersonInfo.NationalNo;
            lblGendor.Text = _InternationalLicense.DriverInfo.PersonInfo.GendorToString;
            lblIssueDate.Text = _InternationalLicense.IssueDate.ToShortDateString();
            lblIneternationalLicenseApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
            lblIsActive.Text = (_InternationalLicense.IsActive) ? "Yes" : "No";
            lblDriverDateOfBirth.Text = _InternationalLicense.DriverInfo.PersonInfo.DateOfBirth.ToShortDateString();
            lblDriverID.Text = _InternationalLicense.DriverID.ToString();
            lblExpirationDate.Text = _InternationalLicense.ExpirationDate.ToShortDateString();

            _HandleDriverImage();





        }
   
        public void LoadInternationalLicenseInformations(int internationalLicenseID)
        {
            _InternationalLicense = InternatinalLicense.GetInternationalLicenseInfo(internationalLicenseID);

            if (_InternationalLicense == null)
            {
                
                MessageBox.Show("Faild to get License Informations ","No Data", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _FillIntenationalLicense();

        }
    
    }
}
