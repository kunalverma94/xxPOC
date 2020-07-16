using ConsoleApp4.DataProvider;
using ConsoleApp4.DTO.BaseClient;
using ConsoleApp4.DTO.Capterra;
using ConsoleApp4.Models.DTO.Adapter;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4.Providers
{
    /// <inheritdoc/>
    public class CapterraService : IBaseService
    {
        private readonly IDataRepository<ICapterraDTO> _dataRepository;

        public CapterraService(IDataRepository<ICapterraDTO> dataRepository)
        {
            _dataRepository = dataRepository;

        }

        public IEnumerable<IProducts> GetProducts()
        {
            return this._dataRepository.GetProducts().Select(a => new Capterra(a));
        }
    }
}
