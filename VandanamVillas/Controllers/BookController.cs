using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VandanamVillas.Models;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace VandanamVillas.Controllers
{
    public class BookingController : Controller
    {
        // GET: Book
        private ApplicationDbContext _context;

        public BookingController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(Booking booking)
        {

            if (!ModelState.IsValid)
            {
                return View("Index",booking);
            }
            booking.CDate = DateTime.Now;
            _context.Bookings.Add(booking);
            _context.SaveChanges();


            SendMail(booking);

            //return RedirectToAction("Index", "Booking");
            return Json(booking);
        }


        public void SendMail(Booking booking)
        {
            var appconfig = _context.AppConfigs.SingleOrDefault();

            
            try
            {

                StreamReader reader = new StreamReader(Server.MapPath("~/Mailers/booking.html"));
                string readFile = reader.ReadToEnd();
                string myString = "";
                myString = readFile;
                myString = myString.Replace("$$Name$$", booking.Name);
                myString = myString.Replace("$$Email$$", booking.Email);
                myString = myString.Replace("$$Mobile$$", booking.Mobile);
                myString = myString.Replace("$$CheckInDate$$", booking.CheckInDate.ToString("dd MMM yyyy"));
                myString = myString.Replace("$$NoOfDays$$", booking.NumberofDays.ToString());
                myString = myString.Replace("$$Message$$", booking.Message);
              

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(booking.Email);
                mailMessage.To.Add(appconfig.EmailToID);

                
                
                mailMessage.Subject = "Vandanam Villas - Booking";
                mailMessage.Body = myString;
                mailMessage.IsBodyHtml = true;
                reader.Dispose();
                SmtpClient smtpClient = new SmtpClient(appconfig.EmailSMTP);
                smtpClient.Credentials = new NetworkCredential(appconfig.EmailSMTPUsername, appconfig.EmailSMTPPassword);
                smtpClient.Port = 25;
                smtpClient.Send(mailMessage);
                //Response.Write("E-mail sent!");
            }
            catch (Exception ex)
            {
                //Response.Write("Could not send the e-mail - error: " + ex.Message);
            }
        }
    }
}