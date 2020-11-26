using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAtividadeEntrevista
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Fechar",
                "Fechar",
                new { controller = "Cliente", action = "Forms", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "Beneficiario",
                "Beneficiario",
                new { controller = "Beneficiario", action = "Incluir", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
