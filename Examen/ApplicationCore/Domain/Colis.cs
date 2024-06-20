using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Domain
{
    public class Colis
    {
        public DateTime DateLivraison { get; set; }
        public double montant { get; set; }
        public double Poids { get; set; }
        public double Volume { get; set; }

        [ForeignKey("Client")]
        public string ClientFK { get; set; }

        [ForeignKey("Livreur")]
        public string LivreurFK { get; set; }

    }
}
