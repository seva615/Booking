using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data
{
    public interface ICityRepository
    {
        public void DeleteCityEntity(Guid id);
        public void AddCityEntity(CityEntity city);
        public void EditCityEntity(CityEntity city);
        public CityEntity GetCityEntity(Guid id);
        public IEnumerable<CityEntity> GetCityEntities();
    }
}
