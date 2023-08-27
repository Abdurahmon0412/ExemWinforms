using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DataLayer
{
    public class EfCoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Username=postgres;host=localhost;database=postgres;password=postgres;");

        public DbSet<Person> People { get; set; }
    }
}
