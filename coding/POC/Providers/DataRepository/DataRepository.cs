using System.Collections.Generic;

namespace ConsoleApp4.DataProvider
{
    public abstract class DataRepository<T> : IDataRepository<T> where T : class
    {
        protected IDataSourceReader<T> reader;

        public DataRepository(IDataSourceReader<T> reader)
        {
            this.reader = reader;
        }
        public abstract IEnumerable<T> GetProducts();
    }
}