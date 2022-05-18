using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Booking.Data
{
    public class AdvantageRepository : EFGenericRepository<AdvantageEntity>, IAdvantageRepository
    {
        
        private readonly DataContext _db;
    
        public AdvantageRepository(DataContext db) : base(db)
        {
            _db = db;
            CollectionWithIncludes = db.Advantages;
        }
    }
}
