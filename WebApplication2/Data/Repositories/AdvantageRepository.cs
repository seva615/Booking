using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data
{
    public class AdvantageRepository : IAdvantageRepository
    {
        DataContext db = new DataContext();
        public void DeleteAdvantageEntity(Guid id)
        {
            AdvantageEntity advantage = db.Advantages.Find(id);
            if (advantage != null)
            {
                db.Advantages.Remove(advantage);
                db.SaveChanges();
            }

        }

        public void AddAdvantageEntity(AdvantageEntity advantage)
        {
            db.Advantages.Add(advantage);
            db.SaveChanges();
        }

        public void EditAdvantageEntity(AdvantageEntity advantage)
        {
            db.Entry(advantage).State = EntityState.Modified;
            db.SaveChanges();
        }

        public AdvantageEntity GetAdvantageEntity(Guid id)
        {
           AdvantageEntity advantage = db.Advantages.Find(id);
            return advantage;
        }

        public IEnumerable<AdvantageEntity> GetAdvantageEntities()
        {
            return db.Advantages;
        }
    }
}
