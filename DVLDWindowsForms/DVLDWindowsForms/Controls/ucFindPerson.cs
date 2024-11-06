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


namespace DVLDWindowsForms
{
    public partial class ucFindPerson : UserControl
    {

        public event Action<int> OnPersonSelected;

        protected void PersonSelected(int PersonID)
        {
            Action<int> Handler = OnPersonSelected;

            if (Handler != null)
            {
                Handler(PersonID);
            }

        }

        public int UserID { set; get; }

        private int _PersonID = -1;

     //   public int PersonID { set; get; }

        public int SelectedPersonID
        {
            get
            {
                return _PersonID;
            }
        }
        public Person SelectedPersonInfo
        {
            get
            {
                return ucShowPersonInfo1.SelectedPersonInfo;
            }
        }
      
        
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
                gbAddPerson.Enabled = _FilterEnabled;
            }
        }

        public ucFindPerson()
        {
            InitializeComponent();
           // PrepareData();

        }

     

        public void LoadPersonInfo(int PersonID)
        {
            this._PersonID = PersonID;

            cbFilters.SelectedIndex = 1;
            tbValue.Text = PersonID.ToString();
            FindNow();

        }



      


        private void FindNow()
        {
            switch (cbFilters.Text)
            {
                case "Person ID":
                    ucShowPersonInfo1.LoadPersonData(int.Parse(tbValue.Text));

                    break;

                case "National No":
                    ucShowPersonInfo1.LoadPersonData(tbValue.Text);
                    break;

                default:
                    break;
            }

            if (OnPersonSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnPersonSelected(ucShowPersonInfo1.PersonID);



            this._PersonID = ucShowPersonInfo1.PersonID;

        }




      
        private void ucShowPersonInfo1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            FindNow();
           

          
        }

        private void gbFIlter_Enter(object sender, EventArgs e)
        {

        }

        private void ucFindPerson_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            tbValue.Focus();


        }

        private void tbValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbValue_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                btnSearchPerson.PerformClick();
            }

            if (cbFilters.SelectedItem.ToString() == "Person ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
                
                    
                
            
        }

        private void tbValue_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    _SearchForPerson();
            //}
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frmAddNewPerson = new frmAddEditPerson(-1);
            
            frmAddNewPerson.DataToSend += frmAddNewPerson_DataToSend;

            frmAddNewPerson.ShowDialog();

        }


        private void frmAddNewPerson_DataToSend(object sender , int PersonID)
        {
            this._PersonID  = PersonID;
            cbFilters.SelectedIndex = 0;
            tbValue.Text = PersonID.ToString();

            ucShowPersonInfo1.LoadPersonData(PersonID);

           
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbValue.Text = "";
            tbValue.Focus();

        }
    
    
    }
}
