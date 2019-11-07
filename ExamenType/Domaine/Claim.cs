using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    class Claim
    {

        [Key]
        public int ClaimId { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateClaim { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        //public User User { get; set; }

        //[ForeignKey("User")]
        //public int UserFK { get; set; }

        //public Interview Interview { get; set; }

        //[ForeignKey("Interview")]
        //public int InterviewFK { get; set; }


    }


}

