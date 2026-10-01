using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CertificadoEmitidoConfig : IEntityTypeConfiguration<CertificadoEmitidoModel>
{
    public void Configure(EntityTypeBuilder<CertificadoEmitidoModel> builder)
    {
        builder.ToTable("CertificadoEmitido");
        builder.HasKey(x => x.IdCertificado);
        builder.HasOne(x => x.LoteEmision)
            .WithMany(x => x.CertificadosEmitidos)
            .HasForeignKey(x => x.IdLote)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(x => x.UrlDocumento).IsRequired();
        builder.Property(x => x.HashValidacion).IsRequired();
        builder.Property(x => x.HorasReconocidas).IsRequired();
        builder.Property(x => x.FechaEmision).IsRequired();
    }
}