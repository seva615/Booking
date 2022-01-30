using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data
{
    public class RoomRepository : EFGenericRepository<RoomEntity>, IRoomRepository
    {
        private readonly DataContext _db;

        public RoomRepository(DataContext db) : base(db)
        {
            _db = db;
            CollectionWithIncludes = db.Rooms;
        }
    }
}
