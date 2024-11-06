using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DVLDWindowsForms;
using DVLDBusinessLayer;

namespace DVLDWindowsForms.Users
{
    public partial class frmShowUserDetails : Form
    {

        public int UserID { set; get; } 


        public frmShowUserDetails(int UserID)
        {
            
            InitializeComponent();
          //  ucShowPersonInfo1.PersonID = User.GetUserByID(UserID).PersonID;

            ucShowPersonInfo1.LoadPersonData(User.GetUserByID(UserID).PersonID);

            ucUserInfo1.UserID = UserID;


        }
       
        
        private void frmShowUserDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
