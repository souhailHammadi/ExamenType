using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Data;
using Domaine;

namespace ExamenWeb.Controllers
{
    public class ProjectManagersController : Controller
    {
        private ExamenContext db = new ExamenContext();

        // GET: ProjectManagers
        public ActionResult Index()
        {
            var projectsManagers = db.ProjectsManagers.Include(p => p.team);
            return View(projectsManagers.ToList());
        }

        // GET: ProjectManagers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectManager projectManager = db.ProjectsManagers.Find(id);
            if (projectManager == null)
            {
                return HttpNotFound();
            }
            return View(projectManager);
        }

        // GET: ProjectManagers/Create
        public ActionResult Create()
        {
            ViewBag.projectManagerId = new SelectList(db.Teams, "teamId", "teamId");
            return View();
        }

        // POST: ProjectManagers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "projectManagerId,name,surname,mail,contact")] ProjectManager projectManager)
        {
            if (ModelState.IsValid)
            {
                db.ProjectsManagers.Add(projectManager);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.projectManagerId = new SelectList(db.Teams, "teamId", "teamId", projectManager.projectManagerId);
            return View(projectManager);
        }

        // GET: ProjectManagers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectManager projectManager = db.ProjectsManagers.Find(id);
            if (projectManager == null)
            {
                return HttpNotFound();
            }
            ViewBag.projectManagerId = new SelectList(db.Teams, "teamId", "teamId", projectManager.projectManagerId);
            return View(projectManager);
        }

        // POST: ProjectManagers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "projectManagerId,name,surname,mail,contact")] ProjectManager projectManager)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectManager).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.projectManagerId = new SelectList(db.Teams, "teamId", "teamId", projectManager.projectManagerId);
            return View(projectManager);
        }

        // GET: ProjectManagers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectManager projectManager = db.ProjectsManagers.Find(id);
            if (projectManager == null)
            {
                return HttpNotFound();
            }
            return View(projectManager);
        }

        // POST: ProjectManagers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjectManager projectManager = db.ProjectsManagers.Find(id);
            db.ProjectsManagers.Remove(projectManager);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
