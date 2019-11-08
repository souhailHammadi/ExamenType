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
    public class RHmanagersController : Controller
    {
        private ExamenContext db = new ExamenContext();

        // GET: RHmanagers
        public ActionResult Index()
        {
            var rHmanagers = db.RHmanagers.Include(r => r.team);
            return View(rHmanagers.ToList());
        }

        // GET: RHmanagers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RHmanager rHmanager = db.RHmanagers.Find(id);
            if (rHmanager == null)
            {
                return HttpNotFound();
            }
            return View(rHmanager);
        }

        // GET: RHmanagers/Create
        public ActionResult Create()
        {
            ViewBag.rhManagerId = new SelectList(db.Teams, "teamId", "teamId");
            return View();
        }

        // POST: RHmanagers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "rhManagerId,name,surname,mail,contact")] RHmanager rHmanager)
        {
            if (ModelState.IsValid)
            {
                db.RHmanagers.Add(rHmanager);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.rhManagerId = new SelectList(db.Teams, "teamId", "teamId", rHmanager.rhManagerId);
            return View(rHmanager);
        }

        // GET: RHmanagers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RHmanager rHmanager = db.RHmanagers.Find(id);
            if (rHmanager == null)
            {
                return HttpNotFound();
            }
            ViewBag.rhManagerId = new SelectList(db.Teams, "teamId", "teamId", rHmanager.rhManagerId);
            return View(rHmanager);
        }

        // POST: RHmanagers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "rhManagerId,name,surname,mail,contact")] RHmanager rHmanager)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rHmanager).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.rhManagerId = new SelectList(db.Teams, "teamId", "teamId", rHmanager.rhManagerId);
            return View(rHmanager);
        }

        // GET: RHmanagers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RHmanager rHmanager = db.RHmanagers.Find(id);
            if (rHmanager == null)
            {
                return HttpNotFound();
            }
            return View(rHmanager);
        }

        // POST: RHmanagers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RHmanager rHmanager = db.RHmanagers.Find(id);
            db.RHmanagers.Remove(rHmanager);
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
