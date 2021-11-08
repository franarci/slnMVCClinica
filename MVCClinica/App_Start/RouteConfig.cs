﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCClinica
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "GetByFullName",
                url: "{controller}/{action}/{nombre}/{apellido}",
                defaults: new { controller = "Medicos", action = "GetByFullName" }
                );


            routes.MapRoute(
                name: "GetBySpecialty",
                url: "{controller}/{action}/{especialidad}",
                defaults: new { controller = "Medicos", action= "SearchBySpecialty" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
