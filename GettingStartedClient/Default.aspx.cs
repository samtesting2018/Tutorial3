using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Step 1: Create an instance of the WCF proxy.  
        CalculatorClient client = new CalculatorClient();

        // Step 2: Call the service operations.  
        // Call the Add service operation.  
        double value1 = 100.00D;
        double value2 = 15.99D;
        double result = client.Add(value1, value2);
        //Response.Write("Add(" + value1 + "," + value2 + ") = " + result);
        //Response.Write("<br/>");
        label1.Text = "Add(" + value1 + "," + value2 + ") = " + result;

        // Call the Subtract service operation.  
        value1 = 145.00D;
        value2 = 76.54D;
        result = client.Subtract(value1, value2);
        //Response.Write("Subtract(" + value1 + "," + value2 + ") = " + result);
        //Response.Write("<br/>");
        label2.Text = "Subtract(" + value1 + "," + value2 + ") = " + result;

        // Call the Multiply service operation.  
        value1 = 9.00D;
        value2 = 81.25D;
        result = client.Multiply(value1, value2);
        //Response.Write("Multiply(" + value1 + "," + value2 + ") = " + result);
        //Response.Write("<br/>");
        label3.Text = "Multiply(" + value1 + "," + value2 + ") = " + result;

        // Call the Divide service operation.  
        value1 = 22.00D;
        value2 = 7.00D;
        result = client.Divide(value1, value2);
        //Response.Write("Divide(" + value1 + "," + value2 + ") = " + result);
        label4.Text = "Divide(" + value1 + "," + value2 + ") = " + result;

        //Step 3: Closing the client gracefully closes the connection and cleans up resources.  
        client.Close();
    }
}