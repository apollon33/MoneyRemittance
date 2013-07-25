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

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message1 = "We're here to help";

            //Sample
            //IndexViewModel viewModel = new IndexViewModel();
            //viewModel.Countries = new SelectList(GetCountries(), "ID", "Name");

            return View();
        }

        [HttpPost]
        public ActionResult Index()
        {

            //Sample
            //viewModel.Countries = new SelectList(GetCountries(), "ID", "Name");
            //if (!ModelState.IsValid)
            //    return View(viewModel);

            ////TODO: Do something with the selected country...
            //CMSService.UpdateCurrentLocation(viewModel.CountryID);

            return View(viewModel);

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
