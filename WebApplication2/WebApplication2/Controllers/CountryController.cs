using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Booking.Services;
using AutoMapper;

namespace Booking.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : Controller
    {
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;

        public CountryController(ICountryService countryService, IMapper mapper)
        {
            _mapper = mapper;
            _countryService = countryService;
        }

        [HttpGet]
        [Route("getCountries")]
        public async Task<IEnumerable<CountryViewModel>> GetContries()
        {
            var CountryModels = await _countryService.GetCountries();
            var CountryViewModels = _mapper.Map<IEnumerable<CountryViewModel>>(CountryModels);
            return CountryViewModels;
        }

        [HttpGet]
        [Route("getCountry")]
        public async Task<CountryViewModel> GetCountry(Guid id)
        {
            var CountryModel = await _countryService.GetCountry(id);
            var CountryViewModel = _mapper.Map<CountryModel, CountryViewModel>(CountryModel);
            return CountryViewModel;
        }

        [HttpPost]
        [Route("addCountry")]
        public async Task AddCountry(CreateCountryViewModel country)
        {
            var CountryModel = _mapper.Map<CreateCountryViewModel, CountryModel>(country);
            await _countryService.AddCountry(CountryModel);
        }

        [HttpPut]
        [Route("editCountry")]
        public async Task EditCountry(CountryViewModel country)
        {
            var CountryModel = _mapper.Map<CountryViewModel, CountryModel>(country);
            await _countryService.EditCountry(CountryModel);
        }

        [HttpDelete]
        [Route("deleteCountry")]
        public async Task DeleteCountry(Guid id)
        {
            await _countryService.DeleteCountry(id);
        }
    }
}
