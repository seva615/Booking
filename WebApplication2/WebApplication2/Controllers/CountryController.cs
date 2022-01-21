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
        public IEnumerable<CountryViewModel> GetContries()
        {
            var CountryModels = _countryService.GetCountries();
            var CountryViewModels = _mapper.Map<IEnumerable<CountryViewModel>>(CountryModels);
            return CountryViewModels;
        }

        [HttpGet]
        [Route("getCountry")]
        public CountryViewModel GetCountry(Guid id)
        {
            var CountryModel = _countryService.GetCountry(id);
            var CountryViewModel = _mapper.Map<CountryModel, CountryViewModel>(CountryModel);
            return CountryViewModel;
        }

        [HttpPost]
        [Route("addCountry")]
        public void AddCountry(CreateCountryViewModel country)
        {
            var CountryModel = _mapper.Map<CreateCountryViewModel, CountryModel>(country);
            _countryService.AddCountry(CountryModel);
        }

        [HttpPut]
        [Route("editCountry")]
        public void EditCountry(CountryViewModel country)
        {
            var CountryModel = _mapper.Map<CountryViewModel, CountryModel>(country);
            _countryService.EditCountry(CountryModel);
        }

        [HttpDelete]
        [Route("deleteCountry")]
        public void DeleteCountry(Guid id)
        {
            _countryService.DeleteCountry(id);
        }
    }
}
