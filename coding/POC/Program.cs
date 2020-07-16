namespace ConsoleApp4
{
    using ConsoleApp4.Models;
    using ConsoleApp4.Models.DTO.Request;
    using ConsoleApp4.Providers;
    using System;


    class Program
    {
        static void Main(string[] args)
        {
            //For Test Run
            // args = new string[] { "Capterra", "feed-products/capterra.yaml" };
            //args = new string[] { "softwareadvice", "feed-products/softwareadvice.json" };

            try
            {
                IRequestContext requestContext = RequestContext.GetRequest(args);

                IProductProvider client = ProductProviderFactory.GetProductProvider(requestContext);

                client.StartImporting();
            }
            catch (Exception)
            {
                Console.WriteLine(AppSetting.HELPTEXT);
            }
        }
    }
}
