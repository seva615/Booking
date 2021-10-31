using System;
using System.Collections.Generic;
using System.Text;
using Booking.Data;
using AutoMapper;

namespace Booking.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IContryRepository _contryRepository;
        private readonly IMapper _mapper;

        public CityService(ICityRepository cityRepository, IContryRepository contryRepository, IMapper mapper)
        {
            _contryRepository = contryRepository;
            _cityRepository = cityRepository;
            _mapper = mapper;
        }
        public void DeleteCity(Guid id)
        {
            _cityRepository.DeleteCityEntity(id);
        }

        public void AddCity(CityModel city)
        {
             
            if (_contryRepository.GetContryEntity(city.ContryId) != null) {
                var CityEntity = _mapper.Map<CityModel, CityEntity>(city);
                _cityRepository.AddCityEntity(CityEntity);
            }
        }

        public CityModel GetCity(Guid id)
        {
            var CityEntity = _cityRepository.GetCityEntity(id);
            var CityModel = _mapper.Map<CityEntity, CityModel>(CityEntity);
            return CityModel;
        }

        public void EditCity(CityModel city)
        {
            var CityEntity = _mapper.Map<CityModel, CityEntity>(city);
            _cityRepository.EditCityEntity(CityEntity);
        }

        public IEnumerable<CityModel> GetCities()
        {

            var CityEntities = _cityRepository.GetCityEntities();
            var CityModels = _mapper.Map<IEnumerable<CityModel>>(CityEntities);
            return CityModels;
        }
    }
}
