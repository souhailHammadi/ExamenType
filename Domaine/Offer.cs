using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Offer
    {
        [Key]
        public int offerId { get; set; }
        public string titleOffer { get; set; }
        public string referenceOffer { get; set; }
        public string location { get; set; }
        public string durationOffer { get; set; }
        public float salary { get; set; }
        public string contractTypeOffer { get; set; }
        //foreign Key properties      
        public int? rhManagerId { get; set; }
        [ForeignKey("rhManagerId ")]
        public virtual RHmanager rHManager{ get; set; }

        //foreign Key properties      
        public int? projectManagerId { get; set; }
        [ForeignKey("projectManagerId ")]
        public virtual RHmanager projectManager { get; set; }

    }
}
