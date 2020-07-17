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
            IDefaultConfig config = DefaultConfigFactory.GetDefaultConfig(request.Clients);
            IUnityContainer container = GetContainer(request, config);

            switch (request.Clients)
            {
                case Client.Capterra:
                    baseService = GetCapterraService(container);
                break;
                case Client.SoftwareAdvice:
                    baseService = GetSoftwareAdService(container);
                break;
                case Client.INVALID:
                default:
                throw new NotImplementedException();
            }

            return baseService;
        }

        #region Helper methods
        private static IBaseService GetSoftwareAdService(IUnityContainer container)
        {
            IBaseService baseService;
            container.RegisterType<IDataRepository<SoftwareAdviceDTO>, SoftwareAdviceDataRepository>()
                .RegisterType<IDataSourceReader<SoftwareAdviceDTO>, LocalReader<SoftwareAdviceDTO>>();
            baseService = container.Resolve<SoftwareAdviceService>();
            return baseService;
        }

        private static IBaseService GetCapterraService(IUnityContainer container)
        {
            IBaseService baseService;
            //Data Layer
            container.RegisterType<IDataRepository<CapterraDTO>, CapteerDataRepository>();
            //InputOutput Layer
            container.RegisterType<IDataSourceReader<CapterraDTO>, LocalReader<CapterraDTO>>();
            //service layer
            baseService = container.Resolve<CapterraService>();
            return baseService;
        }

        private static IUnityContainer GetContainer(IRequest request, IDefaultConfig config)
        {
            IUnityContainer container = new UnityContainer();
            container
            .RegisterInstance<IProductSerializer>(SerializerFactory.GetSerializer(config.FileFormats))
            .RegisterInstance<IConnection>(new Connection(request.FilePath));
            return container;
        }
        #endregion
    }
}

