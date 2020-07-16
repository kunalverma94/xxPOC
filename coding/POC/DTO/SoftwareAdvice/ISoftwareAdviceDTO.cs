using System.Collections.Generic;

namespace ConsoleApp4.DTO.SoftwareAdvice
{
    public interface ISoftwareAdviceDTO
    {
        public IEnumerable<string> Categories { get; set; }
        public string Title { get; set; }
        public string Twitter { get; set; }
    }
}
