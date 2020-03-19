using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toys4U_Back_Office
{
    public partial class StaffList : Form
    {
        public StaffList()
        {
            InitializeComponent();
        }

        private void StaffList_Load(object sender, EventArgs e)
        {
            DisplayStaff();
        }
        void DisplayStaff()
        {
            //create an instance of the staff collection
            Toys4U_Classes.clsStaffCollection Staffs = new Toys4U_Classes.clsStaffCollection();
            //set the data source to the list of staff in the collection
            lstStaff.DataSource = Staffs.StaffList;
            //set the name of the primary key
            lstStaff.DataValueField = "StaffNo";
            //bind the data to the list
            lstStaff.DataTextField = "FirstName";
            //bind the data to the list 
            lstStaff.DataBind();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["StaffNo"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnStaff.aspx");
        }
    }
}
