using ConsoleApp4.DTO.BaseClient;
using ConsoleApp4.DTO.SoftwareAdvice;
using System.Collections.Generic;

namespace ConsoleApp4.Models.DTO.Adapter
{
    /// <summary>
    /// Provide common IProducts implementaito and properties resolving Business capabilities 
    /// </summary>
    public class SoftwareAdvice : BaseProduct, IProducts
    {
        private readonly ISoftwareAdviceDTO _provider;
        public SoftwareAdvice(ISoftwareAdviceDTO softwareAdviceProvider)
        {
            _provider = softwareAdviceProvider;

        }

        ///<inheritdoc/>
        public override string Name
        {
            get
            {
                return _provider.Title;
            }
        }

        ///<inheritdoc/>
        public override string Twitter
        {
            get
            {
                return _provider.Twitter;
            }
        }

        ///<inheritdoc/>
        public override IEnumerable<string> Categories
        {
            get
            {
                return _provider.Categories;
            }
        }

    }
}
