using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Concours
    {
        [Required(ErrorMessage = "Grade Fete Obligatoire")]
        public DateTime DateDebut { get; set; }
        [Required(ErrorMessage = "Grade Fete Obligatoire")]
        public DateTime DateFin { get; set; }
        public int NbrEM { get; set; }
        public int NbrGC { get; set; }

        public int NbrGED { get; set; }
        public int Nbrlangue { get; set; }
        public int NbrMath { get; set; }
        public int NbrTIC { get; set; }
        [Range(2003, int.MaxValue,ErrorMessage = "promotion must be > 2003")]
        public int promotion { get; set; }

        public virtual IList<Candidature> Candidatures { get; set; }

    }
}
