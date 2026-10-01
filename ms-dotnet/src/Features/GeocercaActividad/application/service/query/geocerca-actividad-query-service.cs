public class GeocercaActividadQueryService : IGeocercaActividadQueryService
{
    private readonly IGeocercaActividadRepository _geocercaActividadRepository;

    public GeocercaActividadQueryService(IGeocercaActividadRepository geocercaActividadRepository)
    {
        _geocercaActividadRepository = geocercaActividadRepository;
    }

    public async Task<GeocercaActividadModel?> GetByIdAsync(int id)
    {
        return await _geocercaActividadRepository.GetByIdAsync(id);
    }

    public async Task<List<GeocercaActividadModel>> GetAllAsync()
    {
        return await _geocercaActividadRepository.GetAllAsync();
    }
}