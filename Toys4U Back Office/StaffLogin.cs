using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toys4U_Classes;

namespace Toys4U_Back_Office
{
    public partial class StaffLogin : Form
    {
        private clsStaffSecurity mSec;
        public StaffLogin()
        {
            InitializeComponent();
        }

        private void StaffLogin_Load(object sender, EventArgs e)
        {
            mSec = new clsStaffSecurity();
        }


        public clsStaffSecurity Sec
        {
            get
            {
                return mSec;
            }
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            //try to sign in and record any errors
            string Error = mSec.SignIn(txtEmailAddress.Text, txtPassword.Text);
            //if there were any errors
            if(Error =="")
            {
                //close this form
                this.Close();

            }
            else
            {
                //otherwise show any errors
                lblError.Text = Error;
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {

        }
    }
}
