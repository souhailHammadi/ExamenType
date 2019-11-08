using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class ProjectManager
    {
        [Key]
        [ForeignKey("team")]
        public int projectManagerId { get; set; }
        
        public virtual Team team { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string mail { get; set; }
        public string contact { get; set; }

       
        
        public ICollection<Offer> offerListProjectManager { get; set; }

        public const string role = "projectmanager";
    }
}
