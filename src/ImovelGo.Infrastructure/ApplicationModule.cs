using Autofac;
using AutoMapper;
using ImovelGo.Application;

namespace ImovelGo.Infrastructure
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //
            // Register all Types in MyWallet.Application
            builder.RegisterAssemblyTypes(typeof(ApplicationException).Assembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
