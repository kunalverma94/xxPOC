namespace ConsoleApp4.DataProvider
{
    public class Connection : IConnection
    {
        public string ConnectionString { get; set; }

        public Connection(string Connection)
        {
            this.ConnectionString = Connection;
        }

    }
}