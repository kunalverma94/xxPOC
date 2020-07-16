using ConsoleApp4.DTO.BaseClient;
using ConsoleApp4.DTO.SoftwareAdvice;
using System.Collections.Generic;

namespace ConsoleApp4.Models.DTO.Adapter
{
    public class SoftwareAdviceAadpter : BaseClient, IClient
    {
        private readonly ISoftwareAdvice _provider;
        public SoftwareAdviceAadpter(ISoftwareAdvice softwareAdviceProvider)
        {
            _provider = softwareAdviceProvider;

        }
        public override string Name
        {
            get
            {
                return _provider.Title;
            }
        }

        public override string Twitter
        {
            get
            {
                return _provider.Twitter;
            }
        }
        public override IEnumerable<string> Categories
        {
            get
            {
                return _provider.Categories;
            }
        }

    }
}
