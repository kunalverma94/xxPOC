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
        public static IProductSerializer GetSerializer(DataFormat type)
        {
            switch (type)
            {
                case DataFormat.YAML:
                return new YAMLSerializer();
                case DataFormat.JSON:
                return new JSONSerializer();
                case DataFormat.CSV:
                default:
                return null;
            }
        }
    }

}