using System.IO;
using YamlDotNet.Serialization;

namespace ConsoleApp4.Providerrs
{
    /// <inheritdoc/>
    public class YMLSerializer : ISerializer
    {
        /// <inheritdoc/>
        public T GetObject<T>(string data)
        {
            var deserializer = new Deserializer();
            return deserializer.Deserialize<T>(new StringReader(data));
        }
    }

}