using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data
{
    public class RoomRepository : IRoomRepository
    {
        private readonly DataContext _db;

        public RoomRepository(DataContext db)
        {
            _db = db;
        }

        public void DeleteRoomEntity(Guid id)
        {
            RoomEntity room = _db.Rooms.Find(id);
            if (room != null)
            {
                _db.Rooms.Remove(room);
                _db.SaveChanges();
            }
        }

        public void AddRoomEntity(RoomEntity room)
        {
            _db.Rooms.Add(room);
            _db.SaveChanges();
        }

        public void EditRoomEntity(RoomEntity room)
        {
            _db.Entry(room).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public RoomEntity GetRoomEntity(Guid id)
        {
            RoomEntity room = _db.Rooms.Find(id);
            return room;
        }

        public IEnumerable<RoomEntity> GetRoomEntities()
        {
            return _db.Rooms;
        }
    }
}
