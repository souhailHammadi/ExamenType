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
    public class RHAnswerController : Controller
    {
        private ExamenContext db = new ExamenContext();

        // GET: RHAnswer
        public ActionResult IndexC(int? QuestionID)
        {
            return View(db.Answers.Where(com => com.QuestionID == QuestionID).ToList());
        }

        public ActionResult Index()
        {
            return View(db.Answers.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: Comment/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "AnswerID,Content,QuestionID")] Answer ans)
        {
            if (ModelState.IsValid)
            {
                db.Answers.Add(ans);
                db.SaveChanges();
                return RedirectToAction("IndexC");
            }

            return View(ans);
        }



        // GET: Comment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Answer answer = db.Answers.Find(id);
            if (answer == null)
            {
                return HttpNotFound();
            }
            return View(answer);
        }



        // POST: Comment/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnswerID,Content,dateComment")] Answer answer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(answer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(answer);
        }

    }
}