using MoneyRemittance.model;
using MoneyRemittance.model.Interface;
using MoneyRemittance.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoneyRemittance.web.Controllers
{
    public class CustomerController : Controller
    {
        /// <summary>
        /// Customer Account Controller
        /// </summary>
        /// <returns></returns>

        private readonly ICustomerDataSource _db;

        public CustomerController(ICustomerDataSource db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var allCustomers = _db.Customers;
            return View(allCustomers);
        }

        [HttpGet]
        [ChildActionOnly]
        public ActionResult _Create()
        {
            return PartialView("_Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult _Create(CreateCustomerViewModel custViewModel)
        {
            bool isAllValid = false;

            if (ModelState.IsValid)
            {
                //This where new customer data entered by a valid user account.
                var customer = new Customer();
                var custaccount = new CustomerAccount();

                customer.CustFName = custViewModel.FirstName;
                customer.CustLName = custViewModel.LastName;
                customer.IAgree = custViewModel.Agree;
                customer.DateRegistered = DateTime.Now;

                if (custViewModel.EmailAdd == custViewModel.ConfirmEmailAdd)
                {
                    customer.CustEmail = custViewModel.EmailAdd;
                    isAllValid = true;
                }
                else { isAllValid = false; }

                if (custViewModel.Password == custViewModel.ConfirmPassword)
                {
                    custaccount.CustPassword = custViewModel.Password;
                    isAllValid = true;
                }
                else { isAllValid = false; }

                if (isAllValid == true)
                {
                    _db.Save();

                    return RedirectToAction("Login", "Customer", new { id = custViewModel.CustId });
                }
                //else
                //{
                //    //Ajax result...
                //}
            }

            return View(custViewModel);
        }

        public ActionResult Login(CustomerAccountViewModel custAccountModel)
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                base.Dispose(disposing);
            }
        }
    }
}
