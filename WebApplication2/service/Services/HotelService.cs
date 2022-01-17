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
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public HotelService(IHotelRepository hotelRepository, ICityRepository cityRepository, IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _cityRepository = cityRepository;
            _mapper = mapper;
        }
        public void DeleteHotel(Guid id)
        {
            _hotelRepository.DeleteHotelEntity(id);  
        }

        public void AddHotel(HotelModel hotel)
        {
            if (_cityRepository.GetCityEntity(hotel.CityId) != null)
            {
                var HotelEntity = _mapper.Map<HotelModel, HotelEntity>(hotel);
                _hotelRepository.AddHotelEntity(HotelEntity);
            }
            else
            {
                throw new NotFoundException("No city found with entered id");
            }
            
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
           
            var HotelEntities = _hotelRepository.GetHotelEntities();
            var HotelModels = _mapper.Map<IEnumerable<HotelModel>>(HotelEntities);
            return HotelModels;
        }
    }
}
