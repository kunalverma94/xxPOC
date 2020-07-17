using System.Collections.Generic;

namespace ConsoleApp4.DataProvider
{

    /// <summary>
    /// DataRepository instance
    /// </summary>
    public interface IDataRepository<T>
    {
        /// <summary>
        /// Get List of Products
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetProducts();
    }
}