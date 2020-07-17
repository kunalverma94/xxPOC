using ConsoleApp4.Providerrs;
using System.Collections.Generic;

namespace ConsoleApp4.DataProvider
{
    public abstract class DataSourceReader<T> : IDataSourceReader<T> where T : class
    {
        protected IProductSerializer _serializable;
        protected IConnection _connectionPoint;

        public DataSourceReader(IConnection connectionPoint, IProductSerializer serializable)
        {
            _serializable = serializable;
            _connectionPoint = connectionPoint;
        }

        public abstract IEnumerable<T> Read();

        public abstract W Read<W>();
    }
}


