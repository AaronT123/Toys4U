using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class ProductDelete : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted 
        Int32 ProductID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //event handler for the load event

            //get the ID of the product to be deleted from the session object
            ProductID = Convert.ToInt32(Session["ProductID"]);
        }

        void DeleteProduct()
        {
            //function to delete the selected record

            //create a new instance of the product book
            clsProductCollection ProductBook = new clsProductCollection();
            //find the record to delete
            ProductBook.ThisProduct.Find(ProductID);
            // delete the record 
            ProductBook.Delete();

        }

        protected void BtnYes_Click(object sender, EventArgs e)
        {
            //event handler for the yes button

            //delete the record
            DeleteProduct();
            //redirect back to the main page
            Response.Redirect("ProductHome.aspx");


        }

    }
}

