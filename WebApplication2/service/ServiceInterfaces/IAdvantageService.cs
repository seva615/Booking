using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Services
{
    public interface IAdvantageService
    {
        public void DeleteAdvantage(Guid id);

        public void AddAdvantage(AdvantageModel advantage);

        public AdvantageModel GetAdvantage(Guid id);

        public void EditAdvantage(AdvantageModel advantage);

        public IEnumerable<AdvantageModel> GetAdvantages();
    }
}

