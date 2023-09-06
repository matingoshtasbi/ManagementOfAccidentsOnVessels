using ManagementOfAccidentsOnVessels.Domain.Missions.Aggregates;
using ManagementOfAccidentsOnVessels.Domain.PortsManagement.Aggregates;
using ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Aggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Infrastructure.DataBaseContext
{
    public class ManagementOfAccidentsOnVesselsDbContext : DbContext
    {
        public ManagementOfAccidentsOnVesselsDbContext(
            DbContextOptions<ManagementOfAccidentsOnVesselsDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json")
             .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Recogenize VesselExtraDetail As ComplexType
            modelBuilder.Entity<Vessel>(entity =>
            {
                entity.OwnsOne(e => e.Detail);
            });

            // Ports Seeds
            modelBuilder.Entity<Port>().HasData(new Port() { Id = 1, Name = "اروندکنار", Lat = 83, Lon = 79, Capacity = 4 });
            modelBuilder.Entity<Port>().HasData(new Port() { Id = 2, Name = "ماهشهر", Lat = 171, Lon = 43, Capacity = 8 });
            modelBuilder.Entity<Port>().HasData(new Port() { Id = 3, Name = "دیلم", Lat = 261, Lon = 54, Capacity = 3 });
            modelBuilder.Entity<Port>().HasData(new Port() { Id = 4, Name = "گناوه", Lat = 313, Lon = 106, Capacity = 3 });
            modelBuilder.Entity<Port>().HasData(new Port() { Id = 5, Name = "خارگ", Lat = 288, Lon = 143, Capacity = 4 });
            modelBuilder.Entity<Port>().HasData(new Port() { Id = 6, Name = "ریگ", Lat = 327, Lon = 134, Capacity = 4 });
            modelBuilder.Entity<Port>().HasData(new Port() { Id = 7, Name = "بوشهر", Lat = 355, Lon = 172, Capacity = 12 });
            modelBuilder.Entity<Port>().HasData(new Port() { Id = 8, Name = "بوالخیر", Lat = 381, Lon = 212, Capacity = 3 });
            modelBuilder.Entity<Port>().HasData(new Port() { Id = 9, Name = "کنگان", Lat = 469, Lon = 246, Capacity = 4 });
            modelBuilder.Entity<Port>().HasData(new Port() { Id = 10, Name = "نخل تقی", Lat = 529, Lon = 263, Capacity = 3 });
            modelBuilder.Entity<Port>().HasData(new Port() { Id = 11, Name = "عسلویه", Lat = 573, Lon = 267, Capacity = 9 });
            modelBuilder.Entity<Port>().HasData(new Port() { Id = 12, Name = "آفتاب", Lat = 685, Lon = 349, Capacity = 8 });
            modelBuilder.Entity<Port>().HasData(new Port() { Id = 13, Name = "کیش", Lat = 664, Lon = 371, Capacity = 9 });
            modelBuilder.Entity<Port>().HasData(new Port() { Id = 14, Name = "شهید رجایی", Lat = 824, Lon = 365, Capacity = 7 });
            modelBuilder.Entity<Port>().HasData(new Port() { Id = 15, Name = "لافت", Lat = 881, Lon = 362, Capacity = 5 });
            modelBuilder.Entity<Port>().HasData(new Port() { Id = 16, Name = "ابوموسی", Lat = 864, Lon = 435, Capacity = 3 });
            modelBuilder.Entity<Port>().HasData(new Port() { Id = 17, Name = "حقانی", Lat = 928, Lon = 325, Capacity = 6 });
            modelBuilder.Entity<Port>().HasData(new Port() { Id = 18, Name = "قشم", Lat = 941, Lon = 360, Capacity = 11 });
        }

        // tables
        public DbSet<Vessel> Vessels { get; set; }

        public DbSet<Port> Ports { get; set; }

    }
}
