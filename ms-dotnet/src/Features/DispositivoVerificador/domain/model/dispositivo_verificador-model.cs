public class DispositivoVerificadorModel
{
    public int IdDispositivo { get; set; }
    public Guid Uuid { get; set; }
    public string NombreAsignado { get; set; } = string.Empty;
    public int IdOngCore { get; set; }
    public ICollection<AsistenciaFisicaModel> AsistenciasFisicas { get; set; } = new List<AsistenciaFisicaModel>();

    private DispositivoVerificadorModel() { }
}