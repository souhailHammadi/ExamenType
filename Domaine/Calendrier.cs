using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
   public class Calendrier
    {
        [Key]
        public int CalendrierId { get; set; }
        public String disponibilite { get; set; }
        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        public float heure { get; set; }
    }
}
