using NorthwindTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CategoriesBLL
/// </summary>
[System.ComponentModel.DataObject]
public class CategoriesBLL
{
    private CategoriesTableAdapter _categoiesAdapter = null;
    protected CategoriesTableAdapter Adapter
    {
        get
        {
            if (_categoiesAdapter == null)
                _categoiesAdapter = new CategoriesTableAdapter();

            return _categoiesAdapter;
        }
    }


    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
    public Northwind.CategoriesDataTable GetCategories()
    {
        return Adapter.GetCategories();
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
    public Northwind.CategoriesDataTable GetCategoryByCategoryID(int categoryID)
    {
        return Adapter.GetCategoryByCategoryID(categoryID);
    }
}