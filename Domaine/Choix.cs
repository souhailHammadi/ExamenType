using Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Choix
    {
        public int ChoixID { get; set; }
        public String ChoixText { get; set; }
        public int? QuestionId { get; set; }
        public virtual Question Question { get; set; }

    }
}
