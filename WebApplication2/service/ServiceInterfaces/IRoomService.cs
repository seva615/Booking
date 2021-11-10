using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Services
{
    public interface IRoomService
    {
        public void DeleteRoom(Guid id);
        public void AddRoom(RoomModel room);
        public RoomModel GetRoom(Guid id);
        public void EditRoom(RoomModel room);
        public IEnumerable<RoomModel> GetRooms();
    }
}
