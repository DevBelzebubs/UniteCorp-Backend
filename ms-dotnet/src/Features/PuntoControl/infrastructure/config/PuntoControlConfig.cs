using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PuntoControlConfig : IEntityTypeConfiguration<PuntoControlModel>
{
    public void Configure(EntityTypeBuilder<PuntoControlModel> builder)
    {
        builder.ToTable("PuntoControl");
        builder.HasKey(x => x.IdPuntoControl);
        builder.HasMany(x => x.Geocercas)
            .WithOne()
            .HasForeignKey(x => x.IdPuntoControl)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(x => x.NombreAcceso).IsRequired();
        builder.Property(x => x.EsActivo).IsRequired();
    }
}