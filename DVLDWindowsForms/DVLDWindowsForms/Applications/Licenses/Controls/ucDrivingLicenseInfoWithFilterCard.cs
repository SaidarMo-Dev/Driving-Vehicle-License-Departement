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
    public partial class ucDrivingLicenseInfoWithFilterCard : UserControl
    {



        private int _LicenseID = -1;


        private clsLicense _LicenseInfo;

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;


            }
        }
        public clsLicense SelectedLicenseInfo
        {
            get { return _LicenseInfo; }
        }

        public bool IsDataValide = false;

        public ucDrivingLicenseInfoWithFilterCard()
        {
            InitializeComponent();
        }


        public event Action<int> OnLicenseSelected;
        
        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;

            
            if (handler != null )
            {
                handler(LicenseID);
            }
        }

        public void LoadLicenseData(int LicenseID)
        {
            tbLicenseID.Text = LicenseID.ToString();

            _LicenseID = LicenseID;

            ucDiverLicenseInfo1.LoadLicenseInfo(_LicenseID);

            _LicenseInfo = ucDiverLicenseInfo1.SelectedLicenseInfo;

            if (OnLicenseSelected != null && _LicenseInfo != null)
            {
                LicenseSelected(_LicenseID);
            }

        }

        private void _LoadLicenseData()
        {
           
            _LicenseID = Convert.ToInt16(tbLicenseID.Text);

            ucDiverLicenseInfo1.LoadLicenseInfo(_LicenseID);

            _LicenseInfo = ucDiverLicenseInfo1.SelectedLicenseInfo;

            if(OnLicenseSelected != null && _LicenseInfo != null )
            {
                LicenseSelected(_LicenseID);
            }

            
        }


        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            btnFindLicense.Focus();

        }

        private void btnFindLicense_Click(object sender, EventArgs e)
        {
            _LoadLicenseData();

        }

        private void tbLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }
    
    }
}
