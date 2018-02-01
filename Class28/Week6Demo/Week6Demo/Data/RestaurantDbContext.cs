using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week6Demo.Models;

namespace Week6Demo.Data
{
    public class RestaurantDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurant { get; set; }

        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
        {
            this.EnsureSeedData();
        }
    }
}
