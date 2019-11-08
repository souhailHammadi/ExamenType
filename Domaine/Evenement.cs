using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Evenement
    {
        [Key]        
        public int evenementId { get; set; }

        public int? entrepriseId { get; set; }
        [ForeignKey("entrepriseId")]
        public virtual Entreprise entreprise { get; set; }
        public string titre { get; set; }
        public string description { get; set; }

    }
}
