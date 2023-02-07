using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission4TreyJackson.Models;

namespace Mission4TreyJackson.Contollers
{
    public class subFolderController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        // get function for calculator
        [HttpGet]
        public IActionResult gradeCalc ()
        {
            return View();
        }


        // post function for calculator
        [HttpPost]
        public IActionResult gradeCalc(gradeCalcModel model)
        {
            return View();
        }
    }
}
