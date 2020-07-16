using ConsoleApp4.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp4.DTO.BaseClient
{
    public class BaseClient : IClient
    {
        const string IMPORT_TEMPLATE = AppSetting.TEMPLATE;
        public virtual string Template { get; protected set; } = IMPORT_TEMPLATE;
        public virtual string Name { get; }
        public virtual string Twitter { get; }
        public virtual IEnumerable<string> Categories { get; }
        public string BeginImport()
        {
            string importing;

            try
            {
                var _categories = string.Join(AppSetting.SEPERATOR, Categories);
                var _twitter = Twitter == null || string.IsNullOrEmpty(Twitter) ? "Not Available" : 
                 (Twitter.StartsWith(AppSetting.TWITTERCHAR) ? Twitter : AppSetting.TWITTERCHAR + Twitter);

                importing = String.Format(Template, Name, _categories, _twitter);
            }
            catch (Exception)
            {

                importing = "NA";
            }
            return importing;
        }
    }
}
