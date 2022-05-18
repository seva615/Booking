using System;
using System.Collections.Generic;
using System.Text;
using Booking.Data;
using AutoMapper;
using System.Threading.Tasks;

namespace Booking.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;        
        private readonly IMapper _mapper;

        public CountryService(ICountryRepository countryRepository, IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }
        public async Task DeleteCountry(Guid id)
        {
            await _countryRepository.Delete(id);
        }

        public async Task AddCountry(CountryModel country)
        {
            var CountryEntity = _mapper.Map<CountryModel, CountryEntity>(country);
            await _countryRepository.Add(CountryEntity);
        }

        public async Task<CountryModel> GetCountry(Guid id)
        {
            var CountryEntity = await _countryRepository.GetById(id);
            var CountryModel = _mapper.Map<CountryEntity, CountryModel>(CountryEntity);
            return CountryModel;
        }

        public async Task EditCountry(CountryModel country)
        {
            var CountryEntity = _mapper.Map<CountryModel, CountryEntity>(country);
            await _countryRepository.Edit(CountryEntity);
        }

        public async Task<IEnumerable<CountryModel>> GetCountries()
        {
            var CountryEntities = await _countryRepository.GetAll();
            var CountryModels = _mapper.Map<IEnumerable<CountryModel>>(CountryEntities);
            return CountryModels;
        }
    }
}
