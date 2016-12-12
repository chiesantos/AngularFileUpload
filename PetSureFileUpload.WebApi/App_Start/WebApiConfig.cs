using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace PetSureFileUpload.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{action}/{id}", new { id = RouteParameter.Optional }, null);
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
