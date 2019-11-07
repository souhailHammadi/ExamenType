using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Entreprise
    {
        [Key]
        public int EntrepriseId { get; set; }
    }
}
