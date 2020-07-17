using ConsoleApp4;
using ConsoleApp4.DataProvider;

namespace poc.AppFactory.ClientConfig
{
    public class SoftwareAdviceDefaultConfig : IDefaultConfig
    {
        public Client Client { get; set; } = Client.SoftwareAdvice;
        public DataSource ReadSource { get; set; } = DataSource.LOCAL;
        public DataFormat FileFormats { get; set; } = DataFormat.JSON;
    }
}
