using CeramWorkshop.Data.Domain.InterfacesRepository;
using CeramWorkshop.Data.Domain.InterfacesWorker;

namespace Domain.InterfacesWorker
{
    public interface IProductWorker : IWorkerBase
    {
        IProductRepository ProductRepository { get; }
        IMaterialRepository MaterialRepository { get; }
        IFiringRepository FiringRepository { get; }
        IImageInstructionRepository ImageInstructionRepository { get; }
    }
}
