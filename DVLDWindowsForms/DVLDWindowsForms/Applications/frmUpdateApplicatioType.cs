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


namespace DVLDWindowsForms.Applications
{
    public partial class frmUpdateApplicatioType : Form
    {
        private ApplicationType _Application;
 
        public frmUpdateApplicatioType(int ApplicationTypeID)
        {

            InitializeComponent();

            _Application = ApplicationType.GetApplicationType(ApplicationTypeID);
        
        }

        private void _LoadAppLicationTypeData()
        {
            if (_Application != null)
            {
                lblID.Text = _Application.ID.ToString();
                tbAppTypeTitle.Text = _Application.ApplicationTypeTitle;
                tbAppTypeFees.Text = _Application.ApplicationFees.ToString();

            }
        }

        private void _CollecteAppTypeData()
        {
            _Application.ApplicationTypeTitle = tbAppTypeTitle.Text.ToString();
            _Application.ApplicationFees = Convert.ToDouble(tbAppTypeFees.Text);

        }
    
        private void _SaveNewData()
        {
            _CollecteAppTypeData();
           
            if(_Application.UpdateApplicationType())
            {
                MessageBox.Show("Saved ssuccssefuly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("failed to save Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {



        }

        private void frmUpdateApplicatioType_Load(object sender, EventArgs e)
        {
            _LoadAppLicationTypeData();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveNewData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
