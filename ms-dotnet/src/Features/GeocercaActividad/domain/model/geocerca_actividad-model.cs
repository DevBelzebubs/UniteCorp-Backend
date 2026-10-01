public class GeocercaActividadModel
{
    public int IdGeocerca { get; set; }
    public int IdPuntoControl { get; set; }
    public string NombreGeocerca { get; set; } = string.Empty;
    public decimal LatitudCentro { get; set; }
    public decimal LongitudCentro { get; set; }
    public decimal RadioMetros { get; set; }

    private GeocercaActividadModel() { }
}