using Autofac;
using Autofac.Integration.WebApi;
using HomeCinema.Api.App_Start;
using HomeCinema.Data;
using HomeCinema.Data.BaseRepository;
using HomeCinema.Service;
using HomeCinema.Service.Abstract;
using System;
using System.Data.Entity;
using System.Reflection;
using System.Web.Http;

namespace HomeCinema.Api.App_Start
{
    public class AutofacWebApiConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<HomeCinemaContext>().AsSelf().InstancePerRequest();

            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>)).InstancePerRequest();
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .AsClosedTypesOf(typeof(IBaseRepository<>))
                .AsImplementedInterfaces();

            builder.RegisterType<EncryptionService>().As<IEncryptionService>().InstancePerRequest();
            builder.RegisterType<MembershipService>().As<IMembershipService>().InstancePerRequest();

            Container = builder.Build();
            return Container;
        }

    }
}