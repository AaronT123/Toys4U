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
        //variable to store the primary key with page level scope
        Int32 ProductID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //gte the id of the product to be processed
            ProductID = Convert.ToInt32(Session["ProductID"]);
            if (IsPostBack == false)
            {
                //populate the list of products
                DisplayToys();
                //if this is not a new record
                if (ProductID !=-1)
                {
                    //DISPLAY THE CUREENT data for the record
                    DisplayToys();
                }
            }
        }

        private void DisplayToys()
        {
            //create an instance of the product book
            clsProductCollection ProductBook = new clsProductCollection();
            //find the record to update 
            ProductBook.ThisProduct.Find(ProductID);
            //display the data for this record
            txtName.Text = ProductBook.ThisProduct.Name;
            txtDescription.Text = ProductBook.ThisProduct.Description;
            txtStockquantity.Text = ProductBook.ThisProduct.Description;
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (ProductID == -1)
            {
                //add the new record
                Add();
            }
            else
            {
                //update the record
                Update();
            }
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

        void Update()
        {
            //create an instance of the product book
            Toys4U_Classes.clsProductCollection ProductBook = new Toys4U_Classes.clsProductCollection();
            //VALIDATE THE DATA ON THE WEB FROM
            String Error = ProductBook.ThisProduct.Valid(txtName.Text, txtDescription.Text, txtStockquantity.Text);
            //if the data is OK then add it to the the object
            if (Error == "")
            {
                //find the record to update 
                ProductBook.ThisProduct.Find(ProductID);
                //get the data entered by the user
                ProductBook.ThisProduct.Name = txtName.Text;
                ProductBook.ThisProduct.Description = txtDescription.Text;
                ProductBook.ThisProduct.StockQuantity = Convert.ToInt32(txtStockquantity.Text);
                //update the record
                ProductBook.Update();
                //all done so redirect back to main page 
                Response.Redirect("ProductHome.aspx");


            }
            else
            {
                //report an error
                lblError.Text = " There were problems with the data entered" + Error;
            }
        }

    }
}