using ApplicationCore.Domain;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Services
{
    public class ServiceColis : Service<Colis>, IServiceColis
    {
        public ServiceColis(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public IEnumerable<Colis> getByLivreurGroupByClient(string cin)
        {
            return (IEnumerable<Colis>)GetMany().Where(x => x.LivreurFK == cin).GroupBy(x => x.ClientFK).ToList();
        }
    }
}
