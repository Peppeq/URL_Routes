using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;
using UrlsAndRoutes.Infrastructure;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //Route myRoute = new Route("{controller}/{action}", new MvcRouteHandler());

            //routes.Add("MyRoute", myRoute);

            routes.MapMvcAttributeRoutes();

            routes.MapRoute("NewRoute", "App/Do{action}",
            new { controller = "Home" });

            routes.MapRoute("MyRoute", "{controller}/{action}/{id}",
            new
            {
                controller = "Home",
                action = "Index",
                id = UrlParameter.Optional
            });

            //routes.MapRoute("ChromeRoute", "{*catchall}",
            //    new { controller = "Home", action = "Index" },
            //    new { customConstraint = new UserAgentConstraint("Chrome") },
            //    new[] { "UrlsAndRoutes.AdditionalControllers" });

            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
            //new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //new { controller = "^H.*", action = "^Index$|^About$", httpMethod = new HttpMethodConstraint("GET", "POST"),
            //   id = new CompoundRouteConstraint(new IRouteConstraint[] {
            //        new AlphaRouteConstraint(),
            //        new MinLengthRouteConstraint(6)
            //        })
            //},
            //new[] { "URLsAndRoutes.Controllers" });


            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
