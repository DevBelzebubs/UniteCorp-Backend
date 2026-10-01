public class LoteEmisionModel
{
    public int IdLote { get; set; }
    public int TotalProcesados { get; set; }
    public string Estado { get; set; } = string.Empty;
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }

    private LoteEmisionModel() { }
}