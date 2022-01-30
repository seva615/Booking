using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data
{
    public class CityRepository : EFGenericRepository<CityEntity>, ICityRepository
    {
        private readonly DataContext _db;
        

        public CityRepository(DataContext db) : base(db)
        {
            _db = db;
            CollectionWithIncludes = db.Cities
                .Include(x => x.Hotels);
        }
            
    }
}
