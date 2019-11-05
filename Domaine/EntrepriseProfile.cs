using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class EntrepriseProfile
    {
        [Key]
        [Column(Order = 0)]
        public int profileID { get; set;}


        [Column(Order = 1)]
        [ForeignKey("AdminEntID")]
        public virtual AdminEntreprise adminEnt { get; set; }
        public int? adminEntID { get; set; }



        [Column(Order = 2)]
        public string contact { get; set; }


        [Column(Order = 3)]
        public string description { get; set; }


        [Column(Order = 4)]
        public ArrayList events { get; set; }

        [Column(Order = 5)]
        public int empNumber { get; set; }
       
    }
}
