using partnertarServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace partnertarServer.Data
{
    public class PartnertarContext : DbContext
    {
        public PartnertarContext() : base ("name=PartnertarDBConnectionString")
        {
            Database.SetInitializer<PartnertarContext>(new DropCreateDatabaseIfModelChanges<PartnertarContext>());
        }

        public DbSet<Partner> Partners { get; set; }
    }
}