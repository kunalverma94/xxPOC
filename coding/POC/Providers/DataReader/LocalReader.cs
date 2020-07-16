using System.IO;

namespace ConsoleApp4.DataProvider
{

    /// <inheritdoc/>
    public class LocalReader : IReader
    {
        /// <inheritdoc/>
        public string ReadData(string location) => File.ReadAllText(location);
    }
}