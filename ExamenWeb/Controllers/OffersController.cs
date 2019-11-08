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
    public class OffersController : Controller
    {
        private ExamenContext db = new ExamenContext();

        // GET: Offers
        public ActionResult Index()
        {
            var offers = db.Offers.Include(o => o.projectManager).Include(o => o.rHManager);
            return View(offers.ToList());
        }

        // GET: Offers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Offer offer = db.Offers.Find(id);
            if (offer == null)
            {
                return HttpNotFound();
            }
            return View(offer);
        }

        // GET: Offers/Create
        public ActionResult Create()
        {
            ViewBag.projectManagerId = new SelectList(db.RHmanagers, "rhManagerId", "name");
            ViewBag.rhManagerId = new SelectList(db.RHmanagers, "rhManagerId", "name");
            return View();
        }

        // POST: Offers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "offerId,titleOffer,referenceOffer,location,durationOffer,salary,contractTypeOffer,rhManagerId,projectManagerId")] Offer offer)
        {
            if (ModelState.IsValid)
            {
                db.Offers.Add(offer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.projectManagerId = new SelectList(db.RHmanagers, "rhManagerId", "name", offer.projectManagerId);
            ViewBag.rhManagerId = new SelectList(db.RHmanagers, "rhManagerId", "name", offer.rhManagerId);
            return View(offer);
        }

        // GET: Offers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Offer offer = db.Offers.Find(id);
            if (offer == null)
            {
                return HttpNotFound();
            }
            ViewBag.projectManagerId = new SelectList(db.RHmanagers, "rhManagerId", "name", offer.projectManagerId);
            ViewBag.rhManagerId = new SelectList(db.RHmanagers, "rhManagerId", "name", offer.rhManagerId);
            return View(offer);
        }

        // POST: Offers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "offerId,titleOffer,referenceOffer,location,durationOffer,salary,contractTypeOffer,rhManagerId,projectManagerId")] Offer offer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(offer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.projectManagerId = new SelectList(db.RHmanagers, "rhManagerId", "name", offer.projectManagerId);
            ViewBag.rhManagerId = new SelectList(db.RHmanagers, "rhManagerId", "name", offer.rhManagerId);
            return View(offer);
        }

        // GET: Offers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Offer offer = db.Offers.Find(id);
            if (offer == null)
            {
                return HttpNotFound();
            }
            return View(offer);
        }

        // POST: Offers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Offer offer = db.Offers.Find(id);
            db.Offers.Remove(offer);
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
