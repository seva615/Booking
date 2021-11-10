using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data
{
    public class RoomRepository : IRoomRepository
    {
        DataContext db = new DataContext();
        public void DeleteRoomEntity(Guid id)
        {
            RoomEntity room = db.Rooms.Find(id);
            if (room != null)
            {
                db.Rooms.Remove(room);
                db.SaveChanges();
            }

        }

        public void AddRoomEntity(RoomEntity room)
        {
            db.Rooms.Add(room);
            db.SaveChanges();
        }

        public void EditRoomEntity(RoomEntity room)
        {
            db.Entry(room).State = EntityState.Modified;
            db.SaveChanges();
        }

        public RoomEntity GetRoomEntity(Guid id)
        {
            RoomEntity room = db.Rooms.Find(id);
            return room;
        }

        public IEnumerable<RoomEntity> GetRoomEntities()
        {
            return db.Rooms;
        }
    }
}
