using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data
{
    public interface IHotelRepository
    {
        public void DeleteEntity(Guid id);
        public void AddEntity(HotelEntity hotel);
        public void EditEntity(Guid id, HotelEntity hotel);
        public HotelEntity GetEntity(Guid id);
    }
}
