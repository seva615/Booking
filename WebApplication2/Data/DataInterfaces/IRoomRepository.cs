using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data
{
    public interface IRoomRepository
    {
        public void DeleteRoomEntity(Guid id);
        public void AddRoomEntity(RoomEntity room);
        public void EditRoomEntity(RoomEntity room);
        public RoomEntity GetRoomEntity(Guid id);
        public IEnumerable<RoomEntity> GetRoomEntities();
    }
}
