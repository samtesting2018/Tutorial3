﻿using NorthwindTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CategoriesBLL
/// </summary>
[System.ComponentModel.DataObject]
public class SuppliersBLL
{
    private SuppliersTableAdapter _suppliersAdapter = null;
    protected SuppliersTableAdapter Adapter
    {
        get
        {
            if (_suppliersAdapter == null)
                _suppliersAdapter = new SuppliersTableAdapter();

            return _suppliersAdapter;
        }
    }


    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
    public Northwind.SuppliersDataTable GetSuppliers()
    {
        return Adapter.GetSuppliers();
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
    public Northwind.SuppliersDataTable GetSupplieBySupplieID(int supplierID)
    {
        return Adapter.GetSupplierBySupplierID(supplierID);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
    public Northwind.SuppliersDataTable GetSuppliersByCountry(string country)
    {
        return Adapter.GetSuppliersByCountry(country);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
    public bool UpdateSupplierAddress(int supplierID, string address, string city, string country)
    {
        Northwind.SuppliersDataTable suppliers = Adapter.GetSupplierBySupplierID(supplierID);
        if (suppliers.Count == 0)
            // no matching record found, return false
            return false;
        else
        {
            Northwind.SuppliersRow supplier = suppliers[0];

            if (address == null) supplier.SetAddressNull(); else supplier.Address = address;
            if (city == null) supplier.SetCityNull(); else supplier.City = city;
            if (country == null) supplier.SetCountryNull(); else supplier.Country = country;

            // Update the product record
            int rowsAffected = Adapter.Update(supplier);

            // Return true if precisely one row was updated, otherwise false
            return rowsAffected == 1;
        }
    }
}