using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Candidature
    {
        public DateTime DateDepot { get; set; }
        public DateTime DateEntretien { get; set; }
        public DateTime DateEpreuve { get; set; }
        public string Dossier { get; set; }
        public bool Resultat { get; set; }
        public float Score { get; set; }

        public int EnseignantFk { get; set; }
        public int ConcoursFK { get; set; }
        public virtual Enseignant Enseignant { get; set; }

        public virtual Concours Concours { get; set; }
    }
}
