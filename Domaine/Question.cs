using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Question
    {
        public int QuestionId { get; set; }
        public String Questions { get; set; }
        public int NoteQuestion { get; set; }

        public String ReponseCorrect { get; set; }
        public String ReponseIncorrect1 { get; set; }
        public String ReponseIncorrect2 { get; set; }

        public virtual EntretienEnLigne EntretienEnLigne { get; set; }


    }
}
