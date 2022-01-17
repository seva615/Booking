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

        public DbSet<ContryEntity> Contries { get; set; }

        public DbSet<CityEntity> Cities { get; set; }

        public DbSet<RoomEntity> Rooms { get; set; }

        public DbSet<AdvantageEntity> Advantages { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContryEntity>().HasMany(e => e.Cities).WithOne(e => e.Contry);
            //modelBuilder.Entity<CityEntity>().HasMany(e => e.Hotels).WithOne().HasForeignKey(e => e.CityId);
            //modelBuilder.Entity<HotelEntity>().HasMany(e => e.Rooms).WithOne().HasForeignKey(e => e.HotelId);
        }
    }
}

   