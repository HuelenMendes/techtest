using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using TechTest01.Services;
using TechTest01.Services.Catalog;

namespace TechTest01.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
           container.RegisterType<IProductService, ProductService>();            

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}