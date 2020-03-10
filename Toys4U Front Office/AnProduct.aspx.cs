using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class AnProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            //add the new record
            Add();
            //all done so redirect back to the main page
            Response.Redirect("ProductHome.aspx");
        }

        //functions for adding new records 
        void Add()
        {
            //create an isntance of the product book 
            Toys4U_Classes.clsProductCollection ProductBook = new Toys4U_Classes.clsProductCollection();
            //validate the data on the web form
            String Error = ProductBook.ThisProduct.Valid(txtName.Text, txtDescription.Text, txtStockquantity.Text);
            //if the data is OK then add it to the object 
            if(Error == "")
            {
                //get the data entered by the user
                ProductBook.ThisProduct.Name = txtName.Text;
                ProductBook.ThisProduct.Description = txtDescription.Text;
                ProductBook.ThisProduct.StockQuantity = Convert.ToInt32(txtStockquantity.Text);
                //add the record
                ProductBook.Add();
            }
            else
            {
                //report an error 
                lblError.Text = "There were problems with the data entered" + Error;
            }
        }
    }
}