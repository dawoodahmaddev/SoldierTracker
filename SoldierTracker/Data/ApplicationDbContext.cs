using Microsoft.EntityFrameworkCore;
using SoldierTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoldierTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Soldier> Soldiers { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<SoldierLocation> SoldierLocations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SoldierLocation>()
                .HasKey(sl => new { sl.SensorID, sl.SoldierID });
            
            modelBuilder.Entity<SoldierLocation>()
                .HasOne(s => s.Sensor)
                .WithMany(sl => sl.SoldierLocations)
                .HasForeignKey(s => s.SensorID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SoldierLocation_Sensor");

            modelBuilder.Entity<SoldierLocation>()
                .HasOne(s => s.Soldier)
                .WithMany(sl => sl.SoldierLocations)
                .HasForeignKey(s => s.SoldierID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SoldierLocations_Soldier");
        }

    }
}
