using System.ComponentModel.DataAnnotations;

public class GeocercaActividadDtoIn
{
    [Required]
    public required string NombreGeocerca { get; set; }
    public double LatitudCentro { get; set; }
    public double LongitudCentro { get; set; }
    public double RadioMetros { get; set; }
}