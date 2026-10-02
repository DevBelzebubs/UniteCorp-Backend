public interface IGeocercaActividadRepository
{
    Task<GeocercaActividadModel?> GetByIdAsync(int id);
    Task<List<GeocercaActividadModel>> GetAllAsync();
    Task AddAsync(GeocercaActividadDtoIn geocercaActividad);
    void Update(GeocercaActividadModel geocercaActividad);
    void Delete(GeocercaActividadModel geocercaActividad);
}