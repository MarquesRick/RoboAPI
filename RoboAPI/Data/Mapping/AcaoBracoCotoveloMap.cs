using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboAPI.Domain.Entities;
namespace RoboAPI.Data.Mapping
{
    public class AcaoBracoCotoveloMap : IEntityTypeConfiguration<AcaoBracoCotoveloEntity>
    {
        public void Configure(EntityTypeBuilder<AcaoBracoCotoveloEntity> builder)
        {
            builder.ToTable("AcaoBracoCotovelo");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Descricao)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(u => u.DataCriacao);
        }
    }
}
