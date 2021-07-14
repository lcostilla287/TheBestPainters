using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBestPainters.Controllers.CrewResponsibilities;
using TheBestPainters.Models.CrewModels;
using TheBestPainters.Services;

namespace TheBestPainters.Controllers
{
    public class CrewController : Controller
    {
        // GET: Crew
        public ActionResult Index()
        {
            var service = CreateCrewService();
            var model = service.GetCrews();
            return View(model);
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CrewCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateCrewService();

            if (service.CreateCrew(model))
            {
                TempData["SaveResult"] = "The Crew was Created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Crew could not be created");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateCrewService();
            var model = svc.GetCrewById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateCrewService();
            var detail = service.GetCrewById(id);

            var model = EditCrew.EditView(detail);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CrewEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.CrewId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateCrewService();

            if (service.UpdateCrew(model))
            {
                TempData["SaveResult"] = "Your Crew was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The Crew could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateCrewService();
            var model = svc.GetCrewById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCrew(int id)
        {
            var service = CreateCrewService();

            service.DeleteCrew(id);

            TempData["SaveResult"] = "The crew was deleted";

            return RedirectToAction("Index");
        }

        private ICrewService CreateCrewService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = InstantiateServices.CrewService(userId);
            return service;
        }
    }
}