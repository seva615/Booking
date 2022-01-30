using System;
using System.Collections.Generic;
using System.Text;
using Booking.Data;
using AutoMapper;
using System.Threading.Tasks;

namespace Booking.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        private readonly ICountryRepository _contryRepository;
        private readonly IMapper _mapper;

        public CityService(ICityRepository cityRepository, ICountryRepository contryRepository, IMapper mapper)
        {
            _contryRepository = contryRepository;
            _cityRepository = cityRepository;
            _mapper = mapper;
        }
        public async Task DeleteCity(Guid id)
        {
            await _cityRepository.Delete(id);
        }

        public async Task AddCity(CityModel city)
        {
            if (await _contryRepository.GetById(city.CountryId) != null) {
                var CityEntity = _mapper.Map<CityModel, CityEntity>(city);
                await _cityRepository.Add(CityEntity);
            }
            else
            {
                throw new NotFoundException("No contry found with entered id");
            }
        }

        public async Task<CityModel> GetCity(Guid id)
        {
            var CityEntity = await _cityRepository.GetById(id);
            var CityModel = _mapper.Map<CityEntity, CityModel>(CityEntity);
            return CityModel;
        }

        public async Task EditCity(CityModel city)
        {
            var CityEntity = _mapper.Map<CityModel, CityEntity>(city);
            await _cityRepository.Edit(CityEntity);
        }

        public async Task<IEnumerable<CityModel>> GetCities()
        {

            var CityEntities = await _cityRepository.GetAll();
            var CityModels = _mapper.Map<IEnumerable<CityModel>>(CityEntities);
            return CityModels;
        }
    }
}
