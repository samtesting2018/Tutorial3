using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WFC_testing_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Step 1 Create a URI to serve as the base address.  
        Uri baseAddress = new Uri("http://localhost:9954/");

        // Step 2 Create a ServiceHost instance  
        ServiceHost selfHost = new ServiceHost(typeof(CalculatorService), baseAddress);

        try
        {
            // Step 3 Add a service endpoint.  
            selfHost.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService");

            // Step 4 Enable metadata exchange.  
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            selfHost.Description.Behaviors.Add(smb);

            // Step 5 Start the service.  
            selfHost.Open();
            Response.Write("The service is ready.");
            Console.WriteLine();
            Console.ReadLine();

            // Close the ServiceHostBase to shutdown the service.  
            selfHost.Close();
        }
        catch (CommunicationException ce)
        {
            Console.WriteLine("An exception occurred: {0}", ce.Message);
            selfHost.Abort();
        }
        //ICalculatorService client = new CalculatorService();

        // Use the 'client' variable to call operations on the service.
        //label1.Text = Convert.ToString(client.Add(1.0, 1.0));
        // Always close the client.
        //client.Close();
    }
}