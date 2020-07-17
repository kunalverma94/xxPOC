using ConsoleApp4;
using ConsoleApp4.DataProvider;

namespace poc.AppFactory.ClientConfig
{
    public class CapteeraDefaultConfig : IDefaultConfig
    {
        public Client Client { get; set; } = Client.Capterra;
        public DataSource ReadSource { get; set; } = DataSource.LOCAL;
        public DataFormat FileFormats { get; set; } = DataFormat.YAML;
    }
}
