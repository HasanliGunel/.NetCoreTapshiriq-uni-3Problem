using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tapshiriq_uni_3.Database
{
    public class CityContext:DbContext
    {
        public CityContext(DbContextOptions<CityContext>context) : base(context) { }
        public DbSet<City> Cities { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<CityUniversity> CityUniversities { get; set; }
    }
}
