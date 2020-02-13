using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class ProductViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create an instance of clsproduct
            clsProduct AnProduct = new clsProduct();
            //get the data from the session object 
            AnProduct = (clsProduct)Session["AnProduct"];
            //display the product id for this entry only
            Response.Write(AnProduct.ProductID);
            Response.Write(AnProduct.Name);
            Response.Write(AnProduct.Description);
            Response.Write(AnProduct.StockQuantity);
        }
    }
}