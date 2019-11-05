using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Post
    {
        [Key]

        public int PostId { get; set; }



        [StringLength(150, ErrorMessage = "nom ne doit pas dépasser 150")]
        [MaxLength(150)]
        public string Contenu { get; set; }


        public int vue { get; set; }


        [DataType(DataType.Date)]
        public DateTime DatePost { get; set; }


        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public int? UserId { get; set; }

        public virtual ICollection<ReactPost> ListReacP { get; set; }
    }
}
