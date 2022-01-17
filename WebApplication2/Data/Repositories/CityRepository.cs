using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext _db;

        public CityRepository(DataContext db)
        {
            _db = db;
        }

        public void DeleteCityEntity(Guid id)
        {
            CityEntity city = _db.Cities.Find(id);
            if (city != null)
            {
                _db.Cities.Remove(city);
                _db.SaveChanges();
            }
        }

        public void AddCityEntity(CityEntity city)
        {
            _db.Cities.Add(city);
            _db.SaveChanges();
        }

        public void EditCityEntity(CityEntity city)
        {
            _db.Entry(city).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public CityEntity GetCityEntity(Guid id)
        {
            CityEntity city = _db.Cities.Find(id);
            return city;
        }

        public IEnumerable<CityEntity> GetCityEntities()
        {
            return _db.Cities;
        }
    }
}
