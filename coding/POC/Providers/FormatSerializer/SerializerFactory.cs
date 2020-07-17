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
        public static IProductSerializer GetSerializer(FileFormats type)
        {
            switch (type)
            {
                case FileFormats.YAML:
                return new YAMLSerializer();
                case FileFormats.JSON:
                return new JSONSerializer();
                case FileFormats.CSV:
                default:
                return null;
            }
        }
    }

}