using ConsoleApp4.DataProvider;
using ConsoleApp4.DTO.BaseClient;
using ConsoleApp4.Models.DTO.Request;
using System.Collections.Generic;

namespace ConsoleApp4.Providers
{

    /// <summary>
    /// Implementaton for Provider
    /// </summary>
    public interface IProductProvider
    {
        /// <summary>
        /// Get default  <see cref="ReadSource"/> as per the Client
        /// </summary>
        /// <returns></returns>
        public ReadSource DefaultSource();

        /// <summary>
        /// Load default setting
        /// </summary>
        /// <returns></returns>
        public IProductProvider LoadDefaultSettings();

        /// <summary>
        /// Get Default
        /// </summary>
        /// <returns></returns>
        public FileType DefaultFileType();

        /// <summary>
        /// context
        /// </summary>
        public IRequestContext requestContext { get; set; }

        /// <summary>
        /// Set Reader Returns <see cref="IProductProvider"/> Builder pattern
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public IProductProvider SetReader(ReadSource reader);

        /// <summary>
        /// Set SetSerializer Returns <see cref="IProductProvider"/> Builder pattern
        /// </summary>
        /// <param name="serializable"></param>
        /// <returns></returns>
        public IProductProvider SetSerializer(FileType serializable);

        /// <summary>
        /// GetClients
        /// </summary>
        /// <returns> <see cref="IEnumerable"/> </returns>
        public IEnumerable<IClient> GetClients();

        /// <summary>
        /// Staet import
        /// </summary>
        public void StartImporting();
    }
}
