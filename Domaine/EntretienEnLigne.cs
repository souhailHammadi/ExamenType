using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class EntretienEnLigne:Entretien
    {
        public int EntretienEnLigneId { get; set; }
        public int noteEntretien { get; set; }

        //foreign Key properties      
        public int? QuestionId { get; set; } 
        [ForeignKey("QuestionId ")]     
        public virtual Question Question { get; set; } 
        public ICollection<Question> ListeQuestions { get; set; }
    }
}
