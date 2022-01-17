using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Booking.Data
{
    public class AdvantageRepository : IAdvantageRepository
    {
        
        private readonly DataContext _db;
    
        public AdvantageRepository(DataContext db)
        {
            _db = db;
        }

        public void DeleteAdvantageEntity(Guid id)
        {
            AdvantageEntity advantage = _db.Advantages.Find(id);
            if (advantage != null)
            {
                _db.Advantages.Remove(advantage);
                _db.SaveChanges();
            }

        }

        public void AddAdvantageEntity(AdvantageEntity advantage)
        {
            _db.Advantages.Add(advantage);
            _db.SaveChanges();
        }

        public void EditAdvantageEntity(AdvantageEntity advantage)
        {
            _db.Entry(advantage).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public AdvantageEntity GetAdvantageEntity(Guid id)
        {
            AdvantageEntity advantage = _db.Advantages.Find(id);
            return advantage;
        }

        public IEnumerable<AdvantageEntity> GetAdvantageEntities()
        {
            return _db.Advantages;
        }
    }
}
