using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Candidature
    {
        [Key]
        public int candidatureId { get; set; }
        public virtual User Users { get; set; }
        public int? UserId { get; set; }
        //[ForeignKey("Offer")]
        //private int offerId { get; set; }
        public DateTime candidatureDate { get; set; }
        [DataType(DataType.Date)]
        public String etat { get; set; }
        
    }
}
