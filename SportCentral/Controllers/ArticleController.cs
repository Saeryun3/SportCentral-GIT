using Microsoft.AspNetCore.Mvc;
using SportCentral.Models;
using SportCentralDAL;
using SportCentralLibLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportCentral.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index(int newsID)
        {
            NewsContainer newsContainer = new NewsContainer(new NewsDAL());
            News news = newsContainer.GetNewsByID(newsID);
            NewsViewModel nvm = new NewsViewModel(news);
            return View(nvm);
        }
    }
}
