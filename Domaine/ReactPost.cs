using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class ReactPost
    {
        [Key]

        public int ReactPostId { get; set; }


        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public int? UserId { get; set; }


        public string TypeReact { get; set; }


        [ForeignKey("PostId")]
        public virtual Post Posts { get; set; }
        public int? PostId { get; set; }


            



    }
}
