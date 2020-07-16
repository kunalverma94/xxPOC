using ConsoleApp4.Models.DTO.Request;
using ConsoleApp4.Providerrs;
using System.Collections.Generic;

namespace ConsoleApp4.DataProvider
{
    public abstract class DataRepository<T> : IDataRepository<T>
    {
        protected IRequest request;
        protected IProductSerializer serializable;
        protected IReader reader;

        public DataRepository(IRequest request, IProductSerializer serializable, IReader reader)
        {
            this.request = request;
            this.SetSerializer(serializable);
            this.SetReader(reader);
        }
        public abstract IEnumerable<T> GetProducts();

        public IDataRepository<T> SetSerializer(IProductSerializer serializable)
        {
            this.serializable = serializable;
            return this;
        }

        public IDataRepository<T> SetReader(IReader reader)
        {
            this.reader = reader;
            return this;
        }
    }
}