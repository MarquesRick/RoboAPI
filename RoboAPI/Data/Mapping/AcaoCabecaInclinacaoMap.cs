using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboAPI.Domain.Entities;

namespace RoboAPI.Data.Mapping
{
    public class AcaoCabecaInclinacaoMap : IEntityTypeConfiguration<AcaoCabecaInclinacaoEntity>
    {
        public void Configure(EntityTypeBuilder<AcaoCabecaInclinacaoEntity> builder)
        {
            builder.ToTable("AcaoCabecaInclinacao");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Descricao)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(u => u.DataCriacao);
        }
    }
}
