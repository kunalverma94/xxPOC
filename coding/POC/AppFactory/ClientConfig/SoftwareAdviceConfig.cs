using ConsoleApp4;
using ConsoleApp4.DataProvider;

namespace poc.AppFactory.ClientConfig
{
    public class SoftwareAdviceConfig : IBaseConfig
    {
        public Client Client { get; set; } = Client.SoftwareAdvice;
        public ReadSource ReadSource { get; set; } = ReadSource.LOCAL;
        public FileFormats FileFormats { get; set; } = FileFormats.JSON;
    }
}
