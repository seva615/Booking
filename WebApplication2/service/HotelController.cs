using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Booking.Data;

namespace Booking.Services
{
    public class HotelController
    {
        DataContext db = new DataContext();

        public IEnumerable<HotelEntity> GetHotels()
        {
           return db.Hotels;
        }

        public HotelEntity GetHotel(int id)
        {
            HotelEntity hotel = db.Hotels.Find(id);
            return hotel;
        }

        public void AddHotel(HotelEntity hotel)
        {
            db.Hotels.Add(hotel);
            db.SaveChanges();
        }

        public void EditHotel(int id, HotelEntity hotel)
        {
            if(id == hotel.Id)
            {
                db.Entry(hotel).State = EntityState.Modified;
                db.SaveChanges();
            }
            
        }

        public void DeleteHotel(int id)
        {
            HotelEntity hotel = db.Hotels.Find(id);
            if (hotel != null)
            {
                db.Hotels.Remove(hotel);
                db.SaveChanges();
            }

        }
    }
}