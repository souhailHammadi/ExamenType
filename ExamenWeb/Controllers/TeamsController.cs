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
    public class TeamsController : Controller
    {
        private ExamenContext db = new ExamenContext();

        // GET: Teams
        public ActionResult Index()
        {
            var teams = db.Teams.Include(t => t.adminEntreprise).Include(t => t.projectManager).Include(t => t.rhManager);
            return View(teams.ToList());
        }

        // GET: Teams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Team team = db.Teams.Find(id);
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
        }

        // GET: Teams/Create
        public ActionResult Create()
        {
            ViewBag.teamId = new SelectList(db.AdminsEntreprises, "adminId", "name");
            ViewBag.teamId = new SelectList(db.ProjectsManagers, "projectManagerId", "name");
            ViewBag.teamId = new SelectList(db.RHmanagers, "rhManagerId", "name");
            return View();
        }

        // POST: Teams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "teamId")] Team team)
        {
            if (ModelState.IsValid)
            {
                db.Teams.Add(team);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.teamId = new SelectList(db.AdminsEntreprises, "adminId", "name", team.teamId);
            ViewBag.teamId = new SelectList(db.ProjectsManagers, "projectManagerId", "name", team.teamId);
            ViewBag.teamId = new SelectList(db.RHmanagers, "rhManagerId", "name", team.teamId);
            return View(team);
        }

        // GET: Teams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Team team = db.Teams.Find(id);
            if (team == null)
            {
                return HttpNotFound();
            }
            ViewBag.teamId = new SelectList(db.AdminsEntreprises, "adminId", "name", team.teamId);
            ViewBag.teamId = new SelectList(db.ProjectsManagers, "projectManagerId", "name", team.teamId);
            ViewBag.teamId = new SelectList(db.RHmanagers, "rhManagerId", "name", team.teamId);
            return View(team);
        }

        // POST: Teams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "teamId")] Team team)
        {
            if (ModelState.IsValid)
            {
                db.Entry(team).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.teamId = new SelectList(db.AdminsEntreprises, "adminId", "name", team.teamId);
            ViewBag.teamId = new SelectList(db.ProjectsManagers, "projectManagerId", "name", team.teamId);
            ViewBag.teamId = new SelectList(db.RHmanagers, "rhManagerId", "name", team.teamId);
            return View(team);
        }

        // GET: Teams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Team team = db.Teams.Find(id);
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
        }

        // POST: Teams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Team team = db.Teams.Find(id);
            db.Teams.Remove(team);
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
