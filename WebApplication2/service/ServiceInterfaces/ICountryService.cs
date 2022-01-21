using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Services
{
   public interface ICountryService
    {
        public void DeleteCountry(Guid id);

        public void AddCountry(CountryModel contry);

        public CountryModel GetCountry(Guid id);

        public void EditCountry(CountryModel contry);

        public IEnumerable<CountryModel> GetCountries();
    }
}
