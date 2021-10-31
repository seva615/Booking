using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data
{
   public class HotelRepository : IHotelRepository
    {
        DataContext db = new DataContext();
        public void DeleteHotelEntity(Guid id)
        {
            HotelEntity hotel = db.Hotels.Find(id);
            if (hotel != null)
            {
                db.Hotels.Remove(hotel);
                db.SaveChanges();
            }
                
        }

        public void AddHotelEntity(HotelEntity hotel)
        {
            db.Hotels.Add(hotel);
            db.SaveChanges();
        }

        public void EditHotelEntity(HotelEntity hotel)
        {
                db.Entry(hotel).State = EntityState.Modified;
                db.SaveChanges();            
        }

        public HotelEntity GetHotelEntity(Guid id)
        {
            HotelEntity hotel = db.Hotels.Find(id);
            return hotel;
        }

        public IEnumerable<HotelEntity> GetHotelEntities()
        {
            return db.Hotels;
        }
    }
}
