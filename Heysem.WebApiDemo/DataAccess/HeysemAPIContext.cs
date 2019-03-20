using Heysem.WebApiDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heysem.WebApiDemo.DataAccess
{
    public class HeysemAPIContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-G0UC2RP\SQLEXPRESS;Database=HeysemWebApi;Trusted_Connection=true");
        }

      public  DbSet<Country> Countries { get; set; }
        public DbSet<CountryDestinations> CountryDestinations { get; set; }
        public DbSet<Destinations> Destinations { get; set; }
    }
}
