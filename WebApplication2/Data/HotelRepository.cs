using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data
{
   public class HotelRepository : IHotelRepository
    {
        DataContext db = new DataContext();
        public void DeleteEntity(Guid id)
        {
            HotelEntity hotel = db.Hotels.Find(id);
            if (hotel != null)
            {
                db.Hotels.Remove(hotel);
                db.SaveChanges();
            }
                 
        }

        public void AddEntity(HotelEntity hotel)
        {
            db.Hotels.Add(hotel);
            db.SaveChanges();
        }

        public void EditEntity(Guid id, HotelEntity hotel)
        {
            if (id == hotel.Id)
            {
                db.Entry(hotel).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public HotelEntity GetEntity(Guid id)
        {
            HotelEntity hotel = db.Hotels.Find(id);
            return hotel;
        }
    }
}
