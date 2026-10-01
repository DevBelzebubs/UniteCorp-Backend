using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class GeocercaActividadConfig : IEntityTypeConfiguration<GeocercaActividadModel>
{
    public void Configure(EntityTypeBuilder<GeocercaActividadModel> builder)
    {
        builder.ToTable("GeocercaActividad");
        builder.HasKey(x => x.IdGeocerca);
        builder.Property(x => x.NombreGeocerca).IsRequired();
        builder.Property(x => x.LatitudCentro).IsRequired();
        builder.Property(x => x.LongitudCentro).IsRequired();
        builder.Property(x => x.RadioMetros).IsRequired();
    }
}