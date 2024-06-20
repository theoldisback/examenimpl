using ApplicationCore.Domain;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Services
{
    public class ServiceClient : Service<Client>, IServiceClient
    {
        public ServiceClient(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
