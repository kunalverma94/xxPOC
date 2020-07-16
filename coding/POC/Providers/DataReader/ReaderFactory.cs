namespace ConsoleApp4.DataProvider
{

    /// <summary>
    /// ReaderFactory patern
    /// </summary>
    public static class ReaderFactory
    {
        /// <summary>
        /// ReaderFactory method
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IReader GetReader(ReadSource source)
        {

            switch (source)
            {
                case ReadSource.LOCAL:
                    return new LocalReader();
                case ReadSource.WEB:
                    return new WebReader();
                case ReadSource.NETWORK:
                case ReadSource.OTHER:
                default:
                    return null;
            }
        }
    }
}