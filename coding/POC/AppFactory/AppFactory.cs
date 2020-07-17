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

            IUnityContainer container = GetContainer(request, config);
            switch (request.Clients)
            {
                case Client.Capterra:

                //Data Layer
                container.RegisterType<IDataRepository<CapterraDTO>, CapteerDataRepository>();
                //InputOutput Layer
                container.RegisterType<IDataSourceReader<CapterraDTO>, LocalReader<CapterraDTO>>();

                baseService = container.Resolve<CapterraService>();
                break;
                case Client.SoftwareAdvice:
                container.RegisterType<IDataRepository<SoftwareAdviceDTO>, SoftwareAdviceDataRepository>()
                .RegisterType<IDataSourceReader<SoftwareAdviceDTO>, LocalReader<SoftwareAdviceDTO>>();
                baseService = container.Resolve<SoftwareAdviceService>();
                break;
                case Client.INVALID:
                default:
                throw new NotImplementedException();
            }

            return baseService;
        }

        private static IUnityContainer GetContainer(IRequest request, IBaseConfig config)
        {
            IUnityContainer container = new UnityContainer();
            container
            .RegisterInstance<IProductSerializer>(SerializerFactory.GetSerializer(config.FileFormats))
            .RegisterInstance<IConnection>(new Connection(request.FilePath));
            return container;
        }
    }
}

