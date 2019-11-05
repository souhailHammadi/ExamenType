using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class subscribe
    {
        [Key]
        public int subscribeId { get; set; }
        public virtual User Users { get; set; }
        public int? UserId { get; set; }
        public virtual Entreprise Entreprise { get; set; }
        public int? EntrepriseId { get; set; }
        [DataType(DataType.Date)]
        public DateTime subscribeDate { get; set; }
    }
}
