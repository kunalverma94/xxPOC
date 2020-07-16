using System.Collections.Generic;

namespace ConsoleApp4.DTO.BaseClient
{
    public interface IClient
    {
        public string Name { get; }
        public string Twitter { get; }
        public IEnumerable<string> Categories { get; }
        public string BeginImport();
    }
}
