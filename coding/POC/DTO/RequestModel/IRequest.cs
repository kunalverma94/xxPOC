namespace ConsoleApp4.Models.DTO.Request
{
    /// <summary>
    /// App inpuut context
    /// </summary>
    public interface IRequest
    {
        /// <summary>
        /// Client
        /// </summary>
        public Client Clients { get; set; }

        /// <summary>
        /// Location
        /// </summary>
        public string FilePath { get; set; }

    }
}