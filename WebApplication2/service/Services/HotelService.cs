using System;
using System.Collections.Generic;
using System.Text;
using Booking.Data;
using AutoMapper;


namespace Booking.Services
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IMapper _mapper;

        public HotelService(IHotelRepository hotelRepository, IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _mapper = mapper;
        }
        public void DeleteHotel(Guid id)
        {
            _hotelRepository.DeleteHotelEntity(id);  
        }

        public void AddHotel(HotelModel hotel)
        {
            var HotelEntity = _mapper.Map<HotelModel, HotelEntity>(hotel);
            _hotelRepository.AddHotelEntity(HotelEntity);
        }

        public HotelModel GetHotel(Guid id)
        {
            var HotelEntity = _hotelRepository.GetHotelEntity(id);
            var HotelModel = _mapper.Map<HotelEntity, HotelModel>(HotelEntity);
            return HotelModel;
        }

        public void EditHotel(HotelModel hotel)
        {
            var HotelEntity = _mapper.Map<HotelModel, HotelEntity>(hotel);
               _hotelRepository.EditHotelEntity(HotelEntity);            
        }

        public IEnumerable<HotelModel> GetHotels()
        {
          
            var hotelEntities = _hotelRepository.GetHotelEntities();
            var HotelModels = _mapper.Map<IEnumerable<HotelModel>>(hotelEntities);
            return HotelModels;
        }
    }
}
