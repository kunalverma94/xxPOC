using System.Net;

namespace ConsoleApp4.DataProvider
{
    /// <inheritdoc/>
    public class WebReader : IReader
    {
        /// <inheritdoc/>
        public string Read(string location) => new WebClient().DownloadString(location);
    }
}