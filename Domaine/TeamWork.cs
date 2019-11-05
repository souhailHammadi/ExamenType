
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domaine
{
    public class TeamWork
    {
        public TeamWork()
        {
            /*adminTeam = new AdminEntreprise();
            managerPrTeam = new projectManager();
            managerRhTeam = new RHmanager();*/
        }
        [Key]
        [Column(Order = 0)]
        public int teamID { get; set; }

        [Column(Order = 1)]
        [ForeignKey("adminTeamID")]
        public  AdminEntreprise adminTeam { get; set; }
        public int? adminTeamID { get; set; }

        [Column(Order = 2)]
        [ForeignKey("managerPrTeamID")]
        public  projectManager managerPrTeam { get; set; }
        public int? managerPrTeamID { get; set; }

        [Column(Order = 3)]
        [ForeignKey("managerRhTeamID")]
        public virtual RHmanager managerRhTeam { get; set; }
        public int? managerRhTeamID { get; set; }
    }
}
