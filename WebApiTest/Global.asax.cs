﻿using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Newtonsoft.Json.Serialization;

namespace WebApiTest
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            var config = GlobalConfiguration.Configuration;

            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
                new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;
        }
    }
}