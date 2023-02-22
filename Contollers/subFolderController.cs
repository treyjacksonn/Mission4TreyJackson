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
            ViewBag.Categories = MovieContext.Categories.ToList();
  
            return View();
        }

        [HttpPost]
        public IActionResult movieEntry(movieEntry me)
        {
            if (ModelState.IsValid)
            {
                //Calls movieEntryContext variable along with me, information passed from page, to the instance
                MovieContext.Add(me);
                MovieContext.SaveChanges();
                return View("Confirmation", me);
            }
            else
            {
                ViewBag.Categories = MovieContext.Categories.ToList();
                return View(me);
            }
           
        }

        public IActionResult movieList()
        {
            var movies = MovieContext.movieEntry
                //.Where(x => x.something == something)
                // OrderBy(x => x.Title)
                .ToList();
            return View(movies);
        } 

        //Receive the MovieID through the URL when the edit function is clicked
        // uses the MovieID to find the specific movie entry
        // this movie entry then populates the movieEntry view along with the entry that correlates to the ID
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = MovieContext.Categories.ToList();

            var entry = MovieContext.movieEntry
                .Single(x => x.MovieID == movieid);

            return View("movieEntry",entry);
        }


        //The post recieves the entry, updates the database, and then saves the changes.
        // The user is then redirected to the movieList action.
        [HttpPost]
        public IActionResult Edit(movieEntry me)
        {
            MovieContext.Update(me);
            MovieContext.SaveChanges();

            return RedirectToAction("movieList");
        }


        //Functions the same as the Edit class only that it references a seperate view called "Delete"
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = MovieContext.movieEntry.Single(x => x.MovieID == movieid);

            return View(movie);
        }


        // Receives the specified entry from the get then deletes it from database, saves changes.
        // After user is sent back to the movieList view.
        [HttpPost]
        public IActionResult Delete(movieEntry me)
        {
            MovieContext.movieEntry.Remove(me);
            MovieContext.SaveChanges();
            return RedirectToAction("movieList");
        } 
    }
}
