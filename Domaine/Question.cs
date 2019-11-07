using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Question
    {

        public Question()
        {
            Answers = new HashSet<Answer>();
        }
        public int QuestionID { get; set; }
        public String Content { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
