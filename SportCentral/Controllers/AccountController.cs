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
    public class AccountController : Controller
    {
        UserDAL UserDAL = new UserDAL();

        [HttpPost]
        public IActionResult AddAccount(UserViewModel uvm)
        {
            if (!ModelState.IsValid)
                return View();

            UserContainer userContainer = new UserContainer(UserDAL);
            User user = UserConvertorr.ConvertToUser(uvm);
            if (!userContainer.CreateUser(user))
            {
                ViewBag.Message = "Deze gebruiker heeft al een account";
                return View();
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AddAccount()
        {
            {
                return View();
            }
        }
        public IActionResult Login()
        {
            UserViewModel user = new UserViewModel();
            return View(user);
        }

        [HttpPost]
        public IActionResult Login(UserViewModel uvm)
        {
            User user = new User();
            user.Email = uvm.Email;
            user.Password = uvm.Password;
            UserContainer userContainer = new UserContainer(UserDAL);
            if (userContainer.UserExistsByEmailAndPassword(user))
            {
                User LoggedPlayer = userContainer.GetUser(user);
                if (LoggedPlayer.Rank == Rank.User)
                {
                    HttpContext.Session.SetString("Rank", "User");
                    HttpContext.Session.SetInt32("UserID", LoggedPlayer.UserID);
                    return RedirectToAction("Index", "Home");
                }

                if (LoggedPlayer.Rank == Rank.Moderator)
                {
                    HttpContext.Session.SetString("Rank", "Moderator");
                    HttpContext.Session.SetInt32("UserID", LoggedPlayer.UserID);
                    return RedirectToAction("Index", "Home");
                }
                HttpContext.Session.SetString("Rank", "Super-Admin");
                HttpContext.Session.SetInt32("UserID", LoggedPlayer.UserID);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Rank");
            HttpContext.Session.Remove("UserID");
            return RedirectToAction("Index", "Home");
        }

    }
}

