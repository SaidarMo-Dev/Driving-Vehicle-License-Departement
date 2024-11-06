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
using DVLDWindowsForms.Users;



namespace DVLDWindowsForms
{
    public partial class frmManageUsers : Form
    {
        public string SelectedItemInCbUsersFilter = "";


        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void _PrepareControls()
        {
            cbUserFilters.SelectedIndex = 0;

            tbUsersFilter.Visible = false;

            cbFilterUsersActive.SelectedIndex = 0;
            cbFilterUsersActive.Visible = false;
           
        }

      
        private void _LoadUsers()
        {
            DataTable  dtListUsers= User.GetAllUsers();

            dgvListUsers.DataSource = dtListUsers;

            


            if (dgvListUsers.RowCount > 0 )
            {
                dgvListUsers.Columns[0].HeaderText = "User ID";
                dgvListUsers.Columns[0].Width = 100;

                dgvListUsers.Columns[1].HeaderText = "UserName ";
                dgvListUsers.Columns[1].Width = 120;

                dgvListUsers.Columns[2].HeaderText = "Full Name";
                dgvListUsers.Columns[2].Width = 350;

                dgvListUsers.Columns[3].HeaderText = "Is Active";
                dgvListUsers.Columns[3].Width = 100;

            }

            lblTotalRecords.Text = dgvListUsers.RowCount.ToString();
        }

        private void _PerformSelectItemInCbUsersFilter()
        {
            SelectedItemInCbUsersFilter = cbUserFilters.SelectedItem.ToString();

            if (cbUserFilters.SelectedItem.ToString() == "IsActive")
            {
                cbFilterUsersActive.Visible = true;
                tbUsersFilter.Visible = false;

            }
            else if (cbUserFilters.SelectedItem.ToString() != "none")
            {
               
                cbFilterUsersActive.Visible = false;
                tbUsersFilter.Visible = true;
               
            }
            else
            {
                _LoadUsers();
                cbFilterUsersActive.Visible = false;
                tbUsersFilter.Visible = false;

            }
            

        }

        private void _PerformFiltering()
        {

            DataView dvListUsers = User.GetAllUsers().DefaultView;

            switch (SelectedItemInCbUsersFilter)
            {

              
                case "User ID":
                    dvListUsers.RowFilter = "UserID = '" + tbUsersFilter.Text.ToString() + "'";
                    dgvListUsers.DataSource = dvListUsers;
                    lblTotalRecords.Text = dgvListUsers.RowCount.ToString();

                    break;
                case "Person ID":
                    dvListUsers.RowFilter = "PersonID = '" + tbUsersFilter.Text.ToString() + "'";
                    dgvListUsers.DataSource = dvListUsers;
                    lblTotalRecords.Text = dgvListUsers.RowCount.ToString();

                    break;

                case "Full Name":
                    dvListUsers.RowFilter = "FullName Like  '" + tbUsersFilter.Text.ToString() + "%'";
                    dgvListUsers.DataSource = dvListUsers;
                    lblTotalRecords.Text = dgvListUsers.RowCount.ToString();

                    break;

                case "UserName":
                    dvListUsers.RowFilter = "UserName Like  '" + tbUsersFilter.Text.ToString() + "%'";
                    dgvListUsers.DataSource = dvListUsers;
                    lblTotalRecords.Text = dgvListUsers.RowCount.ToString();

                    break;

            }
        }

        private void dgvListUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {


            _LoadUsers();

            _PrepareControls();
          
            
        }

        private void cbUserFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            _PerformSelectItemInCbUsersFilter();
        }

        private void tbUsersFilter_TextChanged(object sender, EventArgs e)
        {
            _PerformFiltering();
        }

        private void cbFilterUsersActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataView dvListUsers = User.GetAllUsers().DefaultView;

            if (cbFilterUsersActive.SelectedIndex == 0)
            {
                dgvListUsers.DataSource = User.GetAllUsers();
            }
            else if (cbFilterUsersActive.SelectedIndex == 1)
            {
                dvListUsers.RowFilter = "IsActive = true";
                dgvListUsers.DataSource = dvListUsers;
                lblTotalRecords.Text = dgvListUsers.RowCount.ToString();

            }
            else
            {
                dvListUsers.RowFilter = "IsActive = false";
                dgvListUsers.DataSource = dvListUsers;
                lblTotalRecords.Text = dgvListUsers.RowCount.ToString();
            }
               
            
        }

        private void tbUsersFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (cbUserFilters.SelectedItem.ToString() == "User ID" || cbUserFilters.SelectedItem.ToString() == "Person ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AddEditUser = new frmAddEditUser(-1);

            AddEditUser.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void showUSerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmShowInfo = new frmShowUserDetails(Convert.ToInt16(dgvListUsers .CurrentRow .Cells[0].Value));
            frmShowInfo.ShowDialog();



        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAddNewUser = new frmAddEditUser(-1);

            frmAddNewUser.ShowDialog();
            _LoadUsers();

        }

        private void editUSeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmEditUser = new frmAddEditUser(Convert.ToInt16(dgvListUsers.CurrentRow.Cells[0].Value));

            frmEditUser.ShowDialog();
            _LoadUsers();


        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox .Show ("Are you sure you want to delete this user ","",
                                    MessageBoxButtons.OKCancel , MessageBoxIcon.Question) == DialogResult .OK)
            {

                if (User.DeleteUser(Convert.ToInt16(dgvListUsers.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("User Deleted Succussfully", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _LoadUsers();
                
                
                }
                else
                    MessageBox.Show("Couldn't Delete this user");

            }

            _LoadUsers();

            
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This future doesn't Emplimented yet");

        }

        private void callPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This future doesn't Emplimented yet");
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ChangePassword = new frmChangePassword(Convert.ToInt16(dgvListUsers.CurrentRow.Cells[0].Value));

            ChangePassword.ShowDialog();



        }

    }
}
