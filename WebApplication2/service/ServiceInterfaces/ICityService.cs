using System;
using System.Collections.Generic;

namespace Booking.Services
{
    public interface ICityService
    {
        public void DeleteCity(Guid id);

        public void AddCity(CityModel city);

        public CityModel GetCity(Guid id);

        public void EditCity(CityModel city);

        public IEnumerable<CityModel> GetCities();
    }
}
