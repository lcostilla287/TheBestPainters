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
        private MaterialService CreateMaterialService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new MaterialService(userId);
            return service;
        }
    }
}