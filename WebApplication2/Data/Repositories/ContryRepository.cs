using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data
{
   public class ContryRepository : IContryRepository
    {
        private readonly DataContext _db;

        public ContryRepository(DataContext db)
        {
            _db = db;
        }

        public void DeleteContryEntity(Guid id)
        {
            ContryEntity contry = _db.Contries.Find(id);
            if (contry != null)
            {
                _db.Contries.Remove(contry);
                _db.SaveChanges();
            }
        }

        public void AddContryEntity(ContryEntity contry)
        {
            _db.Contries.Add(contry);
            _db.SaveChanges();
        }

        public void EditContryEntity(ContryEntity contry)
        {
            _db.Entry(contry).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public ContryEntity GetContryEntity(Guid id)
        {
            ContryEntity contry = _db.Contries.Find(id);
            return contry;
        }

        public IEnumerable<ContryEntity> GetContryEntities()
        {
            return _db.Contries;
        }
    }
}
