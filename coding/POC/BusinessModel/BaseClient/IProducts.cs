using System.Collections.Generic;

namespace ConsoleApp4.DTO.BaseClient
{

    /// <summary>
    /// Common Product Business Object implementaiton
    /// </summary>
    public interface IProducts
    {
        /// <summary>
        /// Name ,Title field
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// twitter Hanhler
        /// </summary>
        public string Twitter { get; }

        /// <summary>
        /// category ,Tags
        /// </summary>
        public IEnumerable<string> Categories { get; }

        /// <summary>
        /// Import Procedure
        /// </summary>
        /// <returns></returns>
        public string BeginImport();
    }
}
