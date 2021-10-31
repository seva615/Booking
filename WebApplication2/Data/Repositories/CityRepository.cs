using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data
{
    public class CityRepository : ICityRepository
    {
        DataContext db = new DataContext();
        public void DeleteCityEntity(Guid id)
        {
            CityEntity city = db.Cities.Find(id);
            if (city != null)
            {
                db.Cities.Remove(city);
                db.SaveChanges();
            }

        }

        public void AddCityEntity(CityEntity city)
        {
            db.Cities.Add(city);
            db.SaveChanges();
        }

        public void EditCityEntity(CityEntity city)
        {
            db.Entry(city).State = EntityState.Modified;
            db.SaveChanges();
        }

        public CityEntity GetCityEntity(Guid id)
        {
            CityEntity city = db.Cities.Find(id);
            return city;
        }

        public IEnumerable<CityEntity> GetCityEntities()
        {
            return db.Cities;
        }
    }
}
