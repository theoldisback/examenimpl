using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Domain
{
    public class Vehicule
    {
        public string Couleur { get; set; }
        public string Marque { get; set; }
        [Key]
        public string Matricule { get; set; }

        public int VitesseLimite { get; set; }

        public virtual ICollection<Livreur> Livreurs { get; set; }
    }
}
