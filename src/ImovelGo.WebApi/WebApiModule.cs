using Autofac;

namespace ImovelGo.WebApi
{
    public class WebApiModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //
            // Register all Types in MyWallet.WebApi
            builder.RegisterAssemblyTypes(typeof(Startup).Assembly)
                .AsSelf()
                .InstancePerLifetimeScope();
        }
    }
}
