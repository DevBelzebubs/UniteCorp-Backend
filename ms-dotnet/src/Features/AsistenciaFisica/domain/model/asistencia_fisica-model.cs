public class AsistenciaFisicaModel
{
    public int IdAsistencia { get; set; }
    public DateTime FechaHoraCheckIn { get; set; }
    public decimal LatitudRegistrada { get; set; }
    public decimal LongitudRegistrada { get; set; }
    public bool EsValida { get; set; }
    public int IdPuntoControl { get; set; }
    public int IdDispositivoVerificador { get; set; }
    public PuntoControlModel PuntoControl { get; set; } = null!;
    public DispositivoVerificadorModel DispositivoVerificador { get; set; } = null!;

    private AsistenciaFisicaModel() { }
}