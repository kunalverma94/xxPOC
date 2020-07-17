using ConsoleApp4.Models;
using ConsoleApp4.Models.DTO.Request;
using ConsoleApp4.Providers;
using System;
using System.Linq;

namespace ConsoleApp4
{
    public class Program
    {
        static void Main(string[] args)
        {
            // args = new string[] { "Capterra", "feed-products/capterra.yaml" };
           // args = new string[] { "softwareadvice", "feed-products/softwareadvice.json" };

            try
            {
                IRequest request = Request.GetRequest(args);
                IBaseService service = AppFactory.AppFactoryInstance(request);

                service.GetProducts()
                    .ToList()
                    .ForEach(a => a.BeginImport());
            }
            catch (Exception r)
            {
                Console.WriteLine(AppSetting.HELPTEXT);
            }
        }


    }
}
