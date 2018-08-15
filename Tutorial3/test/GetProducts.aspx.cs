using System;

public partial class test_GetProducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        NorthwindTableAdapters.ProductsTableAdapter productsAdapter = new NorthwindTableAdapters.ProductsTableAdapter();
        Northwind.ProductsDataTable products = productsAdapter.GetProducts();

        foreach (Northwind.ProductsRow product in products)
        {
            Response.Write("Product: " + product.ProductName + "<br />");
        }
    }
}