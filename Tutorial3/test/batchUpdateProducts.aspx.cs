using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class test_batchUpdateProducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        NorthwindTableAdapters.ProductsTableAdapter productsAdapter = new NorthwindTableAdapters.ProductsTableAdapter();

        // For each product, double its price if it is not discontinued and
        // there are 25 items in stock or less
        Northwind.ProductsDataTable products = productsAdapter.GetProducts();
        foreach (Northwind.ProductsRow product in products)
        {
            if (!product.Discontinued && product.UnitsInStock <= 25)
                product.UnitsInStock *= 2;
        }

        // Update the products
        productsAdapter.Update(products);
    }
}