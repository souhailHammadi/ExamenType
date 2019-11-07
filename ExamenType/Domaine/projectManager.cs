using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class projectManager
    {
        [Key]
        [Column(Order = 0)]
        private int ManagerID { get; set; }

        [Column(Order = 1)]
        [ForeignKey("teamPMID")]
        public virtual TeamWork teamPM { get; set; }
        public int? temPMID { get; set; }

        [Column(Order = 2)]
        private string nameManager { get; set; }

        [Column(Order = 3)]
        private string surnameManager { get; set; }

        [Column(Order = 4)]
        private int numberManager{ get; set; }

        [Column(Order = 5)]
        private string contactManager { get; set; }
       
        public virtual ICollection<Offer> offersManager { get; set; }

    }
}
