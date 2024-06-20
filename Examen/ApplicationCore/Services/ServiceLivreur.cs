using ApplicationCore.Domain;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Services
{
    public class ServiceLivreur : Service<Livreur>, IServiceLivreur
    {
        public ServiceLivreur(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double poidsTotal(string cin)
        {
            double tot = 0;
            DateTime afterSeven = DateTime.Now.AddDays(7);
            ICollection<Livreur> ls = GetMany().Where(x => x.CIN == cin).ToList();
            foreach (var item in ls)
            {
                foreach (var c in item.Coliss)
                {
                    if (c.DateLivraison > DateTime.Now && c.DateLivraison < afterSeven)
                    {
                        tot += c.Poids;
                    }
                }
            }

            return tot;

        }
    }
}
