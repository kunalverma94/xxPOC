using ConsoleApp4.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp4.DTO.BaseClient
{
    ///<inheritdoc/>
    public class BaseProduct : IProducts
    {
        const string IMPORT_TEMPLATE = AppSetting.TEMPLATE;

        ///<inheritdoc/>
        public virtual string Template { get; protected set; } = IMPORT_TEMPLATE;

        ///<inheritdoc/>
        public virtual string Name { get; }

        ///<inheritdoc/>
        public virtual string Twitter { get; }

        ///<inheritdoc/>
        public virtual IEnumerable<string> Categories { get; }

        ///<inheritdoc/>
        public virtual string BeginImport()
        {
            string importing;

            try
            {
                var _categories = string.Join(AppSetting.SEPERATOR, Categories);
                var _twitter = Twitter == null || string.IsNullOrEmpty(Twitter) ? "Not Available" :
                 (Twitter.StartsWith(AppSetting.TWITTERCHAR) ? Twitter : AppSetting.TWITTERCHAR + Twitter);

                importing = String.Format(Template, Name, _categories, _twitter);

                Console.WriteLine(importing);
            }
            catch (Exception)
            {

                importing = "NA";
            }
            return importing;
        }
    }
}
