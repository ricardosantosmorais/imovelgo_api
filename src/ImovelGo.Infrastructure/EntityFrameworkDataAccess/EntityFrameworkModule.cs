using System;
using Autofac;
using Microsoft.EntityFrameworkCore;

namespace ImovelGo.Infrastructure.EntityFrameworkDataAccess
{
    public class EntityFrameworkModule : Autofac.Module
    {
        public string ConnectionString { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DbContext>();
            optionsBuilder.UseMySql(ConnectionString);
            optionsBuilder.EnableSensitiveDataLogging(true);

            builder.RegisterType<ImovelGoContext>()
                .WithParameter(new TypedParameter(typeof(DbContextOptions), optionsBuilder.Options))
                .InstancePerLifetimeScope();

            var context = new ImovelGoContext(optionsBuilder.Options);
            context.Database.EnsureCreated();

            //
            // Register all Types in MongoDataAccess namespace
            builder.RegisterAssemblyTypes(typeof(InfrastructureException).Assembly)
                .Where(type => type.Namespace.Contains("EntityFrameworkDataAccess"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterType<SqlConnectionFactory>()
                .As<ISqlConnectionFactory>()
                .WithParameter("connectionString", ConnectionString)
                .InstancePerLifetimeScope();
        }
    }
}
