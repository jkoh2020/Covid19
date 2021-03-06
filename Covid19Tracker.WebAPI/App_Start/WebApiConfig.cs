﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Covid19Tracker.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
           // config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // create to use two different id in one controller. This is very important and useful.
            config.Routes.MapHttpRoute(
                name: "ControllerAndAction",
                routeTemplate: "api/{controller}/{countyId}/{stateId}"
                );

            //config.Routes.MapHttpRoute(
            //    name: "ControllerAndAction",
            //    routeTemplate: "api/{controller}/{stateId}/{secondStateId}"
            //    );

            //config.Routes.MapHttpRoute(
            //    name: "ControllerAndAction",
            //    routeTemplate: "api/{controller}/{countyId}/{secondCountyId}"
            //    );


        }
    }
}
