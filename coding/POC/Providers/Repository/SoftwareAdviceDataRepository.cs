using ConsoleApp4.DTO.SoftwareAdvice;
using ConsoleApp4.Models.DTO.Request;
using ConsoleApp4.Providerrs;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace ConsoleApp4.DataProvider
{
    public class SoftwareAdviceDataRepository : DataRepository<ISoftwareAdviceDTO>, IDataRepository<ISoftwareAdviceDTO>
    {
        private const string _root = "products";

        public SoftwareAdviceDataRepository(IRequest path, IProductSerializer serializable, IReader reader) : base(path, serializable, reader)
        {
        }

        public override IEnumerable<ISoftwareAdviceDTO> GetProducts()
        {
            return serializable.GetObject<JObject>(reader.Read(request.FilePath))
            .GetValue(_root, System.StringComparison.InvariantCultureIgnoreCase).ToObject<IEnumerable<SoftwareAdviceDTO>>();
        }
    }
}