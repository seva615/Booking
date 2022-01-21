using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext _db;
        private IQueryable<CityEntity> CollectionWithIncludes { get; set; }

        public CityRepository(DataContext db)
        {
            _db = db;
            CollectionWithIncludes = db.Cities
                .Include(x => x.Hotels);
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
            return CollectionWithIncludes.ToList(); 
        }
    }
}
