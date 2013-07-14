using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MoneyRemittance.web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Main", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Send",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "SendMoney", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ContactUs",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "ContactUs", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Disclaimer",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Disclaimer", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}