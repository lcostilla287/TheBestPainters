using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBestPainters.Controllers.CustomerResponsibilities;
using TheBestPainters.Models.CustomerModels;
using TheBestPainters.Services;

namespace TheBestPainters.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            var service = CreateCustomerService();
            var model = service.GetCustomers();

            return View(model);
        }

        // GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateCustomerService();

            if (service.CreateCustomer(model))
            {
                TempData["SaveResult"] = "Your Customer was added.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Customer could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateCustomerService();
            var model = svc.GetCustomerById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateCustomerService();
            var detail = service.GetCustomerById(id);

            var model = Edit_Customer.EditView(detail);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if(model.CustomerId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateCustomerService();

            if (service.UpdateCustomer(model))
            {
                TempData["SaveResult"] = "Your Customer was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your customer could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateCustomerService();
            var model = svc.GetCustomerById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateCustomerService();
            service.DeleteCustomer(id);

            TempData["SaveResult"] = "Your customer was deleted";

            return RedirectToAction("Index");
        }

        private ICustomerService CreateCustomerService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            ICustomerService service = InstantiateServices.CustomerService(userId);
            return service;
        }
    }
}