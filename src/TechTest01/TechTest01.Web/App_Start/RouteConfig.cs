using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TechTest01.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               "Index",
               "Product/{slug}",
               new { controller = "Product", action = "Index" }
            );

            routes.MapRoute(
                  "AngApp",
                  "Angular",
                  new { controller = "App", action = "Index" }
               );

            routes.MapRoute(
            "AngPrdList",
              "Angular/Products",
              new { controller = "List", action = "Index" }
           );

            routes.MapRoute(
            "AngPrdDetail",
              "Angular/Product",
              new { controller = "App", action = "ProductDetail" }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
