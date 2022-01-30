using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Booking.Services
{
    public interface IAdvantageNavigationService
    {
        public Task DeleteAdvantageNavigation(Guid id);

        public Task AddAdvantageNavigation(AdvantageNavigationModel advantageNavigation);

        public Task<AdvantageNavigationModel> GetAdvantageNavigation(Guid id);

        public Task EditAdvantageNavigation(AdvantageNavigationModel advantageNavigation);

        public Task<IEnumerable<AdvantageNavigationModel>> GetAdvantageNavigations();
    }
}