using ConsoleApp4;
using System;

namespace poc.AppFactory.ClientConfig
{
    public static class DefaultConfigFactory
    {
        public static IDefaultConfig GetDefaultConfig(Client client)
        {
            switch (client)
            {
                case Client.Capterra:
                return new CapteeraDefaultConfig();
                case Client.SoftwareAdvice:
                return new SoftwareAdviceDefaultConfig();
                default:
                case Client.INVALID:
                throw new NotImplementedException();
            }
        }
    }
}
