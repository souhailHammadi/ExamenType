using Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenWeb.Controllers
{
    public class QuestionController : Controller
    {
        private ExamenContext DbContext = new ExamenContext();
        // GET: Question
        public ActionResult Index()
        {
            ViewBag.Questions = DbContext.Questions.ToList();
            return View();
        }

        [HttpPost]

        public ActionResult Submit(IFormCollection formCollection)
        {
            int score = 0;
            string[] questionIds = formCollection["questionId"];

            foreach (var questionId in questionIds)
            {
                int answerIdCorrect = DbContext.Questions.Find(int.Parse
                    (questionId)).Answers.Where(a => a.Correct == true).FirstOrDefault().AnswerID;


                if (answerIdCorrect == int.Parse(formCollection["question_" +
                    questionId]))
                {
                    score++;
                }
            }
            ViewBag.score = score;
            return View("Result");
        }
    }
}