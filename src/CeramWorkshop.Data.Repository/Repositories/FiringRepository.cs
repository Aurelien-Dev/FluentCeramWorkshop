using CeramWorkshop.Data.Domain.InterfacesRepository;
using CeramWorkshop.Data.Domain.Models.MainDomain;

namespace Repository.Repositories;

public class FiringRepository : GenericRepository<Firing, int>, IFiringRepository
{
    public FiringRepository(ApplicationDbContext context) : base(context) { }
}