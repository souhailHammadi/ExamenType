using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class RHmanager
    {
        [Key]
        [Column(Order = 0)]
        private int RHMID { get; set; }

        [Column(Order = 1)]
        [ForeignKey("teamRHID")]
        public virtual TeamWork teamRH { get; set; }
        public int? teamRHID { get; set; }

        [Column(Order = 2)]
        private string nameRH { get; set; }

        [Column(Order = 3)]
        private string surnameRH { get; set; }

        [Column(Order = 4)]
        private string mailRH { get; set; }

        [Column(Order = 5)]
        private string contactRH { get; set; }
       
        public virtual ICollection<Offer> offersRHManager { get; set; }

    }
}
