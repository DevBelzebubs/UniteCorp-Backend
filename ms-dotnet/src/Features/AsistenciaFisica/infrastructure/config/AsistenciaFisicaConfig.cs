using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AsistenciaFisicaConfig : IEntityTypeConfiguration<AsistenciaFisicaModel>
{
    public void Configure(EntityTypeBuilder<AsistenciaFisicaModel> builder)
    {
        builder.ToTable("AsistenciaFisica");
        builder.HasKey(x => x.IdAsistencia);
        builder.HasOne(x => x.PuntoControl)
            .WithMany(x => x.AsistenciasFisicas)
            .HasForeignKey(x => x.IdPuntoControl)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.DispositivoVerificador)
            .WithMany(x => x.AsistenciasFisicas)
            .HasForeignKey(x => x.IdDispositivoVerificador)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(x => x.FechaHoraCheckIn).IsRequired();
        builder.Property(x => x.LatitudRegistrada).IsRequired();
        builder.Property(x => x.LongitudRegistrada).IsRequired();
        builder.Property(x => x.EsValida).IsRequired();
    }
}