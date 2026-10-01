using Microsoft.EntityFrameworkCore;

public class GeocercaActividadRepository : IGeocercaActividadRepository
{
    private readonly DbContext _dbContext;

    public GeocercaActividadRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddAsync(GeocercaActividadModel geocercaActividad)
    {
        await _dbContext.Set<GeocercaActividadModel>().AddAsync(geocercaActividad);
    }

    public void Update(GeocercaActividadModel geocercaActividad)
    {
        _dbContext.Set<GeocercaActividadModel>().Update(geocercaActividad);
    }

    public void Delete(GeocercaActividadModel geocercaActividad)
    {
        _dbContext.Set<GeocercaActividadModel>().Remove(geocercaActividad);
    }

    public async Task<GeocercaActividadModel?> GetByIdAsync(int id)
    {
        return await _dbContext.Set<GeocercaActividadModel>().FindAsync(id);
    }

    public async Task<List<GeocercaActividadModel>> GetAllAsync()
    {
        return await _dbContext.Set<GeocercaActividadModel>().ToListAsync();
    }
}