using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MeanBookApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "ActionApi",
                routeTemplate: "api/{controller}/{action}/{id}/{extraParam}",
                defaults: new {
                    id = RouteParameter.Optional,
                    extraParam = RouteParameter.Optional
                }
            );
        }
    }
}
