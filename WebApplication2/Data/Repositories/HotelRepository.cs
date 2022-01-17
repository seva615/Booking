using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data
{
   public class HotelRepository : IHotelRepository
    {
        private readonly DataContext _db;

        public HotelRepository(DataContext db)
        {
            _db = db;
        }

        public void DeleteHotelEntity(Guid id)
        {
            HotelEntity hotel = _db.Hotels.Find(id);
            if (hotel != null)
            {
                _db.Hotels.Remove(hotel);
                _db.SaveChanges();
            }                
        }

        public void AddHotelEntity(HotelEntity hotel)
        {
            _db.Hotels.Add(hotel);
            _db.SaveChanges();
        }

        public void EditHotelEntity(HotelEntity hotel)
        {
                _db.Entry(hotel).State = EntityState.Modified;
                _db.SaveChanges();            
        }

        public HotelEntity GetHotelEntity(Guid id)
        {
            HotelEntity hotel = _db.Hotels.Find(id);
            return hotel;
        }

        public IEnumerable<HotelEntity> GetHotelEntities()
        {
            return _db.Hotels;
        }
    }
}
