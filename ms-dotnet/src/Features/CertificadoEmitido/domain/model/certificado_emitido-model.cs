public class CertificadoEmitidoModel
{
    public int IdCertificado { get; set; }

    public string UrlDocumento { get; set; } = string.Empty;
    public string HashValidacion { get; set; } = string.Empty;
    public int HorasReconocidas { get; set; }
    public DateTime FechaEmision { get; set; }
    public int IdLote { get; set; }
    public LoteEmisionModel LoteEmision { get; set; } = null!;

    private CertificadoEmitidoModel() { }
}