using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DVLDWindowsForms
{
    public partial class frmShowPersonDetails : Form
    {


        private int _PersonID = -1;
        public int PersonID
        {
            get
            {
                return _PersonID;
            }
        }


        public frmShowPersonDetails(int PersonID)
        {
            InitializeComponent();
            //ucShowPersonInfo1.PersonID = PersonID;

            _PersonID = PersonID;
           
        }

        private void frmShowPersonDetails_Load(object sender, EventArgs e)
        {
            ucShowPersonInfo1.LoadPersonData(_PersonID);
        }

        private void btnClosee_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
