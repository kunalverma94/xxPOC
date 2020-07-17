using ConsoleApp4.DataProvider;
using ConsoleApp4.DTO.BaseClient;
using ConsoleApp4.DTO.SoftwareAdvice;
using ConsoleApp4.Models.DTO.Adapter;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4.Providers
{
    /// <inheritdoc/>
    public class SoftwareAdviceService : IBaseService
    {
        private readonly IDataRepository<SoftwareAdviceDTO> _dataRepository;

        public SoftwareAdviceService(IDataRepository<SoftwareAdviceDTO> dataRepository)
        {
            _dataRepository = dataRepository;

        }

        public IEnumerable<IProducts> GetProducts()
        {
            return this._dataRepository.GetProducts().Select(a => new SoftwareAdvice(a));
        }
    }
}
