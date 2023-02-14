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

        private readonly ILogger<subFolderController> _logger;

        // makes a variable off movieEntryContext
        private movieEntryContext _movieContext { get; set; }

        public subFolderController(ILogger<subFolderController>logger, movieEntryContext movie)
        {
            _logger = logger;
            _movieContext = movie;

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
            _movieContext.Add(ar);
            _movieContext.SaveChanges();
            return View(ar);
        }
    }
}
