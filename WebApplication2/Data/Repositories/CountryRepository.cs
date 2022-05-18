using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data
{
    public class CountryRepository : EFGenericRepository<CountryEntity>, ICountryRepository
    {
        private readonly DataContext _db;
       


        public CountryRepository(DataContext db) : base(db)
        {
            _db = db;
            CollectionWithIncludes = db.Countries
                .Include(x => x.Cities);    
        }
    }
      
}
