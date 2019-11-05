using Data;
using Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenWeb.Controllers
{
    public class EntretienEnLigneController : Controller
    {
        public ExamenContext dbContext = new ExamenContext();

        [HttpGet]
        public ActionResult QuizTest()
        {
           
            IList<Question> questions = null;

          
                questions = dbContext.Question.Select(q => new Question
                   {
                       QuestionId = q.QuestionId,
                       Questions = q.Questions,
                       ListeChoix = q.ListeChoix.Select(c => new Choix
                       {
                           ChoixID = c.ChoixID,
                           ChoixText = c.ChoixText
                       }).ToList()

                   }).ToList();


            

            return View(questions);
        }

        [HttpPost]
        public ActionResult QuizTest(List<Reponse> resultQuiz)
        {
            List<Reponse> finalResultQuiz = new List<Reponse>();

            foreach (Reponse answser in resultQuiz)
            {
                Reponse result = dbContext.Reponse.Where(a => a.QuestionId == answser.QuestionId).Select(a => new Reponse
                {
                    QuestionId = a.QuestionId.Value,
                    AnswerQ = a.ReponseText,
                    isCorrect = (answser.AnswerQ.ToLower().Equals(a.ReponseText.ToLower()))

                }).FirstOrDefault();

                finalResultQuiz.Add(result);
            }

            return Json(new { result = finalResultQuiz }, JsonRequestBehavior.AllowGet);
        }


    }
}
