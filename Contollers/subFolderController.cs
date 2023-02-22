using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission4TreyJackson.Models;
using Microsoft.Extensions.Logging;

namespace Mission4TreyJackson.Contollers
{
    public class subFolderController : Controller
    {

       

        // makes a variable off movieEntryContext
        private movieEntryContext MovieContext { get; set; }

        public subFolderController(movieEntryContext movie)
        {
         
            MovieContext = movie;

        }
        public IActionResult Index()
        {

            return View();
        }

 
       
        public IActionResult podcast ()
        {
            return View();
        }



        [HttpGet]
        public IActionResult movieEntry()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult movieEntry(movieEntry ar)
        {
            //Calls movieEntryContext variable along with ar, information passed from page, to the instance
            MovieContext.Add(ar);
            MovieContext.SaveChanges();
            return View(ar);
        }

        public IActionResult movieList()
        {
            var movies = MovieContext.movieEntry.ToList();
            return View(movies);
        } 
    }
}
