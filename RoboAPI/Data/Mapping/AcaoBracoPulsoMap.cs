using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboAPI.Domain.Entities;

namespace RoboAPI.Data.Mapping
{
    public class AcaoBracoPulsoMap : IEntityTypeConfiguration<AcaoBracoPulsoEntity>
    {
        public void Configure(EntityTypeBuilder<AcaoBracoPulsoEntity> builder)
        {
            builder.ToTable("AcaoBracoPulso");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Descricao)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(u => u.DataCriacao);
        }
    }
}
