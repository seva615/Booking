using System;

namespace Booking.Services
{
    public class AdvantageNavigationModel
    {
        public Guid Id { get; set; }

        public Guid AdvantageId { get; set; }

        public Guid RoomId { get; set; }
    }
}