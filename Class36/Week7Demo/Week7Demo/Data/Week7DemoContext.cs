using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Week7Demo.Models
{
    public class Week7DemoContext : DbContext
    {
        public Week7DemoContext (DbContextOptions<Week7DemoContext> options)
            : base(options)
        {
        }

        public DbSet<Week7Demo.Models.Page> Page { get; set; }
    }
}
