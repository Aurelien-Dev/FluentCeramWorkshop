using CeramWorkshop.Data.Domain.InterfacesRepository;

namespace CeramWorkshop.Data.Domain.InterfacesWorker;

public  interface IWorkshopWorker : IWorkerBase
{
    IWorkshopRepository WorkshopRepository { get; }
}