using MoneyRemittance.model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoneyRemittance.web.Controllers
{
    public class MainController : Controller
    {
        /// <summary>
        /// Money Remittance Main Controller 
        /// </summary>
        /// <returns></returns>

        public ActionResult Index()
        {
            ViewBag.message = "Online Money Remittance";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.message = "About Us";
            return View();
        }

        public ActionResult Support()
        {
            ViewBag.message = "Online Support for Money Remittance";
            return View();
        }

        public ActionResult Prices()
        {
            ViewBag.message = "Money Remittance Pricing";
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
