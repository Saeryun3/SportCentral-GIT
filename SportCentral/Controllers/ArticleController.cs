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
            CommentContainer commentContainer = new CommentContainer(new CommentDAL());
            News news = newsContainer.GetNewsByID(newsID);
            NewsViewModel nvm = new NewsViewModel(news);
            List<Comment> comments = commentContainer.GetAllComments(newsID);
            foreach(Comment comment in comments)
            {
               nvm.comments.Add(new CommentViewModel(comment));
            }
            return View(nvm);
        }
        
    }
}
