using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBestPainters.Models.MaterialModels;
using TheBestPainters.Services;

namespace TheBestPainters.Controllers
{
    public class MaterialController : Controller
    {
        // GET: Material
        public ActionResult Index()
        {
            var service = CreateMaterialService();
            var model = service.GetMaterials();

            return View(model);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MaterialCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateMaterialService();

            if (service.CreateMaterial(model))
            {
                TempData["SaveResult"] = "The Material was added.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Material could not be added.");
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateMaterialService();
            var model = svc.GetMaterialById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateMaterialService();
            var detail = service.GetMaterialById(id);
            var model =
                new MaterialEdit
                {
                    MaterialId = detail.MaterialId,
                    MaterialName = detail.MaterialName,
                    JobId = detail.JobId,
                    Price = detail.Price,
                    Quantity = detail.Quantity
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MaterialEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.MaterialId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateMaterialService();

            if (service.UpdateMaterial(model))
            {
                TempData["SaveResult"] = "The Material was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The Material could not be updated.");
            return View(model);
        }
        private MaterialService CreateMaterialService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new MaterialService(userId);
            return service;
        }
    }
}