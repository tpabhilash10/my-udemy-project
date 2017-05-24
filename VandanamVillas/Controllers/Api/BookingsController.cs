using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VandanamVillas.Models;

namespace VandanamVillas.Controllers.Api
{
    public class BookingsController : ApiController
    {
        private ApplicationDbContext _context;

        public BookingsController()
        {
            _context = new ApplicationDbContext();
        }


        //GET /api/bookings
        public IEnumerable<Booking> GetBookings()
        {
            return _context.Bookings.ToList();

        }

        //GET /api/bookings/1
        public Booking GetBooking(int id)
        {
            var booking= _context.Bookings.SingleOrDefault(b => b.Id == id);

            if (booking == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);


            return booking;

        }


        //Post /api/bookings
        [HttpPost]
        public Booking CreateBooking(Booking booking)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);


            _context.Bookings.Add(booking);
            _context.SaveChanges();

            return booking;

        }

        //PUT /api/bookings/1
        [HttpPut]
        public void UpdateBooking(int id,Booking booking)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var bookingInDb = _context.Bookings.SingleOrDefault(b => b.Id == id);

            if (bookingInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);


            bookingInDb.Name = booking.Name;
            bookingInDb.Email = booking.Email;
            bookingInDb.Email = booking.Email;
            bookingInDb.Mobile = booking.Mobile;
            bookingInDb.NumberofDays = booking.NumberofDays;
            bookingInDb.Message = booking.Message;
            
            _context.SaveChanges();

          
        }

        //DELETE /api/bookings/1
        [HttpDelete]
        public void DeleteBooking(int id)
        {

            var bookingInDb = _context.Bookings.SingleOrDefault(b => b.Id == id);

            if (bookingInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);


            _context.Bookings.Remove(bookingInDb);
            _context.SaveChanges();

        }

    }
}
