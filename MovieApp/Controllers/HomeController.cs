using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddMovie(ApplicationResponse appResponse)
        {
            TempStorage.AddApplication(appResponse);
            //return View("DisplayMovie", TempStorage.Applications);
            return View("Confirmation", appResponse);
        }


        public IActionResult DisplayMovie()
        {
            return View(TempStorage.Applications);
        }

        public IActionResult Podcasts()
        {
            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
