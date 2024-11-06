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
    public partial class frmTestAppointements : Form
    {

        private int _LocalApplicationID = -1;
        public int LocalApplicationID
        {
            get
            {
                return _LocalApplicationID;
            }
        }

        private clsTestType.enTestType _TestType;




        public frmTestAppointements(clsTestType.enTestType TestType, int LocalDrivingLicenseApplicationID)
        {

            this._TestType = TestType;
            this._LocalApplicationID = LocalDrivingLicenseApplicationID;


            InitializeComponent();



        }

        private void _PrepareFormData()
        {
            switch (_TestType)
            {
                case clsTestType.enTestType.VisionTest:
                    this.Text = "Vision Test Appointements";
                    lblTitle.Text = "Vision Test Appointements";
                    pictureBox1.BackgroundImage = Properties.Resources.Vision_512;

                    break;
                case clsTestType.enTestType.WriteenTest:
                    this.Text = "Writeeen Test Appointements";
                    lblTitle.Text = "Writeen Test Appointements";
                    pictureBox1.BackgroundImage = Properties.Resources.Written_Test_512;

                    break;
                case clsTestType.enTestType.StreetTest:
                    lblTitle.Text = "Street Test Appointements";
                    this.Text = "Street Test Appointements";
                    pictureBox1.BackgroundImage = Properties.Resources.driving_test_512;

                    break;

            }
        }

        private void _LoadData()
        {
            _PrepareFormData();
            ucDrivingLicenseApplicationInfo1.LoadDrivingLicenseInfo(_LocalApplicationID);
            _LoadListTestAppointements();



        }

        private void _LoadListTestAppointements()
        {
            DataTable dtListAppointments = TestAppointement.GetAllTestAppointements(_LocalApplicationID, (int)_TestType);

            dgvListTestAppointements.DataSource = dtListAppointments;


            if (dgvListTestAppointements.Rows.Count > 0)
            {
                dgvListTestAppointements.Columns[0].HeaderText = "Appointment ID";
                dgvListTestAppointements.Columns[0].Width = 150;

                dgvListTestAppointements.Columns[1].HeaderText = "Appointment Date";
                dgvListTestAppointements.Columns[1].Width = 200;

                dgvListTestAppointements.Columns[2].HeaderText = "Paid Fees";
                dgvListTestAppointements.Columns[2].Width = 150;

                dgvListTestAppointements.Columns[3].HeaderText = "Is Locked";
                dgvListTestAppointements.Columns[3].Width = 100;
            }
          



         

        }

        private void _RefreshListTestAppointment()
        {
            _LoadListTestAppointements();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAddAppointement_Click(object sender, EventArgs e)
        {
            
            if (LocalDrivingLicenseApplication.DoesHaveUnlockedTest(_LocalApplicationID,(int)_TestType))
            {
                MessageBox.Show("This Person already Have an active appointment for this test, you cannot add new appointment",
                        "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (LocalDrivingLicenseApplication.DoesPassedTheTest(_LocalApplicationID,(int)_TestType))
            {
                MessageBox.Show("This Person already Passed this test, you can only Retake faold test",
                       "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ScheduleTest = new frmScheduleTest(_TestType,_LocalApplicationID);

            ScheduleTest.ShowDialog();

            _RefreshListTestAppointment();

        }

        private void frmTestAppointements_Load(object sender, EventArgs e)
        {
            _LoadData();

           
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AddEditSchduleTest = new frmScheduleTest((int)dgvListTestAppointements.CurrentRow.Cells[0].Value, _TestType, _LocalApplicationID);

            AddEditSchduleTest.ShowDialog();


        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var TakeTest = new frmTakeTest(Convert.ToInt16(dgvListTestAppointements.CurrentRow.Cells [0].Value),_TestType);

            TakeTest.ShowDialog();

            _RefreshListTestAppointment();


        }
    }
}

