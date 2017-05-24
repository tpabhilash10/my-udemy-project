using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
       
        public ActionResult Random()
        {
            var movie = new Movie() { Name="Jai Shri Ram"};
            return View(movie);
            //return Content("hello world");
            //return Json(movie);

            //return RedirectToAction("Index", "Home",new {page=1,sortby="name" });
        }


        public ActionResult Edit(int? MId)
        {

            return Content(MId.ToString());
        }


        [Route("movies/release/{year}/{month:regex(\\d{2}):range(1,12)}")] 
        public ActionResult ByReleaseDate(int year,int month)
        {

            return Content(year + "/" + month);
        }

    }
}