using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Candidat:User
    {
        [Required(ErrorMessage = "Veuillez entrer un prenom valide !")]
        public String name { get; set;}
        [Required(ErrorMessage = "Veuillez entrer un nom valide !")]
        public String lastname { get; set; }
        [Required(ErrorMessage = "Veuillez entrer une date de naissance valide !")]
        [DataType(DataType.Date)]
        public DateTime birthDate { get; set; }
        [Required(ErrorMessage = "Veuillez entrer un E-mail valide !")]
        public String Email { get; set; }
        [Required(ErrorMessage = "Veuillez entrer un adresse valide !")]
        public String address { get; set; }
        [DataType(DataType.MultilineText)]
        public String Skills { get; set; }
        [DataType(DataType.MultilineText)]
        public String experience { get; set; }
        private String actualPost { get; set; }
        [DataType(DataType.MultilineText)]
        public String bio { get; set; }
        public long phoneContact { get; set; }
        [DataType(DataType.Upload)]
        public String picture { get; set; }
        public virtual ICollection<Contacts> Contacts { get; set; }
        public virtual ICollection<Candidature> Candidatures { get; set; }
        public virtual ICollection<Entreprise> Entreprises { get; set; }
    }
}
