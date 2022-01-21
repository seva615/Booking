using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data
{
    public interface ICountryRepository
    {
        public void DeleteCountryEntity(Guid id);

        public void AddCountryEntity(CountryEntity contry);

        public void EditCountryEntity(CountryEntity contry);

        public CountryEntity GetCountryEntity(Guid id);

        public IEnumerable<CountryEntity> GetCountryEntities();
    }
}
