using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Day6MvcApp.Models;

namespace Day6MvcApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetServerTime()

        {

            System.Threading.Thread.Sleep(5000);

            return PartialView();

        }
        static List<User> users = new List<User>();
        public ActionResult GetAllUsers()

        {

            return PartialView(users);

        }
        public ActionResult CreateUser()

        {

            return View();

        }
        [HttpPost]

        public ActionResult CreateUser(User u)

        {

            users.Add(u);

            return RedirectToAction("GetAllUsers");

        }
       public ActionResult Sum()
        {
            int num1 =2, num2 = 3;
            int result = num1+ num2;
            ViewBag.Total = result;

            return View();
        }


    }
}