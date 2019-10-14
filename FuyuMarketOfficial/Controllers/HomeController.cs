using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FuyuMarketOfficial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("MainPage", "Home", null);

        }

        public ActionResult About()
        {


            return View();
        }

        public ActionResult Contact()
        {


            return View();
        }

        public ActionResult Video()
        {

            return View();
        }

        public ActionResult ChairmanMessage()
        {

            return View();
        }

        public ActionResult Foreword()
        {

            return View();
        }

        public ActionResult TestIndex()
        {

            return View();
        }

        public ActionResult MainPage()
        {

            return View();
        }
    }
}