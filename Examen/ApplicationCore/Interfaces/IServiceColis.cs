using ApplicationCore.Domain;

namespace ApplicationCore.Interfaces
{
    public interface IServiceColis : IService<Colis>
    {
        IEnumerable<Colis> getByLivreurGroupByClient(string cin);
    }
}
