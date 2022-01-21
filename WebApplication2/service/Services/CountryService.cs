using System;
using System.Collections.Generic;
using System.Text;
using Booking.Data;
using AutoMapper;

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
        public void DeleteCountry(Guid id)
        {
            _countryRepository.DeleteCountryEntity(id);
        }

        public void AddCountry(CountryModel country)
        {
            var CountryEntity = _mapper.Map<CountryModel, CountryEntity>(country);
            _countryRepository.AddCountryEntity(CountryEntity);
        }

        public CountryModel GetCountry(Guid id)
        {
            var CountryEntity = _countryRepository.GetCountryEntity(id);
            var CountryModel = _mapper.Map<CountryEntity, CountryModel>(CountryEntity);
            return CountryModel;
        }

        public void EditCountry(CountryModel country)
        {
            var CountryEntity = _mapper.Map<CountryModel, CountryEntity>(country);
            _countryRepository.EditCountryEntity(CountryEntity);
        }

        public IEnumerable<CountryModel> GetCountries()
        {
            var CountryEntities = _countryRepository.GetCountryEntities();
            var CountryModels = _mapper.Map<IEnumerable<CountryModel>>(CountryEntities);
            return CountryModels;
        }
    }
}
