using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Contacts
    {
        [Key]
        public int ContactId { get; set; }
        public virtual User Users { get; set; }
        public int? UserId { get; set; }
        public String contactId1 { get; set; }
        public DateTime contactDate { get; set; }
    }
}
