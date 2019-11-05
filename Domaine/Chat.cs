using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Chat
    {
        [Key]
        [Column(Order = 0)]
        public int ChatId { get; set; }

        [Column(Order = 1)]
        [ForeignKey("SendId")]
        public virtual User sendUser { get; set; }
        public int? SendId { get; set; }

        [Column(Order = 2)]
        [ForeignKey("RecieveId")]
        public virtual User RecieveUser { get; set; }
        public int? RecieveId { get; set; }

        [Column(Order = 3)]
        [StringLength(150, ErrorMessage = "nom ne doit pas dépasser 150")]
        [MaxLength(150)]
        public string Contenu { get; set; }

        [Column(Order = 4)]
        public int Vue { get; set; }

        [Column(Order = 5)]
        [DataType(DataType.Date)]
        public DateTime DateSend { get; set; }




    }
}
