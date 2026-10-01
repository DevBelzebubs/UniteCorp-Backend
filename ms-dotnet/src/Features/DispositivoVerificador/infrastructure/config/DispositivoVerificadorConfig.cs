using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class DispositivoVerificadorConfig : IEntityTypeConfiguration<DispositivoVerificadorModel>
{
    public void Configure(EntityTypeBuilder<DispositivoVerificadorModel> builder)
    {
        builder.ToTable("DispositivoVerificador");
        builder.HasKey(x => x.IdDispositivo);
        builder.Property(x => x.Uuid).IsRequired();
        builder.Property(x => x.NombreAsignado).IsRequired();
        builder.Property(x => x.IdOngCore).IsRequired();
    }
}