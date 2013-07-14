using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoneyRemittance.web.Controllers
{
    public class SendMoneyController : Controller
    {
        //
        // GET: /SendMoney/

        public ActionResult Index()
        {
            ViewBag.message = "Send Money Transaction";    
            return View();
        }

        //
        // GET: /SendMoney/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /SendMoney/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SendMoney/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /SendMoney/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /SendMoney/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /SendMoney/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /SendMoney/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
