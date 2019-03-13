using partnertarServer.Services;
using partnertarServer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Unity;

namespace partnertarServer.Configurations
{
    public static class PartnertarServerConfiguration
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();
            container.RegisterType<IPartnersService, PartnersService>();

            config.DependencyResolver = new UnityResolver(container);

            config.MapHttpAttributeRoutes();
        }
    }
}