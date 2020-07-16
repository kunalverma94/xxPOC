namespace ConsoleApp4.DataProvider
{
    /// <summary>
    /// Reader data instance
    /// </summary>
    public interface IReader
    {

        /// <summary>
        /// Read data from given location
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        string ReadData(string location);
    }
}