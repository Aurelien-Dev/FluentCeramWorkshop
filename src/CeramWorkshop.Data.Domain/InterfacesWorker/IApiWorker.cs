using CeramWorkshop.Data.Domain.InterfacesRepository;

namespace CeramWorkshop.Data.Domain.InterfacesWorker
{
    public  interface IApiWorker : IWorkerBase
    {
        IImageInstructionRepository ImageInstructionRepository { get; }
    }
}
