public interface IGeocercaActividadCommandService
{
    Task<GeocercaActividadDtoIn> CreateAsync(GeocercaActividadDtoIn geocercaActividad);
    Task<GeocercaActividadModel> UpdateAsync(GeocercaActividadModel geocercaActividad);
    Task DeleteAsync(int id);
}