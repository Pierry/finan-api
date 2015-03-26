using System.Web.Http;
using Finan.Domain.Contracts.Business;
using Finan.Domain.Contracts.Repositories;
using Finan.Repository.Repositories;
using Finan.Services.Services;
using Finan.WebApi.Resolver;
using Microsoft.Practices.Unity;

namespace Finan.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<IUserService, UserService>(new HierarchicalLifetimeManager());
            container.RegisterType<ILocalService, LocalService>(new HierarchicalLifetimeManager());
            container.RegisterType<ITypeService, TypeService>(new HierarchicalLifetimeManager());
            container.RegisterType<IItemService, ItemService>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ILocalRepository, LocalRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ITypeRepository, TypeRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IItemRepository, ItemRepository>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new {id = RouteParameter.Optional}
                );
        }
    }
}