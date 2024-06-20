using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Domain
{
    public class Livreur
    {
        [Key]
        public string CIN { get; set; }
        public string CodePostal { get; set; }
        public string RaisonSocial { get; set; }
        public string Ville { get; set; }

        public virtual ICollection<Vehicule> Vehicules { get; set; }
        public virtual ICollection<Colis> Coliss { get; set; }
    }
}
