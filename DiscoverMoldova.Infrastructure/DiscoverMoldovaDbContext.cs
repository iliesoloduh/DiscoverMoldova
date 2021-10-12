using DiscoverMoldova.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DiscoverMoldova.Infrastructure
{
    public class DiscoverMoldovaDbContext : DbContext
    {

        public DiscoverMoldovaDbContext(DbContextOptions<DiscoverMoldovaDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Resort> Resorts { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<ResortFacility> ResortFacilities { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<District> Districts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(DiscoverMoldovaDbContext)));
        }
    }
}
