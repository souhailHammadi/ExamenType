using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domaine
{
    public class ReactComment
    {
        [Key]

        public int ReactCommentId { get; set; }


        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public int? UserId { get; set; }


        public string TypeReact { get; set; }


        [ForeignKey("CommentId")]
        public virtual Comment Comments { get; set; }
        public int? CommentId { get; set; }





    }
}
