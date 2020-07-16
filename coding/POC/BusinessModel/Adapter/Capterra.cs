using ConsoleApp4.DTO.BaseClient;
using ConsoleApp4.DTO.Capterra;
using System.Collections.Generic;

namespace ConsoleApp4.Models.DTO.Adapter
{
    /// <summary>
    /// Provide common IProducts implementaiton and properties resolving Business capabilities 
    /// </summary>
    public class Capterra : BaseProduct, IProducts
    {
        private readonly ICapterraDTO _provider;
        private const string seperator = AppSetting.SEPERATOR;

        ///<inheritdoc/>
        public override string Name
        {
            get
            {
                return _provider.name;
            }
        }

        ///<inheritdoc/>
        public override string Twitter
        {
            get
            {
                return _provider.twitter;
            }
        }

        ///<inheritdoc/>
        public override IEnumerable<string> Categories
        {
            get
            {
                return _provider.tags?.Split(seperator);
            }
        }

        ///<inheritdoc/>
        public Capterra(ICapterraDTO provider)
        {
            _provider = provider;

        }

    }
}
