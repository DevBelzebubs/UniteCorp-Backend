public interface IGeocercaActividadCommandService
{
    Task<GeocercaActividadModel> CreateAsync(GeocercaActividadModel geocercaActividad);
    Task<GeocercaActividadModel> UpdateAsync(GeocercaActividadModel geocercaActividad);
    Task DeleteAsync(int id);
}