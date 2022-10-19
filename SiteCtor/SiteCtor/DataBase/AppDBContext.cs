using Microsoft.EntityFrameworkCore;
using SiteCtor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteCtor.DataBase
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<FirstSiteModel> FirstSiteModels { get; set; }
        public DbSet<SecondSiteModel> SecondSiteModels { get; set; }
    }
}
