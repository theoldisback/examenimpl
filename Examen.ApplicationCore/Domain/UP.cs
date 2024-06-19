using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class UP
    {
        public string Code { get; set; }
        public string Nom { get; set; }
        public string Responsable { get; set; }

         public virtual IList<Enseignant> Enseignants { get; set;}
    }
}
