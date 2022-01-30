using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Services
{
    public interface IAdvantageService
    {
        public Task DeleteAdvantage(Guid id);

        public Task AddAdvantage(AdvantageModel advantage);

        public Task<AdvantageModel> GetAdvantage(Guid id);

        public Task EditAdvantage(AdvantageModel advantage);

        public Task<IEnumerable<AdvantageModel>> GetAdvantages();
    }
}

