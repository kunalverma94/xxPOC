using System;

namespace ConsoleApp4.Models
{
    /// <summary>
    /// Appsettng 
    /// </summary>
    public static class AppSetting
    {
        /// <summary>
        /// Seperator char
        /// </summary>
        public const string SEPERATOR = ",";

        /// <summary>
        /// Seperator char
        /// </summary>
        public const string TWITTERCHAR = "@";

        /// <summary>
        /// importing templdate
        /// </summary>
        public const string TEMPLATE = "importing: Name: \"{0}\";  Categories: {1}; Twitter:{2}";

        /// <summary>
        /// Help text ???
        /// </summary>
        public static string HELPTEXT = @$"Please check the CLI syntax:   poc <SITE> <PRODUCT_CATALOG> 
            <SITE> := {string.Join(",", Enum.GetNames(typeof(Client)))}
            <PRODUCT_CATALOG> :=Valid file Location" + Environment.NewLine +
            "Incase Of Absolute Path please provire with \" <Path To file > \" ";
    }
}
