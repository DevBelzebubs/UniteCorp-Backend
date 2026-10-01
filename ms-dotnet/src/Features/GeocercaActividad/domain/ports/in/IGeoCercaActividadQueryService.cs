public interface IGeocercaActividadQueryService
{
    Task<GeocercaActividadModel?> GetByIdAsync(int id);
    Task<List<GeocercaActividadModel>> GetAllAsync();
}