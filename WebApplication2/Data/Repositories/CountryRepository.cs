using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data
{
   public class CountryRepository : ICountryRepository
    {
        private readonly DataContext _db;
        private IQueryable<CountryEntity> CollectionWithIncludes { get; set; }


        public CountryRepository(DataContext db)
        {
            _db = db;
            CollectionWithIncludes = db.Countries
                .Include(x => x.Cities);
        }

        public void DeleteCountryEntity(Guid id)
        {
            CountryEntity contry = _db.Countries.Find(id);
            if (contry != null)
            {
                _db.Countries.Remove(contry);
                _db.SaveChanges();
            }
        }

        public void AddCountryEntity(CountryEntity country)
        {
            _db.Countries.Add(country);
            _db.SaveChanges();
        }

        public void EditCountryEntity(CountryEntity country)
        {
            _db.Entry(country).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public CountryEntity GetCountryEntity(Guid id)
        {
            CountryEntity contry = _db.Countries.Find(id);
            return contry;
        }

        public IEnumerable<CountryEntity> GetCountryEntities()
        {
            return CollectionWithIncludes.ToList();
        }
    }
}
