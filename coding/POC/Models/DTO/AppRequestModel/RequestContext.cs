using System;
using System.IO;

namespace ConsoleApp4.Models.DTO.Request
{
    /// <inheritdoc/>
    public class RequestContext : IRequestContext
    {

        #region Properties

        /// <inheritdoc/>
        public Client Clients { get; set; }

        // To support future args Flags
        //public ReadSource Source { get; set; }

        /// <inheritdoc/>
        public FileType FileType { get; set; }

        /// <inheritdoc/>
        public string ResourcePath { get; set; }

        /// <inheritdoc/>
        public string ResourceName { get; set; }

        #endregion

        /// <inheritdoc/>
        public static IRequestContext GetRequest(string[] args)
        {
            RequestContext requestContext = new RequestContext();

            try
            {
                if (args.Length < 2)
                {
                    throw null;
                }
                Initilise(args, requestContext);

                //Intetionally moved this though <:>
                if (!File.Exists(args[1]))
                {
                    throw null;
                }
            }
            catch (Exception)
            {

                requestContext = null;
            }
            return requestContext;
        }

        public override string ToString()
        {
            return $"{new  string('-',25)} {Environment.NewLine} #Run Info: {Clients} File: {ResourcePath}{Environment.NewLine} {new string('-', 25)} " ;
        }

        /// <inheritdoc/>
        private static void Initilise(string[] args, RequestContext requestContext)
        {
            //https://stackoverflow.com/questions/38428561/difference-between-forward-slash-and-backslash-in-file-path
            //For C# code that works on both Unix and Windows

            requestContext.ResourceName = args[1];

            requestContext.ResourcePath = Path.Join(Environment.CurrentDirectory, args[1])
                                        .Replace('/', Path.DirectorySeparatorChar)
                                        .Replace('\\', Path.DirectorySeparatorChar);
            requestContext.Clients = Enum.Parse<Client>(args[0], true);
            requestContext.FileType = Enum.Parse<FileType>(Path.GetExtension(requestContext.ResourceName).Substring(1), true);

            Console.WriteLine(requestContext.ToString());

        }
    }
}
