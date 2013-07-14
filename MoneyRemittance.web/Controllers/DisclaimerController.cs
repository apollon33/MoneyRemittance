using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoneyRemittance.web.Controllers
{
    public class DisclaimerController : Controller
    {
        //
        // GET: /Disclaimer/

        public ActionResult Index()
        {
            ViewBag.Message = "Security Disclaimer";
            return View();
        }

        public ActionResult Privacy()
        {
            ViewBag.Message = "Site Privacy";
            return View();
        }

        public ActionResult Agreement()
        {
            ViewBag.Message = "Rules and Agreement";
            return View();
        }

        public ActionResult Sitemap()
        {
            ViewBag.Message = "Sitemap";
            return View();
        }
    }
}
