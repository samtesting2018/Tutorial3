using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NorthwindTableAdapters;

/// <summary>
/// Summary description for EmployeesBLL
/// </summary>
public class EmployeesBLL
{
    private EmployeesTableAdapter _employeesAdapter = null;
    protected EmployeesTableAdapter Adapter
    {
        get
        {
            if (_employeesAdapter == null)
                _employeesAdapter = new EmployeesTableAdapter();

            return _employeesAdapter;
        }
    }


    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
    public Northwind.EmployeesDataTable GetEmployees()
    {
        return Adapter.GetEmployees();
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
    public Northwind.EmployeesDataTable GetEmployeeByEmployeeID(int employeeID)
    {
        return Adapter.GetEmployeeByEmployeeID(employeeID);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
    public Northwind.EmployeesDataTable GetEmployeesByManager(int managerID)
    {
        return Adapter.GetEmployeesByManager(managerID);
    }
}