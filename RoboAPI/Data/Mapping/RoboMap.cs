using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RoboAPI.Domain.Entities;

namespace RoboAPI.Data.Mapping
{
    public class RoboMap : IEntityTypeConfiguration<RoboEntity>
    {
        public void Configure(EntityTypeBuilder<RoboEntity> builder)
        {
            builder.ToTable("Robo");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.CotoveloEsquerdo)
                   .IsRequired();

            builder.Property(u => u.CotoveloDireito)
                   .IsRequired();

            builder.Property(u => u.PulsoEsquerdo)
                   .IsRequired();

            builder.Property(u => u.PulsoDireito)
                   .IsRequired();

            builder.Property(u => u.CabecaRotacao)
                   .IsRequired();

            builder.Property(u => u.CabecaInclinacao)
                   .IsRequired();

            builder.Property(u => u.DataCriacao);

            builder.Property(u => u.DataAtualizacao);
        }
    }
}
