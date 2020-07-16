using ConsoleApp4.Models.DTO.Request;
using System;

namespace ConsoleApp4.Providers
{
    /// <summary>
    /// Factory Method
    /// </summary>
    public static class ProductProviderFactory
    {

        /// <summary>
        /// Provides the client Provider Instance with default sttings <see cref="IProductProvider"/>
        /// </summary>
        /// <param name="requestContext"> <see cref="IRequestContext"/> </param>
        /// <returns> A <see cref="IProductProvider"/> </returns>
        public static IProductProvider GetProductProvider(IRequestContext requestContext)
        {
            IProductProvider productProvider;

            switch (requestContext.Clients)
            {
                case Client.Capterra:
                productProvider = new CapterraProvider(requestContext);
                break;

                case Client.SoftwareAdvice:
                productProvider = new SoftwareAdviceProvider(requestContext);
                break;

                case Client.INVALID:
                default:
                throw new NotImplementedException();
            }

            productProvider.LoadDefaultSettings();

            return productProvider;
        }
    }
}
