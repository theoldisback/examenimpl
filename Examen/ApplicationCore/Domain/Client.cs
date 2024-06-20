namespace ApplicationCore.Domain
{
    public class Client
    {
        public string CodePostal { get; set; }
        public int id { get; set; }
        public string Name { get; set; }
        public string Prenom { get; set; }
        public string Ville { get; set; }

        public virtual ICollection<Colis> Coliss { get; set; }


    }
}
