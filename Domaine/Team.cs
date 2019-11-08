using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Team
    {
        [Key]
        public int teamId { get; set; }

        public virtual RHmanager rhManager { get; set; }

        public virtual ProjectManager projectManager { get; set; }

        public virtual AdminEntreprise adminEntreprise { get; set; }

    }
}
