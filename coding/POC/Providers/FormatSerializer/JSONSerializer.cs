using System.Text.Json;
namespace ConsoleApp4.Providerrs
{
    /// <inheritdoc/>
    public class JSONSerializer : ISerializer
    {

        private readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        /// <inheritdoc/>
        public T GetObject<T>(string data)
        {

            return JsonSerializer.Deserialize<T>(data, jsonSerializerOptions);

        }
    }

}