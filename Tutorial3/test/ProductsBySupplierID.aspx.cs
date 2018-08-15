using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class test_ProductsBySupplierID : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        NorthwindTableAdapters.SuppliersTableAdapter suppliersAdapter = new NorthwindTableAdapters.SuppliersTableAdapter();

        // Get all of the suppliers
        Northwind.SuppliersDataTable suppliers = suppliersAdapter.GetSuppliers();

        // Enumerate the suppliers
        foreach (Northwind.SuppliersRow supplier in suppliers)
        {
            Response.Write("Supplier: " + supplier.CompanyName);
            Response.Write("<ul>");

            // List the products for this supplier
            Northwind.ProductsDataTable products = supplier.GetProducts();
            foreach (Northwind.ProductsRow product in products)
                Response.Write("<li>" + product.ProductName + "</li>");

            Response.Write("</ul><p>&nbsp;</p>");
        }
    }
}