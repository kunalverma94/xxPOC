using System.Collections.Generic;

namespace ConsoleApp4.DataProvider
{
    public interface IDataSourceReader<T> where T : class
    {
        IEnumerable<T> Read();
        W Read<W>();
    }
}


