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
            //create an new instance of clsProduct
            clsProduct AnProduct = new clsProduct();
            //capture the product id
            AnProduct.ProductID = Convert.ToInt32(txtProductID.Text);
            AnProduct.Name = txtName.Text;
            AnProduct.Description = txtDescription.Text;
            AnProduct.StockQuantity = Convert.ToInt32(txtStockquantity.Text);
            //store the product id in the session object 
            Session["AnProduct"] = AnProduct;
            //redirect to viewer page
            Response.Redirect("ProductViewer.aspx");
        }
    }
}