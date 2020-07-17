using ConsoleApp4.Providerrs;
using System.Collections.Generic;

namespace ConsoleApp4.DataProvider
{
    public class MongoDBReader<T> : DataSourceReader<T>, IDataSourceReader<T> where T : class
    {

        public MongoDBReader(IConnection connectionPoint) : base(connectionPoint, new JSONSerializer())
        {

        }

        public override IEnumerable<T> Read()
        {
            throw new System.NotImplementedException();
        }

        public override W Read<W>()
        {
            throw new System.NotImplementedException();
        }
    }
}