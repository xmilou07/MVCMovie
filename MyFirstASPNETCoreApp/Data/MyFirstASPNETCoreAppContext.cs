using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFirstASPNETCoreApp.Models;

namespace MyFirstASPNETCoreApp.Data
{
    public class MyFirstASPNETCoreAppContext : DbContext
    {
        public MyFirstASPNETCoreAppContext (DbContextOptions<MyFirstASPNETCoreAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstASPNETCoreApp.Models.Movie> Movie { get; set; } = default!;
    }
}
