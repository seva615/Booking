using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Services
{
    public interface IRoomService
    {
        public Task DeleteRoom(Guid id);

        public Task AddRoom(RoomModel room);

        public Task<RoomModel> GetRoom(Guid id);

        public Task EditRoom(RoomModel room);

        public Task<IEnumerable<RoomModel>> GetRooms();
    }
}
