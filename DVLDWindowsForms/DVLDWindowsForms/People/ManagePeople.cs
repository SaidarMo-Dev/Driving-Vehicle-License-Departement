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
using System.IO;

namespace DVLDWindowsForms
{
    public partial class frManagePeople : Form
    {
 
        public frManagePeople()
        {
            InitializeComponent();
        }

        private void _PrepareControls()
        {
            tbfilter.Visible = false;
            cbFilter.SelectedIndex = 0;
            cbFilter.KeyPress += new KeyPressEventHandler(tbfilter_KeyPress);

        }

        private void _PerformSelectedItemFromCbFilter()
        {
           

            if (cbFilter.SelectedItem.ToString() == "none")
            {
                tbfilter.Visible = false;
                _RefrechPeopleData();
               
            }
            else
            {
                tbfilter.Visible = true;

            }
            
        }

        private async Task _RefrechPeopleData()
        {
            var People = await Task.Run(() => Person.GetPeople());

            dgvListPeople.DataSource = People;

             lblTotalRecords.Text = dgvListPeople.RowCount.ToString();
        }
     
        private void _PerformFiltering()
        {
            DataView dvListPersons = Person.GetPeople().DefaultView;

            switch (cbFilter .SelectedItem .ToString())
            {
                case "Person ID":
                    
                    dvListPersons.RowFilter = "PersonID = '" + tbfilter.Text.ToString() + "'";
                    dgvListPeople.DataSource = dvListPersons;
                    lblTotalRecords.Text = dgvListPeople.RowCount.ToString();
                    break;

                case "National No" :
                    //dgvListPeople.DataSource = Person.FilterPeopleByNationalNumber(tbfilter.Text.ToString());
                    dvListPersons.RowFilter = "NationalNo LIKE '" + tbfilter.Text.ToString()+ "'";
                    dgvListPeople.DataSource = dvListPersons;
                    lblTotalRecords.Text = dgvListPeople.RowCount.ToString();
                    break;

                case "FirstName":
                    dvListPersons.RowFilter = "FirstName LIKE '" + tbfilter.Text.ToString() + "%'";
                    dgvListPeople.DataSource = dvListPersons;
                    lblTotalRecords.Text = dgvListPeople.RowCount.ToString();
                    break;

                case "SecondName":
                    dvListPersons.RowFilter = "SecondName LIKE '" + tbfilter.Text.ToString() + "%'";
                    dgvListPeople.DataSource = dvListPersons;
                    lblTotalRecords.Text = dgvListPeople.RowCount.ToString();
                    break;
               
                case "ThirdName":
                    dvListPersons.RowFilter = "ThirdName LIKE '" + tbfilter.Text.ToString() + "%'";
                    dgvListPeople.DataSource = dvListPersons;
                    lblTotalRecords.Text = dgvListPeople.RowCount.ToString();
                    break;
               
                case "LastName":
                    dvListPersons.RowFilter = "LastName LIKE '" + tbfilter.Text.ToString() + "%'";
                    dgvListPeople.DataSource = dvListPersons;
                    lblTotalRecords.Text = dgvListPeople.RowCount.ToString();  
                    break;
                
                case "Nationality":
                    dvListPersons.RowFilter = "Nationality LIKE '" + tbfilter.Text.ToString() + "%'";
                    dgvListPeople.DataSource = dvListPersons;
                    lblTotalRecords.Text = dgvListPeople.RowCount.ToString();  
                    break;
                
                case "Gendor":
                    dvListPersons.RowFilter = "Gendor LIKE '" + tbfilter.Text.ToString() + "%'";
                    dgvListPeople.DataSource = dvListPersons;
                    lblTotalRecords.Text = dgvListPeople.RowCount.ToString();  
                    break;
                
                case "Phone":
                    dvListPersons.RowFilter = "Phone LIKE '" + tbfilter.Text.ToString() + "%'";
                    dgvListPeople.DataSource = dvListPersons;
                    lblTotalRecords.Text = dgvListPeople.RowCount.ToString();  
                    break;
                
                case "Email":
                    dvListPersons.RowFilter = "Email LIKE '" + tbfilter.Text.ToString() + "%'";
                    dgvListPeople.DataSource = dvListPersons;
                    lblTotalRecords.Text = dgvListPeople.RowCount.ToString();  
                    break;
                


            }
        }

        private void _PerformDeletePerson()
        {
            if (MessageBox.Show("Are You sure you want to delete this Person ?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string PersonImagePath = Person.GetPersonImagePath(Convert.ToInt16(dgvListPeople.CurrentRow.Cells[0].Value));
                if (Person.DeletePerson(Convert.ToInt16(dgvListPeople.CurrentRow.Cells[0].Value)))
                {

                    if (PersonImagePath != "")
                    {
                        File.Delete(PersonImagePath);
                    }
                   
                    MessageBox.Show("Person Has been deleted Successfully", "Success", MessageBoxButtons.OK);
                    
                   
                }
                else
                    MessageBox.Show("You can't delete this Person there is a data linked with it");
            }

           
        }


        private void dgvListPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frManagePeople_Load(object sender, EventArgs e)
        {
            //Task.Run(() => _RefrechPeopleData());

             _PrepareControls();
             _RefrechPeopleData();

           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _RefrechPeopleData();

            tbfilter.Text = "";

            _PerformSelectedItemFromCbFilter();
        }

        private void tbfilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedItem.ToString () == "Person ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        
        }

        private void tbfilter_TextChanged(object sender, EventArgs e)
        {
            _PerformFiltering();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _PerformDeletePerson();
            _RefrechPeopleData();


        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPerson(-1);
            frm.ShowDialog();
            _RefrechPeopleData();

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPerson(-1);
            frm.ShowDialog();
            _RefrechPeopleData();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPerson(Convert.ToInt16(dgvListPeople.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            _RefrechPeopleData();

        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sendEmailToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This Future does not Emplemented be Patient ...","Info", MessageBoxButtons .OK , MessageBoxIcon.Information);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonDetails(Convert.ToInt16(dgvListPeople.CurrentRow.Cells[0].Value));

            frm.ShowDialog();

            _RefrechPeopleData();


        }

        private void callPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Future does not Emplemented be Patient ...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
   
    }
}
