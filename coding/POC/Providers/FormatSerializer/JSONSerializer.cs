using Newtonsoft.Json.Linq;
using System.Text.Json;
namespace ConsoleApp4.Providerrs
{
    /// <inheritdoc/>
    public class JSONSerializer : IProductSerializer
    {

        private readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        /// <inheritdoc/>
        public T GetObject<T>(string data)
        {

            return JObject.Parse(data).ToObject<T>();

        }
    }

}