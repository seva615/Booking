using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;


namespace Booking.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        {
        }

        public DbSet<HotelEntity> Hotels { get; set; }

        public DbSet<CountryEntity> Countries { get; set; }

        public DbSet<CityEntity> Cities { get; set; }

        public DbSet<RoomEntity> Rooms { get; set; }

        public DbSet<AdvantageEntity> Advantages { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountryEntity>().HasMany(e => e.Cities).WithOne(e => e.Country);
            modelBuilder.Entity<CityEntity>().HasOne(e => e.Country).WithMany(e => e.Cities);
            modelBuilder.Entity<CityEntity>().HasMany(e => e.Hotels).WithOne(e => e.City);
            modelBuilder.Entity<HotelEntity>().HasOne(e => e.City).WithMany(e => e.Hotels);
        }
    }
}

   