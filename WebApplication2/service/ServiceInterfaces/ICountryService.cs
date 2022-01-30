using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Services
{
   public interface ICountryService
    {
        public Task DeleteCountry(Guid id);

        public Task AddCountry(CountryModel contry);

        public Task<CountryModel> GetCountry(Guid id);

        public Task EditCountry(CountryModel contry);

        public Task<IEnumerable<CountryModel>> GetCountries();
    }
}
