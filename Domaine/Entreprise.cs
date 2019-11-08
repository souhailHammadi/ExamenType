using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Entreprise
    {
        [Key]
        [ForeignKey("adminEnt")]
        public int EntrepriseId { get; set; }
        public AdminEntreprise adminEnt { get; set; }
        public int nbEmployes { get; set; }
        public ICollection<Evenement> evenements { get; set; }
    }
}
