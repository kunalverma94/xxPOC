using ConsoleApp4;
using ConsoleApp4.DataProvider;

namespace poc.AppFactory.ClientConfig
{
    public class CapteeraConfig : IBaseConfig
    {
        public Client Client { get; set; } = Client.Capterra;
        public ReadSource ReadSource { get; set; } = ReadSource.LOCAL;
        public FileFormats FileFormats { get; set; } = FileFormats.YAML;
    }
}
