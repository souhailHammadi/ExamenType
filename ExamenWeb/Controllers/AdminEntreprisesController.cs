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
    public class AdminEntreprisesController : Controller
    {
        private ExamenContext db = new ExamenContext();

        // GET: AdminEntreprises
        public ActionResult Index()
        {
            var adminsEntreprises = db.AdminsEntreprises.Include(a => a.entreprise).Include(a => a.team);
            return View(adminsEntreprises.ToList());
        }

        // GET: AdminEntreprises/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminEntreprise adminEntreprise = db.AdminsEntreprises.Find(id);
            if (adminEntreprise == null)
            {
                return HttpNotFound();
            }
            return View(adminEntreprise);
        }

        // GET: AdminEntreprises/Create
        public ActionResult Create()
        {
            ViewBag.adminId = new SelectList(db.Entreprise, "EntrepriseId", "EntrepriseId");
            ViewBag.adminId = new SelectList(db.Teams, "teamId", "teamId");
            return View();
        }

        // POST: AdminEntreprises/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "adminId,name,surname,mail,contact")] AdminEntreprise adminEntreprise)
        {
            if (ModelState.IsValid)
            {
                db.AdminsEntreprises.Add(adminEntreprise);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.adminId = new SelectList(db.Entreprise, "EntrepriseId", "EntrepriseId", adminEntreprise.adminId);
            ViewBag.adminId = new SelectList(db.Teams, "teamId", "teamId", adminEntreprise.adminId);
            return View(adminEntreprise);
        }

        // GET: AdminEntreprises/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminEntreprise adminEntreprise = db.AdminsEntreprises.Find(id);
            if (adminEntreprise == null)
            {
                return HttpNotFound();
            }
            ViewBag.adminId = new SelectList(db.Entreprise, "EntrepriseId", "EntrepriseId", adminEntreprise.adminId);
            ViewBag.adminId = new SelectList(db.Teams, "teamId", "teamId", adminEntreprise.adminId);
            return View(adminEntreprise);
        }

        // POST: AdminEntreprises/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "adminId,name,surname,mail,contact")] AdminEntreprise adminEntreprise)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adminEntreprise).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.adminId = new SelectList(db.Entreprise, "EntrepriseId", "EntrepriseId", adminEntreprise.adminId);
            ViewBag.adminId = new SelectList(db.Teams, "teamId", "teamId", adminEntreprise.adminId);
            return View(adminEntreprise);
        }

        // GET: AdminEntreprises/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminEntreprise adminEntreprise = db.AdminsEntreprises.Find(id);
            if (adminEntreprise == null)
            {
                return HttpNotFound();
            }
            return View(adminEntreprise);
        }

        // POST: AdminEntreprises/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdminEntreprise adminEntreprise = db.AdminsEntreprises.Find(id);
            db.AdminsEntreprises.Remove(adminEntreprise);
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
