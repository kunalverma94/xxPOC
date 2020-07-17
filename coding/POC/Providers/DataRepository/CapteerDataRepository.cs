using ConsoleApp4.DTO.Capterra;
using System.Collections.Generic;

namespace ConsoleApp4.DataProvider
{
    public class CapteerDataRepository : DataRepository<CapterraDTO>, IDataRepository<CapterraDTO>
    {

        public CapteerDataRepository(IDataSourceReader<CapterraDTO> reader) : base(reader)
        {
        }

        public override IEnumerable<CapterraDTO> GetProducts()
        {
            return reader.Read();
        }
    }
}