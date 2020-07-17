using ConsoleApp4;
using ConsoleApp4.DataProvider;

namespace poc.AppFactory.ClientConfig
{
    public interface IBaseConfig
    {
        public Client Client { get; set; }
        public ReadSource ReadSource { get; set; }
        public FileFormats FileFormats { get; set; }
    }
}
