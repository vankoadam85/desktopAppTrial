using partnertarServer.Data;
using partnertarServer.Repositories;
using partnertarServer.Repositories.Interfaces;
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
            container.RegisterType<IPartnerRepository, PartnerRepository>();
            container.RegisterType<PartnertarContext>();

            config.DependencyResolver = new UnityResolver(container);

            config.MapHttpAttributeRoutes();
        }
    }
}