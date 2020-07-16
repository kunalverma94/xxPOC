using System;
using System.IO;

namespace ConsoleApp4.DataProvider
{

    /// <inheritdoc/>
    public class LocalReader : IReader
    {
        /// <inheritdoc/>
        public string Read(string location)
        {
            location = CrossOSFix(location);
            return File.ReadAllText(location);
        }

        /// <summary>
        ///https://stackoverflow.com/questions/38428561/difference-between-forward-slash-and-backslash-in-file-path
        //For C# code that works on both Unix and Windows
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        private string CrossOSFix(string location)
        {
            return Path.Join(Environment.CurrentDirectory, location)
                                        .Replace('/', Path.DirectorySeparatorChar)
                                        .Replace('\\', Path.DirectorySeparatorChar);
        }
    }
}