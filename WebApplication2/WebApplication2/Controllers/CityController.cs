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
    public class CityController : Controller
    {
        private readonly ICityService _cityService;
        private readonly IMapper _mapper;

        public CityController(ICityService cityService, IMapper mapper)
        {
            _mapper = mapper;
            _cityService = cityService;
        }

        [HttpGet]
        [Route("getCities")]
        public async Task<IEnumerable<CityViewModel>> GetCities()
        {
            var CityModels = await _cityService.GetCities();
            var CityViewModels = _mapper.Map<IEnumerable<CityViewModel>>(CityModels);
            return CityViewModels;
        }

        [HttpGet]
        [Route("getCity")]
        public async Task<CityViewModel> GetCity(Guid id)
        {
            var CityModel = await _cityService.GetCity(id);
            var CityViewModel = _mapper.Map<CityModel, CityViewModel>(CityModel);
            return CityViewModel;
        }

        [HttpPost]
        [Route("addCity")]
        public async Task AddCity(CreateCityViewModel city)
        {
            var CityModel = _mapper.Map<CreateCityViewModel, CityModel>(city);
            await _cityService.AddCity(CityModel);
        }

        [HttpPut]
        [Route("editCity")]
        public async Task EditCity(CityViewModel city)
        {
            var CityModel = _mapper.Map<CityViewModel, CityModel>(city);
            await _cityService.EditCity(CityModel);
        }

        [HttpDelete]
        [Route("deleteCity")]
        public async Task DeleteCity(Guid id)
        {
            await _cityService.DeleteCity(id);
        }
    }
}
