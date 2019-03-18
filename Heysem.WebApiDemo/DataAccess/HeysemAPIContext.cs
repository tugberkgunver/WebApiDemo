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
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-2LS3T2B\SQLEXPRESS;Database=HeysemWebApi;Trusted_Connection=true");
        }

        DbSet<Country> Countries { get; set; }
    }
}
