using ConsoleApp4.DataProvider;
using ConsoleApp4.DTO.Capterra;
using ConsoleApp4.DTO.SoftwareAdvice;
using ConsoleApp4.Models.DTO.Request;
using ConsoleApp4.Providerrs;
using ConsoleApp4.Providers;
using System;
using Unity;

namespace ConsoleApp4
{
    public static class AppFactory
    {
        public static IBaseService AppFactoryInstance(IRequest request)
        {
            IBaseService baseService = null;
            
            IUnityContainer container = new UnityContainer();
            container.RegisterInstance<IRequest>(request)
            .RegisterInstance<IReader>(new LocalReader());


            switch (request.Clients)
            {
                case Client.Capterra:
                container.RegisterType<IDataRepository<ICapterraDTO>, CapteerDataRepository>()
                .RegisterInstance<IProductSerializer>(SerializerFactory.GetSerializer(FileType.YAML));
                baseService = container.Resolve<CapterraService>();
                break;
                case Client.SoftwareAdvice:
                container.RegisterType<IDataRepository<ISoftwareAdviceDTO>, SoftwareAdviceDataRepository>()
                .RegisterInstance<IProductSerializer>(SerializerFactory.GetSerializer(FileType.JSON));
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

