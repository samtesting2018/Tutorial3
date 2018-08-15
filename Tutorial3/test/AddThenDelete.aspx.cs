using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class test_AddThenDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        NorthwindTableAdapters.ProductsTableAdapter productsAdapter = new NorthwindTableAdapters.ProductsTableAdapter();

        // Add a new product
        int new_productID = Convert.ToInt32(productsAdapter.InsertProduct("New Product", 1, 1, "12 tins per carton", 14.95m, 10, 0, 10, false));

        // On second thought, delete the product
        productsAdapter.Delete(new_productID);
    }
}