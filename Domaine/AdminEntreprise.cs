using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class AdminEntreprise
    {
        [Key]
        [Column(Order = 0)]
        public int adminID {get;set;}

        [Column(Order = 1)]
        [ForeignKey("teamAdminEntID")]
        public virtual TeamWork teamAdminEnt { get; set; }
        public int? teamAdminEntID { get; set; }

        [Column(Order = 2)]
        [ForeignKey("profileID")]
        public virtual EntrepriseProfile profile { get; set; }
        public int? profileID { get; set; }


        [Column(Order = 3)]
        public string nameAdmin { get; set; }

        [Column(Order = 4)]
        public string surnameAdmin { get; set; }

        [Column(Order = 5)]
        public string mailAdmin { get; set; }

        [Column(Order = 6)]
        public string contactAdmin { get; set; }
       


    }
}
