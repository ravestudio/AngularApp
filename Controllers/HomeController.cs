using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SimpleApp()
        {
            return View();
        }

        public ActionResult GreetingController()
        {
            return View();
        }

        public ActionResult TwoWayBinding()
        {
            return View();
        }

        public ActionResult Blogger()
        {
            return View();
        }

        public ActionResult ApplyInAction()
        {
            return View();
        }

        public ActionResult EventsInAction()
        {
            return View();
        }

        public ActionResult MultipleViews()
        {
            return View();
        }

        public ActionResult UIRoutting()
        {
            return View();
        }

        public ActionResult Validation()
        {
            return View();
        }
    }
}
