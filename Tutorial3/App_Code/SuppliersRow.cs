using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NorthwindTableAdapters;

/// <summary>
/// Summary description for SuppliersRow
/// </summary>
public partial class Northwind
{
    public partial class SuppliersRow
    {
        public Northwind.ProductsDataTable GetProducts()
        {
            ProductsTableAdapter productsAdapter = new ProductsTableAdapter();
            return productsAdapter.GetProductsBySupplierID(this.SupplierID);
        }
    }
}