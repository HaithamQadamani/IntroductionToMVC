using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IntroductionToMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.IgnoreRoute("{resource}.txt/{*pathInfo}");
            routes.IgnoreRoute("Computer/Display");


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //url: "{action}/{controller}/{id}",
                //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                defaults: new { controller = "Computer", action = "Display", id = UrlParameter.Optional }
            );
        }
    }
}
