using Backend.Model;
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
        => optionsBuilder.UseNpgsql(connectionString: "Server=localhost;Port=5432;Username=postgres;host=localhost;database=ClinicService;password=postgres;Include Error Detail=true;");

        public DbSet<Person> People { get; set; }
        public DbSet<Clinika> Clinikass { get; set; }
        public DbSet<Medservice> Medservices { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Analyser> Analysers { get; set; }
        public DbSet<Clinikqueue> Clinikqueues { get; set; }
    }
}
