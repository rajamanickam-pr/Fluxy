using System.Data.Entity;
using Autofac;
using Fluxy.Data;
using Fluxy.Repositories.Common;
using Autofac.Integration.Mvc;

namespace Fluxy.Web.Modules
{
    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());
            builder.RegisterType(typeof(FluxyContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();
            
        }
    }
}