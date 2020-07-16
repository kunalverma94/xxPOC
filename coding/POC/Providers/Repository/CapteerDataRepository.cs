using ConsoleApp4.DTO.Capterra;
using ConsoleApp4.Models.DTO.Request;
using ConsoleApp4.Providerrs;
using System.Collections.Generic;

namespace ConsoleApp4.DataProvider
{
    public class CapteerDataRepository : DataRepository<ICapterraDTO>, IDataRepository<ICapterraDTO>
    {

        public CapteerDataRepository(IRequest path, IProductSerializer serializable, IReader reader) : base(path, serializable, reader)
        {
        }

        public override IEnumerable<ICapterraDTO> GetProducts()
        {
            return serializable.GetObject<IEnumerable<CapterraDTO>>(reader.Read(request.FilePath));
        }
    }
}