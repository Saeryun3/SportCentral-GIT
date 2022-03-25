using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportCentral.Helper;
using SportCentral.Models;
using SportCentralLibLogic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SportCentral.Controllers
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
            return View(new NewsViewModel());
        }
        [HttpGet]
        public IActionResult AddNews()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNews(NewsViewModel nvm)
        {
            nvm.Datetime = DateTime.Now;
            News news = Convertor.ConvertToNews(nvm);
            NewsContainer newsContainer = new NewsContainer();
            newsContainer.Addnews(news);
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Basketball()
        {
            return View();
        }

        public IActionResult Darts()
        {
            return View();
        }

        public IActionResult F1()
        {
            return View();
        }

        public IActionResult Football()
        {
            return View();
        }

        public IActionResult Tennis()
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
