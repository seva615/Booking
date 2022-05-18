using System;
using System.Collections.Generic;
using System.Text;
using Booking.Data.DataInterfaces;

namespace Booking.Data.Entities
{
    public class AdvantageNavigationEntity : IEntity
    {
        public Guid Id { get; set; }

        public Guid AdvantageId { get; set; }

        public Guid RoomId { get; set; }
    }
}
