using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class GeoCercaActividadController : ControllerBase{
    private readonly IGeocercaActividadCommandService commandService;
    public GeoCercaActividadController(IGeocercaActividadCommandService commandService)
    {
        this.commandService = commandService;
    }
    [HttpPost]
    public async void CrearGeocercaActividad([FromBody] GeocercaActividadDtoIn geocercaActividad)
    {
        await commandService.CreateAsync(geocercaActividad);
    }
}