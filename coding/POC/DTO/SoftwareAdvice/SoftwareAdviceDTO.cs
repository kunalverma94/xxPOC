using System.Collections.Generic;

namespace ConsoleApp4.DTO.SoftwareAdvice
{
    public class SoftwareAdviceDTO : ISoftwareAdviceDTO
    {
        public IEnumerable<string> Categories { get; set; }
        public string Title { get; set; }
        public string Twitter { get; set; }
    }
}
