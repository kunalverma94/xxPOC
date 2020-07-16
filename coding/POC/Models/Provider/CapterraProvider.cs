using ConsoleApp4.DataProvider;
using ConsoleApp4.DTO.BaseClient;
using ConsoleApp4.DTO.Capterra;
using ConsoleApp4.Models.DTO.Adapter;
using ConsoleApp4.Models.DTO.Request;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4.Providers
{
    /// <inheritdoc/>
    public class CapterraProvider : BaseProvider, IProductProvider
    {
        public CapterraProvider(IRequestContext requestContext) : base(requestContext)
        {

        }

        #region Methods

        /// <inheritdoc/>
        public override FileType DefaultFileType() => FileType.YAML;

        /// <inheritdoc/>
        public override ReadSource DefaultSource() => ReadSource.LOCAL;

        /// <inheritdoc/>
        public override IEnumerable<IClient> GetClients()
        {
            return serializable
                  .GetObject<IEnumerable<Capterra>>(reader.ReadData(requestContext.ResourcePath))
                     .Select(a => (IClient)(new CapterraAadpter(a)));
        }

        /// <inheritdoc/>
        public override void StartImporting()
        {
            //Execute some common functionality Common accross all clients
            base.StartImporting();
            // execute private functionality only for this one
        } 

        #endregion
    }
}
