using Microsoft.EntityFrameworkCore;
using project777.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project777.DataBase
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Trip> Trips { get; set; }

        public DbSet<UserCodeName> UserCodeNames { get; set; }

        public DbSet<UserTrip> UserTrips { get; set; }

        public DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=127.0.0.1;Port=5432;Database=hotentsev;UserName=postgres;Password=admin;");

            base.OnConfiguring(optionsBuilder);

        }

    }
}
