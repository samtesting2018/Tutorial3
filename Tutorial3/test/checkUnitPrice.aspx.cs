using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class test_checkUnitPrice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductsBLL productLogic = new ProductsBLL();

        // Update ProductID 1's information
        try
        {
            //This will fail since we're attempting to use a
            // UnitPrice value less than 0.
            productLogic.UpdateProduct("Scott's Tea", 1, 1, null, -14m, 10, null, null, false, 1);
        }
        catch (ArgumentException ae)
        {
            Response.Write("There was a problem: " + ae.Message);
        }
    }
}