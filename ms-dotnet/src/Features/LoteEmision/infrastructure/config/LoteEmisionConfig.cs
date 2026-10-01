using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class LoteEmisionConfig : IEntityTypeConfiguration<LoteEmisionModel>
{
    public void Configure(EntityTypeBuilder<LoteEmisionModel> builder)
    {
        builder.ToTable("LoteEmision");
        builder.HasKey(x => x.IdLote);
        builder.Property(x => x.TotalProcesados).IsRequired();
        builder.Property(x => x.Estado).IsRequired();
        builder.Property(x => x.FechaInicio).IsRequired();
        builder.Property(x => x.FechaFin).IsRequired();
    }
}