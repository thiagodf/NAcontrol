﻿using Microsoft.Practices.Unity;
using NAControl.Business.Services;
using NAControl.Domain.Contracts.Repositories;
using NAControl.Domain.Contracts.Services;
using NAControl.Infraestructure.Repositories;
using NAControl.Injection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NAControl.Web.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();
            DependencyResolver.Resolve(container);
            container.RegisterType<IGroupRepository, GroupRepository>();
            container.RegisterType<IGroupService, GroupService>();
            
            container.Resolve<IGroupService>();

            // Remove o XML
            var formatters = config.Formatters;
            formatters.Remove(formatters.XmlFormatter);

            // Modifica a identação
            var jsonSettings = formatters.JsonFormatter.SerializerSettings;
            jsonSettings.Formatting = Formatting.Indented;
            jsonSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Modifica a serialização
            formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
