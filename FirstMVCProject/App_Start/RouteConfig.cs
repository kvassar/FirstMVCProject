using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FirstMVCProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Employee", action = "Index" }
                );

            routes.MapRoute(
                name: "Catagory",
                url: "{Title}",
                defaults: new { controller = "Catagory", action = "Index", Title = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Detail",
                url: "{Title}/{DetailName}",
                defaults: new { controller = "Catagory", action = "Detail", Title = UrlParameter.Optional, @DetailName=UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
