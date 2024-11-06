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
using DVLDWindowsForms;

namespace DVLDWindowsForms.Controls
{
    public partial class ucApplicationBasicInfo : UserControl
    {
        private int _ApplicationID = -1;
        public  int ApplicationID
        {
            get
            {
                return _ApplicationID;

            }
        }

        private clsApplication _Application;

        public clsApplication SeectedApplicationInfo
        {
            get
            {
                return _Application;
            }
        }


        public ucApplicationBasicInfo()
        {
            InitializeComponent();
        }


        public void LoadApplicationBasicInfo(int ApplicationID)
        {
            _ApplicationID = ApplicationID;
            _Application = clsApplication.GetApplicationInfoByID(ApplicationID);
            

            if (_Application != null)
            {
                linklblPersonDetails.Visible =true;

                _FullApplicationInfo();

                return;
            }

            // if the application not found we enter her ..

            linklblPersonDetails.Visible = false;

            _ResetApplicationInfo();

            MessageBox.Show("There's no application with this ID = " + ApplicationID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        }


        private void _FullApplicationInfo()
        {
            lblApplicationID.Text = _Application.ApplicationID.ToString();
            lblStatus.Text = _Application.StatusWord;
            lblFees.Text = _Application.PaidFees.ToString();
            lblType.Text = _Application.ApplicationTypeInfo.ApplicationTypeTitle;
            lblApplicantPersonFullName.Text = _Application.PersonInfo.FullName;
            lblApplicationDate.Text = _Application.ApplicationDate.ToShortDateString();
            lblStatusDate.Text = _Application.LastStatusDate.ToShortDateString();
            lblCreateedBy.Text = _Application.CreaterUserInfo.UserName;



        }

        private void _ResetApplicationInfo()
        {
            lblApplicationID.Text = "[????]";
            lblStatus.Text = "[????]";
            lblFees.Text = "[????]";
            lblType.Text = "[????]";
            lblApplicantPersonFullName.Text = "[????]";
            lblApplicationDate.Text = "[????]";
            lblStatusDate.Text = "[????]";
            lblCreateedBy.Text = "[????]";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var PersonDetails = new frmShowPersonDetails(this._Application.ApplicationPersonID);

            PersonDetails.ShowDialog();


        }

        private void ucApplicationBasicInfo_Load(object sender, EventArgs e)
        {
            linklblPersonDetails.Visible = false;
        }
    }
}
