using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboAPI.Domain.Entities;

namespace RoboAPI.Data.Mapping
{
    public class AcaoCabecaRotacaoMap : IEntityTypeConfiguration<AcaoCabecaRotacaoEntity>
    {
        public void Configure(EntityTypeBuilder<AcaoCabecaRotacaoEntity> builder)
        {
            builder.ToTable("AcaoCabecaRotacao");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Descricao)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(u => u.DataCriacao);
        }
    }
}
