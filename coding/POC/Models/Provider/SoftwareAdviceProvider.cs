using ConsoleApp4.DataProvider;
using ConsoleApp4.DTO.BaseClient;
using ConsoleApp4.DTO.SoftwareAdvice;
using ConsoleApp4.Models.DTO.Adapter;
using ConsoleApp4.Models.DTO.Request;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4.Providers
{
    /// <inheritdoc/>
    public class SoftwareAdviceProvider : BaseProvider, IProductProvider
    {
        public SoftwareAdviceProvider(IRequestContext requestContext) : base(requestContext) { }

        /// <inheritdoc/>
        public override FileType DefaultFileType() => FileType.JSON;

        /// <inheritdoc/>
        public override ReadSource DefaultSource() => ReadSource.LOCAL;

        /// <inheritdoc/>
        public override IEnumerable<IClient> GetClients()
        {
            return serializable
                  .GetObject<SoftwareAdviceResponseModel>(reader.ReadData(requestContext.ResourcePath)).products
                     .Select(a => (IClient)(new SoftwareAdviceAadpter(a)));
        }

        /// <inheritdoc/>
        public override void StartImporting()
        {
            //Execute some common functionality Common accross all clients
            base.StartImporting();
            // execute private functionality only for this one
        }
    }
}
