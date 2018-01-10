using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class13Demo.Data
{
    public class CatFarmDbContext : DbContext
    {
        public CatFarmDbContext(DbContextOptions<CatFarmDbContext> options) : base(options)
        {

        }

        public DbSet<Models.CatFarm> CatFarm { get; set; }
    }
}
