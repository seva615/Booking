using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Booking.Services
{
    public interface ICityService
    {
        public Task DeleteCity(Guid id);

        public Task AddCity(CityModel city);

        public Task<CityModel> GetCity(Guid id);

        public Task EditCity(CityModel city);

        public Task<IEnumerable<CityModel>> GetCities();
    }
}
