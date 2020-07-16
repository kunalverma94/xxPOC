using ConsoleApp4.DataProvider;
using ConsoleApp4.DTO.BaseClient;
using ConsoleApp4.Models.DTO.Request;
using ConsoleApp4.Providerrs;
using System;
using System.Collections.Generic;

namespace ConsoleApp4.Providers
{
    /// <inheritdoc/>
    public abstract class BaseProvider : IProductProvider
    {
        #region Properties
        public IRequestContext requestContext { get; set; }
        protected ISerializer serializable;
        protected IReader reader; 
        #endregion

        public BaseProvider(IRequestContext requestContext)
        {
            this.requestContext = requestContext;
        }

        #region SomeMeaning full name If I had time

        /// <inheritdoc/>
        public IProductProvider SetReader(ReadSource reader)
        {
            this.reader = ReaderFactory.GetReader(reader);
            return this;
        }

        /// <inheritdoc/>
        public IProductProvider SetSerializer(FileType serializable)
        {
            this.serializable = SerializerFactory.GetSerializer(serializable);
            return this;
        }

        /// <inheritdoc/>
        public IProductProvider LoadDefaultSettings()
        {
            this.requestContext.FileType = this.requestContext.FileType == FileType.INVALID
                                            ? this.DefaultFileType() : this.requestContext.FileType;
            return this.SetReader(this.DefaultSource()).SetSerializer(this.requestContext.FileType);
        }
        #endregion

        #region Abstract

        /// <inheritdoc/>
        public virtual void StartImporting()
        {
            foreach (var item in this.GetClients())
            {
                Console.WriteLine(item.BeginImport());
            }
        }

        /// <inheritdoc/>
        public abstract ReadSource DefaultSource();

        /// <inheritdoc/>
        public abstract IEnumerable<IClient> GetClients();

        /// <inheritdoc/>
        public abstract FileType DefaultFileType(); 

        #endregion


    }
}
