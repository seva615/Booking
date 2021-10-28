using System;
using System.Collections.Generic;
using System.Text;
using Booking.Data;


namespace Booking.Services
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;
        
        public HotelService(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }
        public void DeleteHotel(Guid id)
        {
            _hotelRepository.DeleteEntity(id);  
        }

        public void AddHotel(HotelModel hotel)
        {
            var HotelEntity =
            _hotelRepository.AddEntity(HotelEntity);
        }

        public HotelModel GetHotel(Guid id)
        {
            var HotelEntity = _hotelRepository.GetEntity(id);
            var HotelModel  = 
            return HotelModel;
        }

        public void EditHotel(Guid id, HotelModel hotel)
        { 
            var HotelEntity =
                _hotelRepository.EditEntity(id, HotelEntity);  
        }
    }
}
