namespace ConsoleApp4.Providerrs
{
    /// <summary>
    /// Factory Pattern
    /// </summary>
    public static class SerializerFactory
    {
        /// <summary>
        /// methos
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IProductSerializer GetSerializer(FileType type)
        {
            switch (type)
            {
                case FileType.YAML:
                return new YAMLSerializer();
                case FileType.JSON:
                return new JSONSerializer();
                case FileType.CSV:
                default:
                return null;
            }
        }
    }

}