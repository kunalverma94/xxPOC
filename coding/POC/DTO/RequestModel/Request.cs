using System;

namespace ConsoleApp4.Models.DTO.Request
{
    /// <inheritdoc/>
    public class Request : IRequest
    {
        #region Properties
        public string FilePath { get; set; }

        /// <inheritdoc/>
        public Client Clients { get; set; }

        #endregion

        /// <inheritdoc/>
        public static IRequest GetRequest(string[] args)
        {
            Request requestContext = new Request();

            try
            {
                if (args.Length < 2)
                {
                    throw new ArgumentException("Missing Some Arguments.");
                }

                requestContext.Clients = Enum.Parse<Client>(args[0], true);
                requestContext.FilePath = args[1];
            }
            catch (Exception)
            {
                requestContext = null;
            }

            return requestContext;
        }

        public override string ToString()
        {
            return $"{new string('-', 25)} {Environment.NewLine} #Run Info: {Clients} File: {FilePath}{Environment.NewLine} {new string('-', 25)} ";
        }
    }
}
