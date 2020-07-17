using ConsoleApp4;
using ConsoleApp4.DataProvider;

namespace poc.AppFactory.ClientConfig
{
    public interface IDefaultConfig
    {
        public Client Client { get; set; }
        public DataSource ReadSource { get; set; }
        public DataFormat FileFormats { get; set; }
    }
}
