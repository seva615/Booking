using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data
{
    public class DataContext : DbContext
    {
        public DbSet<HotelEntity> Hotels { get; set; }
        public DbSet<ContryEntity> Contries { get; set; }
        public DbSet<CityEntity> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Hotels;Username=postgres;Password=,fhcev234");
        }
    }
}

   