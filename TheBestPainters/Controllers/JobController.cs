using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBestPainters.Controllers.JobResponsibilites;
using TheBestPainters.Data;
using TheBestPainters.Models.JobModels;
using TheBestPainters.Services;
using TheBestPainters.Services.Instantiate;

namespace TheBestPainters.Controllers
{
    public class JobController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Job
        public ActionResult Index()
        {
            var service = CreateJobService();
            var model = service.GetJobs();

            return View(model);
        }

        // GET
        public ActionResult Create()
        {
            var model1 = InstantiateModels.JobCreate();
            //JobCreate model = new JobCreate();

                var crews = _db.Crews.ToArray();
            model1.Crews = new SelectList(crews, "CrewId", "CrewName");
            return View(model1);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(JobCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateJobService();

            if (service.CreateJob(model))
            {
                TempData["SaveResult"] = "The Job was added.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Job could not be created");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateJobService();
            var model = svc.GetJobById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateJobService();
            var detail = service.GetJobById(id);

            var model = EditJob.EditView(detail);
            return View(model);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, JobEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.JobId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateJobService();

            if (service.UpdateJob(model))
            {
                TempData["SaveResult"] = "Your job was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The job could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateJobService();
            var model = svc.GetJobById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteJob(int id)
        {
            var service = CreateJobService();

            service.DeleteJob(id);

            TempData["SaveResult"] = "The job was deleted";

            return RedirectToAction("Index");
        }
        private IJobService CreateJobService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = InstantiateServices.JobService(userId);
            return service;
        }
    }
}