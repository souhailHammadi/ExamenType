using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class EntretienEnLigne
    {
        public int EntretienEnLigneId { get; set; }
        public int noteEntretien { get; set; }

        //foreign Key properties      
        
        public ICollection<Question> ListeQuestions { get; set; }
    }
}
