using System;

namespace ConsoleApp4.DataProvider
{
    public static class ReaderFactory
    {
        public static IReader GetReader(ReadSource source)
        {
            switch (source)
            {
                case ReadSource.LOCAL:
                return new LocalReader();
                case ReadSource.WEB:
                return new WebReader();
                case ReadSource.NETWORK:
                case ReadSource.Invalid:
                case ReadSource.OTHER:
                default:
                throw new NotImplementedException();
            }
        }
    }
}


