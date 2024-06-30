using CeramWorkshop.Data.Domain.InterfacesRepository;
using CeramWorkshop.Data.Domain.InterfacesWorker;

namespace Repository.Workers;

internal class ApiWorker : WorkerBase, IApiWorker
{
    public IImageInstructionRepository ImageInstructionRepository { get; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="context">Db Context</param>
    /// <param name="imageInstructionRepository">Image Repository</param>
    public ApiWorker(ApplicationDbContext context, IImageInstructionRepository imageInstructionRepository)
        : base(context)
    {
        ImageInstructionRepository = imageInstructionRepository;
    }
}