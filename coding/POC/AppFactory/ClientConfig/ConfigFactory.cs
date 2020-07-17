using ConsoleApp4;
using System;

namespace poc.AppFactory.ClientConfig
{
    public static class ConfigFactory
    {
        public static IBaseConfig GetConfig(Client client)
        {
            switch (client)
            {
                case Client.Capterra:
                return new CapteeraConfig();
                case Client.SoftwareAdvice:
                return new SoftwareAdviceConfig();
                default:
                case Client.INVALID:
                throw new NotImplementedException();
            }
        }
    }
}
