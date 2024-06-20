using ApplicationCore.Domain;

namespace ApplicationCore.Interfaces
{
    public interface IServiceLivreur : IService<Livreur>
    {
        public double poidsTotal(string cin);
    }
}
