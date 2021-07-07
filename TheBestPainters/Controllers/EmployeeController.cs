using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBestPainters.Controllers.EmployeeResponsibilities;
using TheBestPainters.Models.EmployeeModels;
using TheBestPainters.Services;

namespace TheBestPainters.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var service = CreateEmployeeService();
            var model = service.GetEmployees();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateEmployeeService();

            if (service.CreateEmployee(model))
            {
                TempData["SaveResult"] = "The Employee was created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Employee could not be created");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateEmployeeService();
            var model = svc.GetEmployeeById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateEmployeeService();
            var detail = service.GetEmployeeById(id);

            var model = EditEmployee.EditView(detail);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EmployeeEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.EmployeeId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateEmployeeService();

            if (service.UpdateEmployee(model))
            {
                TempData["SaveResult"] = "The Employee was updated";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The Employee could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateEmployeeService();
            var model = svc.GetEmployeeById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteEmployee(int id)
        {
            var svc = CreateEmployeeService();
            svc.DeleteEmployee(id);

            TempData["SaveResult"] = "The employee was deleted.";

            return RedirectToAction("Index");
        }
        private EmployeeService CreateEmployeeService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new EmployeeService(userId);
            return service;
        }
    }
}