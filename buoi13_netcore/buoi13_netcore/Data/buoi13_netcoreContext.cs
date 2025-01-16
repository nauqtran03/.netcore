using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using buoi13_netcore.Models;

namespace buoi13_netcore.Data
{
    public class buoi13_netcoreContext : DbContext
    {
        public buoi13_netcoreContext (DbContextOptions<buoi13_netcoreContext> options)
            : base(options)
        {
        }

        public DbSet<buoi13_netcore.Models.Product> Product { get; set; } = default!;
    }
}
