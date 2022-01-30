using Booking.Data.DataInterfaces;
using Booking.Data.Entities;
using Microsoft.EntityFrameworkCore;
namespace Booking.Data
{
    public class AdvantageNavigationRepository : EFGenericRepository<AdvantageNavigationEntity>, IAdvantageNavigationRepository
    {
        private readonly DataContext _db;
    
        public AdvantageNavigationRepository(DataContext db) : base(db)
        {
            _db = db;
            CollectionWithIncludes = db.AdvantageNavigations;
        }
    }
}