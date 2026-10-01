public class DispositivoVerificadorModel
{
    public int IdDispositivo { get; set; }
    public Guid Uuid { get; set; }
    public string NombreAsignado { get; set; } = string.Empty;
    public int IdOngCore { get; set; }

    private DispositivoVerificadorModel() { }
}