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
using System.Net.Mail;
using System.IO;
using DVLD.Classes;

namespace DVLDWindowsForms
{
    public partial class frmAddEditPerson : Form
    {
        public delegate void DataToSendEventHandler(object sender, int PersonID);
        public event DataToSendEventHandler DataToSend;


        enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private int _PersonID;

        public bool IsDataValide = false;
        public string PersonImagePath = "";
        
        private Person _Person;

        public frmAddEditPerson(int PersonID = -1 )
        {
            InitializeComponent();
            this._PersonID = PersonID;

            if (PersonID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
                _Mode = enMode.Update;
        }

       


        private bool _IsValideEmail(string Email)
        {
            try
            {
                MailAddress Emailaddr = new MailAddress(Email);
                return Emailaddr.Address == Email;
            }
            catch
            {
                return false;
            }
        }

        private void _LoadContries()
        {
            DataTable Countries = clsCountry.GetListCountries();

            foreach (DataRow row in Countries.Rows )
            {
                cbCountries.Items.Add(row["CountryName"]);
            }

        }

        private void _LoadData()
        {
            _LoadContries();
            cbCountries.SelectedIndex = 0;

            if (_Mode == enMode.AddNew)
            {
                _Person = new Person();
                lblTitle.Text = "Add New Person";
                linklblRemoveImage.Visible = false;
                return;
            }

            _Person = Person.FindByID(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("There is no person With ID " + _PersonID + "Make sure you have the right ID");
                this.Close();
                

                return;
            }


            lblTitle.Text = "Edit Person";


            lblPersonID.Text = _Person.PersonID.ToString();
            tbNationalNo.Text = _Person.NationalNo;

            tbFirstName.Text = _Person.FirstName;
            tbSecondName.Text = _Person.SecondName;
            tbThirdName.Text = _Person.ThirdName;
            tbLastName.Text = _Person.LastName;

            dtpDateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gendor == 0)
            {
                rbMale.Checked = true;
            }
            else
                rbFemale.Checked = true;

            tbPhone.Text = _Person.Phone;
            tbEmail.Text = _Person.Email;

            cbCountries.SelectedIndex = cbCountries.FindString(clsCountry.FindCountryByID(_Person.NationalityCountryID).CountryName);
            
            tbAddress.Text = _Person.Address;

            if (_Person.ImagePath != "")
            {
                pbPersonImage.Load(_Person.ImagePath);

            }

            linklblRemoveImage.Visible = (_Person.ImagePath != "");
           
        }



        private bool _HandlePersonImage()
        {

       
            //    _Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }


        

        private byte _GetGendor()
        {
            if (rbMale.Checked)
                return 0;
            else
                return 1;
        }

        private void _CollectPersonData()
        {
            int CountryID = clsCountry.FindCountryByName(cbCountries.Text.ToString()).ID;


            if (!_HandlePersonImage())
                return;


            _Person.FirstName = tbFirstName.Text.ToString();
            _Person.SecondName = tbSecondName.Text.ToString();
            _Person.ThirdName = tbThirdName.Text.ToString();
            _Person.LastName = tbLastName.Text.ToString();

            _Person.NationalNo = tbNationalNo.Text.ToString();

            _Person.Phone = tbPhone.Text.ToString();
            _Person.Email = tbEmail.Text.ToString();
            _Person.Address = tbAddress.Text.ToString();
            _Person.NationalityCountryID = CountryID;
            _Person.DateOfBirth = dtpDateOfBirth.Value;

            _Person.Gendor = _GetGendor();

            _Person.ImagePath = pbPersonImage.ImageLocation;
           
                



        }

        private void _SavePersonData()
        {
            _CollectPersonData();

            if (_Person.Save())
            {
                _Mode = enMode.Update;
                lblPersonID.Text = _Person.PersonID.ToString();
                lblTitle.Text = "Edit Person";
                linklblRemoveImage.Visible = (_Person.ImagePath != "");

                if (DataToSend != null )
                    DataToSend.Invoke(this, _Person.PersonID);

                MessageBox.Show("Person Saved Seccussfully","Data Saved",
                        MessageBoxButtons .OK, MessageBoxIcon.Information);


            }
            else
                MessageBox.Show("Error : Data Was Not Saved Seccussfully","Error",
                    MessageBoxButtons .OK, MessageBoxIcon.Error);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddEditFrom_Load(object sender, EventArgs e)
        {
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);

            _LoadData();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Properties.Resources.Female_512;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(pbPersonImage .ImageLocation == null)
                pbPersonImage.Image = Properties.Resources.Male_512;
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            

          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.InitialDirectory = "C:\\Users\abdelkhalek\\OneDrive - OFPPT";

            

            if (openFileDialog1 .ShowDialog() == DialogResult .OK )
            {
                try
                {



                    pbPersonImage.Load(openFileDialog1.FileName);
                   // PersonImagePath = openFileDialog1.FileName;

                    linklblRemoveImage.Visible = true;

 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error loading Image " + ex.Message);
                }
            }
        }

        private void pbPerosnImage_Click(object sender, EventArgs e)
        {

        }

        private void tbThirdName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbThirdName.Text.ToString()))
            {
                IsDataValide = false;
                epValidation.SetError(tbThirdName, "Third Name can not be empty");

            }
            else
            {
                epValidation.SetError(tbThirdName, "");
                IsDataValide = true;
            }

          
        }

        private void btnCloseAddEdit_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }
        
        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLastName.Text.ToString()))
            {
                IsDataValide = false;
                epValidation.SetError(tbLastName, "Last Name can not be empty");

            }
            else
            {
                epValidation.SetError(tbLastName, "");
                IsDataValide = true;
            }

        }

        private void tbSecondName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSecondName.Text.ToString()))
            {
                IsDataValide = false;
                epValidation.SetError(tbSecondName, "Second Name can not be empty");

            }
            else
            {
                epValidation.SetError(tbSecondName,"");
                IsDataValide = true;
            }

          
        }

        private void tbNationalNo_TextChanged(object sender, EventArgs e)
        {
            
        
        }


        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      

        private void btnSaveAddEdit_Click(object sender, EventArgs e)
        {
            if (IsDataValide)
            {
                _SavePersonData();
            }
            else
                MessageBox.Show("Some fields are not valid");
        }

        private void linklblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;

            linklblRemoveImage.Visible = false;



            if (rbMale.Checked)
                pbPersonImage.Image = Properties.Resources.Male_512;
            else
                pbPersonImage.Image = Properties.Resources.Female_512;




        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (_Person.NationalNo != tbNationalNo.Text.ToString())
            {
                if (string.IsNullOrEmpty(tbNationalNo.Text.ToString()))
                {
                    IsDataValide = false;
                    epValidation.SetError(tbNationalNo, "NationalNo can not be empty");

                }
                else if (Person.IsPersonExisteByNationalNo(tbNationalNo.Text.ToString()))
                {
                    epValidation.SetError(tbNationalNo, "NationlNo Already Existe");
                    IsDataValide = false;
                }
                else
                {
                    epValidation.SetError(tbNationalNo, "");
                    IsDataValide = true;

                }

            }
            else
            {
                epValidation.SetError(tbNationalNo, "");
                IsDataValide = true;
            }

        }

        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(tbAddress.Text.ToString()))
            {
                IsDataValide = false;
                epValidation.SetError(tbAddress, "Address can not be empty");

            }
            else
            {
                epValidation.SetError(tbAddress, "");
                IsDataValide = true;
            }

        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (_IsValideEmail(tbEmail.Text.ToString()))
            {
                IsDataValide = true;
                epValidation.SetError(tbEmail, "");

            }
            else
            {
                IsDataValide = false;
                epValidation.SetError(tbEmail, "this email is not valide ");
            }
         
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFirstName.Text.Trim()))
            {
                IsDataValide = false;
                epValidation.SetError(tbFirstName, "Third Name can not be empty");

            }
            else
            {
                epValidation.SetError(tbFirstName, "");
                IsDataValide = true;
            }
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPhone.Text.Trim()))
            {
                IsDataValide = false;
                epValidation.SetError(tbPhone, "Phone can not be empty");

            }
            else
            {
                epValidation.SetError(tbPhone, "");
                IsDataValide = true;
            }
        }


   


    }
}
