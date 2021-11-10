using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data
{
    public class RoomEntity
    {
        public Guid Id { get; set; }
        public Guid HotelId { get; set; }
        public string RoomType { get; set; }
        public int RoomNumber { get; set; }
        public int Price { get; set; }
        public int RoomSpace { get; set; }
        public Guid AdvantageId { get; set; }
        public IEnumerable<AdvantageEntity> Advantages { get; set; }


    }
}
