using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [StringLength(15, ErrorMessage = "Ne doit pas depassé 15 caractéres!")]
        public String login { get; set; }
        [StringLength(25, ErrorMessage = "Ne doit pas depassé 25 caractéres!")]
        [MinLength(8,ErrorMessage = "Au minimum 8 caractéres!")]
        public String password { get; set; }
    }
}
