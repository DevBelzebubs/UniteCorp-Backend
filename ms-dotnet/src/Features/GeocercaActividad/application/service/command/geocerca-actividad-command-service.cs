using UniteCorp.SharedKernel;

public class GeocercaActividadCommandService : IGeocercaActividadCommandService
{
    private readonly IGeocercaActividadRepository _geocercaActividadRepository;
    private readonly IUnitOfWork _unitOfWork;

    public GeocercaActividadCommandService(IGeocercaActividadRepository geocercaActividadRepository, IUnitOfWork unitOfWork)
    {
        _geocercaActividadRepository = geocercaActividadRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<GeocercaActividadDtoIn> CreateAsync(GeocercaActividadDtoIn geocercaActividad)
    {
        await _geocercaActividadRepository.AddAsync(geocercaActividad);
        await _unitOfWork.CommitAsync();
        return geocercaActividad;
    }

    public async Task<GeocercaActividadModel> UpdateAsync(GeocercaActividadModel geocercaActividad)
    {
        _geocercaActividadRepository.Update(geocercaActividad);
        await _unitOfWork.CommitAsync();
        return geocercaActividad;
    }

    public async Task DeleteAsync(int id)
    {
        var geocercaActividad = await _geocercaActividadRepository.GetByIdAsync(id);
        if (geocercaActividad is not null)
        {
            _geocercaActividadRepository.Delete(geocercaActividad);
            await _unitOfWork.CommitAsync();
        }
    }
}