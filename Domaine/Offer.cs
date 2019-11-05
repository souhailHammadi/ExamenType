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
        [Column(Order = 0)]
        private int offerID { get; set; }

        [Column(Order = 2)]
        [ForeignKey("pMOfferID")]
        public virtual projectManager pMOffer { get; set; }
        public int? pMOfferID { get; set; }


        [Column(Order = 3)]
        [ForeignKey("rHOfferID")]
        public RHmanager rHMOffer { get; set; }
        public int? rHOfferID { get; set; }



        [Column(Order = 4)]
        private string titleOffer { get; set; }

        [Column(Order = 5)]
        private string referenceOffer { get; set; }

        [Column(Order = 6)]
        private string locationOffer { get; set; }

        [Column(Order = 7)]
        private string durationOffer { get; set; }

        [Column(Order = 8)]
        private string contactOffer { get; set; }
       
        



    }
}
