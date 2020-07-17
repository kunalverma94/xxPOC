using ConsoleApp4.DataProvider;
using ConsoleApp4.DTO.Capterra;
using ConsoleApp4.DTO.SoftwareAdvice;
using ConsoleApp4.Models.DTO.Request;
using ConsoleApp4.Providerrs;
using ConsoleApp4.Providers;
using poc.AppFactory.ClientConfig;
using System;
using Unity;

namespace ConsoleApp4
{
    /// <summary>
    /// AppFactory for configuring and initiiliizng Initials
    /// </summary>
    public static class AppFactory
    {
        public static IBaseService AppFactoryInstance(IRequest request)
        {
            IBaseService baseService = null;
            IBaseConfig config = ConfigFactory.GetConfig(request.Clients);

            IUnityContainer container = new UnityContainer();
            container.RegisterInstance<IRequest>(request)
            .RegisterInstance<IReader>(ReaderFactory.GetReader(config.ReadSource))
            .RegisterInstance<IProductSerializer>(SerializerFactory.GetSerializer(config.FileFormats));

            switch (request.Clients)
            {
                case Client.Capterra:

                container.RegisterType<IDataRepository<ICapterraDTO>, CapteerDataRepository>();
                baseService = container.Resolve<CapterraService>();
                break;
                case Client.SoftwareAdvice:
                container.RegisterType<IDataRepository<ISoftwareAdviceDTO>, SoftwareAdviceDataRepository>();
                baseService = container.Resolve<SoftwareAdviceService>();
                break;
                case Client.INVALID:
                default:
                throw new NotImplementedException();
            }
            return baseService;
        }
    }
}

