using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Enseignant
    {
        [Required(ErrorMessage = "Grade  Obligatoire")]
        public Grade Grade { get; set; }
        [Range(1, int.MaxValue)]
        public int Matricule { get; set; }
        [Required(ErrorMessage = "Specialite  Obligatoire")]
        public Specialite Specialite { get; set; }

        public virtual UP UP { get; set; }

        [ForeignKey("UPFK")]
        public string UPFK { get; set; }

        public virtual IList<Candidature> Candidatures { get; set; }

    }
}
