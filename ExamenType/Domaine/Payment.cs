using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [DataType(DataType.Date)]

        public DateTime DatePayment { get; set; }
        public Double Amount { get; set; }

        //public User User { get; set; }

        //[ForeignKey("User")]
        //public int UserFK { get; set; }


    }
}
