using Data;
using Domaine;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ExamenWeb.Controllers
{
    public class ReactCommentController : Controller
    {
        private ExamenContext db = new ExamenContext();
        // GET: ReactComment
        public ActionResult Index()
        {
            return View(db.ReactComment.ToList());
        }

        // GET: ReactComment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReactComment reactcomment = db.ReactComment.Find(id);
            if (reactcomment == null)
            {
                return HttpNotFound();
            }
            return View(reactcomment);
        }

        // GET: ReactComment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReactComment/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "ReactCommentId,TypeReact,CommentId,UserId")] ReactComment reactcomment)
        {
            if (ModelState.IsValid)
            {
                db.ReactComment.Add(reactcomment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reactcomment);
        }

        // GET: ReactComment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReactComment/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ReactComment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReactComment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReactComment reactcomment = db.ReactComment.Find(id);
            db.ReactComment.Remove(reactcomment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
