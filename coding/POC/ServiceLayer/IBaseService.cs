using ConsoleApp4.DTO.BaseClient;
using System.Collections.Generic;

namespace ConsoleApp4.Providers
{

    /// <summary>
    /// Implementaton for Provider
    /// </summary>
    public interface IBaseService
    {
        /// <summary>
        /// GetProducts
        /// </summary>
        /// <returns> <see cref="IEnumerable"/> </returns>
        public IEnumerable<IProducts> GetProducts();
    }
}
