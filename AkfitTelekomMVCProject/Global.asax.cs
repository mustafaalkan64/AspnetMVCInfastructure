using AktifTelekom.DAL;
using AktifTelekom.DAL.GenericRepository;
using AktifTelekom.DAL.Uow;
using AktifTelekomMVCProject.Business.Services;
using AktifTelekomMVCProject.Domain;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Compilation;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AkfitTelekomMVCProject
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            


            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            var configuration = GlobalConfiguration.Configuration;
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly()); //Register MVC Controllers
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()); //Register WebApi Controllers

            builder.RegisterType<AktifTelekomDbContext>()
                   .As<DbContext>()
                   .InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>()
                   .As<IUnitOfWork>()
                   .InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(GenericRepository<>))
                   .As(typeof(IGenericRepository<>))
                   .InstancePerLifetimeScope();


            builder.RegisterAssemblyTypes(Assembly.Load("AktifTelekomMVCProject.Business"))
                    .Where(t => t.Name.EndsWith("Service"))
                    .AsImplementedInterfaces()
                    .AsSelf()
                    .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(Assembly.Load("AktifTelekomMVCProject.DAL"))
                    .AsImplementedInterfaces()
                    .AsSelf()
                    .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(IUsersService).Assembly)
                    .Where(t => t.Name.EndsWith("Service"))
                    .AsImplementedInterfaces()
                    .AsSelf()
                    .InstancePerLifetimeScope();

            //var assemblies = BuildManager.GetReferencedAssemblies().Cast<Assembly>().Where(x => x.FullName.Contains("AktifTelekomMVCProject")).ToArray();
            //builder.RegisterAssemblyTypes(assemblies)
            //    .AsImplementedInterfaces()
            //    .AsSelf()
            //    .InstancePerRequest();

            builder.RegisterType<UsersService>().As<IUsersService>().InstancePerLifetimeScope();


            //IContainer container = builder.Build();
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            var container = builder.Build();

            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            configuration.DependencyResolver =
                 new AutofacWebApiDependencyResolver(container);
        }
    }
}
