namespace ConsoleApp4.Models.DTO.Request
{
    /// <summary>
    /// App inpuut context
    /// </summary>
    public interface IRequestContext
    {
        /// <summary>
        /// clietn
        /// </summary>
        public Client Clients { get; set; }
        //   public ReadSource Source { get; set; }

        /// <summary>
        /// FileType
        /// </summary>
        public FileType FileType { get; set; }

        /// <summary>
        /// Location
        /// </summary>
        public string ResourcePath { get; set; }

        /// <summary>
        /// ResourceName
        /// </summary>
        public string ResourceName { get; set; }
    }
}