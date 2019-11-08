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
        [ForeignKey("team")]
        public int rhManagerId { get; set; }


        public Team team { get; set; }



        public string name { get; set; }
        public string surname { get; set; }
        public string mail { get; set; }
        public string contact { get; set; }

        public ICollection<Offer> offerListRhManager { get; set; }
        public const string role = "rhmanager";
    }
}
