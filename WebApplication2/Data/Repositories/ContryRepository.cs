using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data
{
   public class ContryRepository : IContryRepository
    {
        DataContext db = new DataContext();
        public void DeleteContryEntity(Guid id)
        {
            ContryEntity contry = db.Contries.Find(id);
            if (contry != null)
            {
                db.Contries.Remove(contry);
                db.SaveChanges();
            }

        }

        public void AddContryEntity(ContryEntity contry)
        {
            db.Contries.Add(contry);
            db.SaveChanges();
        }

        public void EditContryEntity(ContryEntity contry)
        {
            db.Entry(contry).State = EntityState.Modified;
            db.SaveChanges();
        }

        public ContryEntity GetContryEntity(Guid id)
        {
            ContryEntity contry = db.Contries.Find(id);
            return contry;
        }

        public IEnumerable<ContryEntity> GetContryEntities()
        {
            return db.Contries;
        }
    }
}
