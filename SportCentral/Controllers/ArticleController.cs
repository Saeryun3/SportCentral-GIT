using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportCentral.Helper;
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
            UserContainer userContainer = new UserContainer(new UserDAL());
            News news = newsContainer.GetNewsByID(newsID);
            NewsViewModel nvm = new NewsViewModel(news);
            List<Comment> comments = commentContainer.GetAllComments(newsID);
            foreach(Comment comment in comments)
            {
               nvm.comments.Add(new CommentViewModel(comment, userContainer.GetUserByID(comment.UserID)));
            }
            return View(nvm);
        }
        [HttpPost]
        public IActionResult AddComment(NewsViewModel nvm)
        {
            if(HttpContext.Session.GetInt32("UserID") == null)
            {
                ViewBag.Message = "Je moet ingelogd zijn om een comment te plaatsen";
                return RedirectToAction("Index", new { newsID = nvm.NewsID });
            }
            CommentContainer commentContainer = new CommentContainer(new CommentDAL());
            Comment comment = new Comment();
            comment.Text = nvm.CreateCommentString;
            comment.UserID = (int)HttpContext.Session.GetInt32("UserID");
            comment.Datetime = DateTime.Now;
            comment.NewsID = nvm.NewsID;
            commentContainer.CreateComment(comment);
            return RedirectToAction("Index", new { newsID = nvm.NewsID });
        }
        public IActionResult DeleteComment(int id)
        {
            CommentContainer commentContainer  = new CommentContainer(new CommentDAL());
            commentContainer.DeleteComment(id);
            return RedirectToAction("Index");
        }

    }
}
