using Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
   public class Reponse
    {
        public int ReponseID { get; set; }
        public String ReponseText { get; set; }
        public int? QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public bool isCorrect { get; set; }
        public string AnswerQ { get; set; }



    }
}
