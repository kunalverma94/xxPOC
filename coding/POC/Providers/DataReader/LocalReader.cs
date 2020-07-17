using ConsoleApp4.Providerrs;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp4.DataProvider
{

    /// <inheritdoc/>
    public class LocalReader<T> : DataSourceReader<T>, IDataSourceReader<T> where T : class
    {
        public LocalReader(IConnection connectionPoint, IProductSerializer serializable) : base(connectionPoint, serializable)
        {

        }

        /// <inheritdoc/>
        public override IEnumerable<T> Read()
        {
            this._connectionPoint.ConnectionString = CrossOSFix(this._connectionPoint.ConnectionString);
            var data = File.ReadAllText(this._connectionPoint.ConnectionString);
            return this._serializable.GetObject<IEnumerable<T>>(data);
        }

        public override W Read<W>()
        {
            this._connectionPoint.ConnectionString = CrossOSFix(this._connectionPoint.ConnectionString);
            var data = File.ReadAllText(this._connectionPoint.ConnectionString);
            return this._serializable.GetObject<W>(data);
        }

        /// <summary>
        ///https://stackoverflow.com/questions/38428561/difference-between-forward-slash-and-backslash-in-file-path
        //For C# code that works on both Unix and Windows
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        private string CrossOSFix(string location)
        {
            string _location = location;

            if (File.Exists(location))
            {
                _location = location;
            }
            else
            {
                _location = Path.Join(Environment.CurrentDirectory, location);
            }

            return _location.Replace('/', Path.DirectorySeparatorChar).Replace('\\', Path.DirectorySeparatorChar);
        }
    }
}