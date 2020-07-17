using ConsoleApp4.DTO.SoftwareAdvice;
using System.Collections.Generic;

namespace ConsoleApp4.DataProvider
{
    public class SoftwareAdviceDataRepository : DataRepository<SoftwareAdviceDTO>, IDataRepository<SoftwareAdviceDTO>
    {

        public SoftwareAdviceDataRepository(IDataSourceReader<SoftwareAdviceDTO> reader) : base(reader)
        {
        }

        public override IEnumerable<SoftwareAdviceDTO> GetProducts()
        {
            return this.reader.Read<SoftwareAdviceListDTO>().Products;
        }

    }
}