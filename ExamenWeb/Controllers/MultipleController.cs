using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExamenWeb.Models;
using Data;
using Domaine;

namespace ExamenWeb.Controllers
{
    public class MultipleController : Controller
    {
        private ExamenContext db = new ExamenContext();
        // GET: Comment
        // GET: Multip
        
        public ActionResult Index( int? PostId)
        {
            var mymodel = new Multiple();
            mymodel.commentdetails = db.Comment.Where(com => com.PostId == PostId).ToList();
            mymodel.postdetails = db.Post.Where(pos => pos.PostId == PostId).ToList();
                //db.Post.Where(pos => pos.PostId == PostId).ToList();

           

            return View(mymodel);
           
        }





        // GET: Comment/Create
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int? PostId , [Bind(Include = "CommentId,contenu,dateComment,PostId,UserId")] Comment comment)
        {
            
            if (ModelState.IsValid)
            {
               
                db.Comment.Add(comment);
               
                db.SaveChanges();
                return RedirectToAction("Index",new { PostId=PostId});
            }

            return View(comment);
        }
    }
}