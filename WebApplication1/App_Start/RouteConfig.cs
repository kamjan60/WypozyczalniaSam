using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            //Dodanie wlasnego routa:
            //Sprawdzic Web.config -> znaczniki : system.webServer -> runAllManagedModulesForAllRequests="true"            
            routes.MapRoute(
               name: "StronyStatyczne",
               url: "stopka/{nazwa}",
               defaults: new { controller = "Home", action = "StronyStatyczne"}
           );
            // Nazwa kontrolera (w tym wypadku HomeController, nazwa metody akcji, tutaj: StronyStatyczne

            routes.MapRoute(
                name: "Trasa1",
                url: "info/{nazwa}",
                defaults: new { controller = "Home", action = "StronyStopka" }
            );    
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
