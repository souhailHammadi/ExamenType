using Domaine;
using ExamenWeb.Models;
using Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenWeb.Controllers
{
    public class CandidatController : Controller
    {
        IServiceCandidat cs = new ServiceCandidat();
        IServiceUser us = new ServiceUser();
        public ActionResult ShowProfile()
        {
            Candidat cm = new Candidat();
            cm = cs.Get(t => t.UserId == 8);
            CandidatModels c = new CandidatModels();
            c.UserId = cm.UserId;
            c.password = cm.password;
            c.name = cm.name;
            c.lastname = cm.lastname;
            c.Mail = cm.Mail;
            c.login = cm.login;
            c.phoneContact = cm.phoneContact;
            c.address = cm.address;
            c.birthDate = cm.birthDate;
            c.Country = cm.Country;
            c.Skills = cm.Skills;
            c.bio = cm.bio;
            c.picture = cm.picture;
            c.experience = cm.experience;
            c.actualPost = cm.actualPost;

            return View(c);
        }

        // POST: Candidat/Create/5
        [HttpPost]
        public ActionResult ShowProfile(CandidatModels cm,HttpPostedFileBase file)
        {   
            if(!ModelState.IsValid || file == null || file.ContentLength == 0)
            {
                RedirectToAction("ShowProfile");
            }
            else
            {
                Candidat c = new Candidat();
                c = cs.Get(t => t.UserId == 8);
                c.name = cm.name;
                c.lastname = cm.lastname;
                c.phoneContact = cm.phoneContact;
                c.address = cm.address;
                c.birthDate = cm.birthDate;
                c.Country = cm.Country;
                c.Skills = cm.Skills;
                c.bio = cm.bio;
                c.picture = file.FileName;
                c.experience = cm.experience;
                c.actualPost = cm.actualPost;
                c.password = cm.password;
                cs.Update(c);
                cs.Commit();
                var fileName = "";
                if (file.ContentLength > 0)
                {
                    fileName = Path.GetFileName(file.FileName);
                    var path = Path. Combine(Server.MapPath("~/Content/Upload/"),fileName);
                    file.SaveAs(path);
                 }
                 TempData["Success"] = "Your Profil is Updated Successfully!";
                 
            }
            return RedirectToAction("Profil");
        }
        
        public ActionResult Profil()
        {
            return View();
        }
    }
}
