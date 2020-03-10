using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Toys4U_Front_Office
{
    public partial class ProductHome : System.Web.UI.Page
    {
        //this function handles the load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayToys();
            }
        }

        void DisplayToys()
        {
            //create an instance of the toys collection
            Toys4U_Classes.clsProductCollection Toys = new Toys4U_Classes.clsProductCollection();
            //set the data source to the list of toys in  the collection
            LstToys.DataSource = Toys.ProductHome;
            //set the name of the primary key
            LstToys.DataValueField = "ProductID";
            //set the data feild to display
            LstToys.DataTextField = "Name";
            //set the data feild to display
            LstToys.DataTextField = "Description";
            //set the data feild to display
            LstToys.DataTextField = "StockQuantity";
            //bind the data to the list
            LstToys.DataBind();

        }

        protected void BtnApply_Click(object sender, EventArgs e)
        {

        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void BtnAdd_Click()
        {

        }
    }
}