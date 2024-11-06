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

namespace DVLDWindowsForms.Controls
{
    public partial class ucUserInfo : UserControl
    {

        public int UserID { set; get; }

        public ucUserInfo()
        {
            InitializeComponent();
        }



        private void _LoadUserLoginInfo()
        {
            User user = User.GetUserByID(UserID);

            if (user != null)
            {

                lblUserID.Text = user.UserID.ToString();
                lblUsername.Text = user.UserName.ToString();
                lblIsActive.Text = (user.IsActive) ? "Yes" : "No";

            }




        }
        private void ucUserInfo_Load(object sender, EventArgs e)
        {
            _LoadUserLoginInfo();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
