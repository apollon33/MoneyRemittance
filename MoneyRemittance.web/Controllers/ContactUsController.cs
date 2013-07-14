using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoneyRemittance.web.Controllers
{
    public class ContactUsController : Controller
    {
        /// <summary>
        /// Contact Us Controller
        /// </summary>
        /// <returns></returns>

        public ActionResult Index()
        {
            ViewBag.Message1 = "We're here to help";
            return View();
        }

        public ActionResult Follow()
        {
            ViewBag.Message = "Follow Us at Twitter, Facebook or Linkedin";
            return View();
        }

        [HttpGet]
        [ChildActionOnly]
        public ActionResult _Create()
        {
            return PartialView("_Create");
        }
    }
}
