namespace ConsoleApp4.Providerrs
{
    /// <summary>
    /// Yep thats the benifit of interface ,,,,,
    /// </summary>
    public interface IProductSerializer
    {
        /// <summary>
        /// Get genetric obj
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        T GetObject<T>(string data);
    }

}