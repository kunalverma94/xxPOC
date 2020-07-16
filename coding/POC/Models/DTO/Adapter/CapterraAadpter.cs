using ConsoleApp4.DTO.BaseClient;
using ConsoleApp4.DTO.Capterra;
using System.Collections.Generic;

namespace ConsoleApp4.Models.DTO.Adapter
{
    public class CapterraAadpter : BaseClient, IClient
    {
        private readonly ICapterra _provider;
        private const string seperator = AppSetting.SEPERATOR;

        public override string Name
        {
            get
            {
                return _provider.name;
            }
        }
        public override string Twitter
        {
            get
            {
                return _provider.twitter;
            }
        }
        public override IEnumerable<string> Categories
        {
            get
            {
                return _provider.tags?.Split(seperator);
            }
        }
        public CapterraAadpter(ICapterra provider)
        {
            _provider = provider;

        }

    }
}
