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
using System.IO;


namespace DVLDWindowsForms
{
    public partial class ucShowPersonInfo : UserControl
    {


        private int _PersonID = -1;

        public int PersonID
        {
            get
            {
                return _PersonID;
            }
        }

        private Person _Person;

        public Person SelectedPersonInfo
        {
            get 
            {
                return _Person;
            }
        }


        public ucShowPersonInfo()
        {
            InitializeComponent();
        }

       

        private string _GetGendor()
        {
            if (_Person.Gendor == 0)
            {
                return "Male";

            }
            else
                return "Female";
        }


        private void _LoadPersonImage()
        {
            if (_Person.Gendor == 0)
                pbPersonImage.Image = Properties.Resources.Male_512;
            else
                pbPersonImage.Image = Properties.Resources.Female_512;


            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        // get Person Info By Person ID 
        public void LoadPersonData(int PersonID)
        {

            _Person = Person.FindByID(PersonID);
            

            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with Person ID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
            _PersonID = _Person.PersonID;

            linklblEditPersonInfo.Visible = (lblPersonID.Text != "N/A");


        }

        // get Person Info By National No 
        public void LoadPersonData(string NationalNo)
        {

            _Person = Person.FindByNationalNo(NationalNo);

            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with Person ID = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
            _PersonID = _Person.PersonID;

            linklblEditPersonInfo.Visible = (lblPersonID.Text != "N/A");


        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblName.Text = "[????]";
           // pbGendor.Image = Properties.Resources.Man_32;
            lblGendor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            pbPersonImage.Image = Properties.Resources.Male_512;

        }

        private void _FillPersonInfo()
        {
            string FullName = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;

            DateTime DateOfBirth = _Person.DateOfBirth;

            lblPersonID.Text = _Person.PersonID.ToString();
            lblNationalNo.Text = _Person.NationalNo;
            lblName.Text = FullName;
            lblGendor.Text = _GetGendor();
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;

            lblDateOfBirth.Text = DateOfBirth.Day + "/" + DateOfBirth.Month + "/" + DateOfBirth.Year;

            lblCountry.Text = clsCountry.FindCountryByID(_Person.NationalityCountryID).CountryName;
            lblPhone.Text = _Person.Phone;
            _LoadPersonImage();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ucShowPersonInfo_Load(object sender, EventArgs e)
        {
           

        }

        private void pbPersonImage_Click(object sender, EventArgs e)
        {
           

        }

        private void linklblEditPersonImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmAddEditPerson(_Person.PersonID);
            frm.ShowDialog();

            LoadPersonData(_Person.PersonID);

        
        }

    }
}
