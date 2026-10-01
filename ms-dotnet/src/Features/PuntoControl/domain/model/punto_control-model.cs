public class PuntoControlModel
{
    public int IdPuntoControl { get; set; }

    public string NombreAcceso { get; set; } = string.Empty;
    public bool EsActivo { get; set; }
    public ICollection<GeocercaActividadModel> Geocercas { get; set; } = new List<GeocercaActividadModel>();
    public ICollection<AsistenciaFisicaModel> AsistenciasFisicas { get; set; } = new List<AsistenciaFisicaModel>();

    private PuntoControlModel() { }
}