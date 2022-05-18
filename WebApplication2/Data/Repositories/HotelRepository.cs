using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data
{
   public class HotelRepository : EFGenericRepository<HotelEntity>, IHotelRepository
    {
        private readonly DataContext _db;

        public HotelRepository(DataContext db) : base(db)
        {
            _db = db;
            CollectionWithIncludes = db.Hotels
                .Include(x => x.Rooms);
        }

        
    }
}
