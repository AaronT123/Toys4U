using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

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
            clsProductCollection Toys = new clsProductCollection();
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
            //event handler for the delete button 
            //var to store the primary key value of the record to be deleted
            Int32 ProductID;
            //if a record has been selected from the list
            if (LstToys.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                ProductID = Convert.ToInt32(LstToys.SelectedValue);
                //store the data in the session object
                Session["ProductID"] = ProductID;
                //redirect to the delete page 
                Response.Redirect("ProductDelete.aspx");

            }

        }

       

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            //event handler for the edit button
            //var to store the primary key value of the record to be edited
            Int32 ProductID;
            //if a record has been selected from the list
            if (LstToys.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                ProductID = Convert.ToInt32(LstToys.SelectedValue);
                //store the data in the session object
                Session["ProductID"] = ProductID;
                //redirect to the edit page
                Response.Redirect("AnProduct.aspx");
            }

        }

        protected void BtnAdd_Click2(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record 
            Session["ProductID"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnProduct.aspx");
        }

        protected void BtnDisplayAll_Click(object sender, EventArgs e)
        {

        }
    }
}