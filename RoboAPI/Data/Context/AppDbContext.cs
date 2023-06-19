using Microsoft.EntityFrameworkCore;
using RoboAPI.Data.Mapping;
using RoboAPI.Domain;
using RoboAPI.Domain.Entities;
using RoboAPI.Domain.Models;

namespace RoboAPI.Data.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<AcaoBracoCotoveloEntity> AcaoBracoCotovelo { get; set; }
        public DbSet<AcaoBracoPulsoEntity> AcaoBracoPulso { get; set; }
        public DbSet<AcaoCabecaInclinacaoEntity> AcaoCabecaInclinacao { get; set; }
        public DbSet<AcaoCabecaRotacaoEntity> AcaoCabecaRotacao { get; set; }
        public DbSet<RoboEntity> Robo { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("DataSource=Data\\app.db;Cache=Shared");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcaoBracoCotoveloEntity>(new AcaoBracoCotoveloMap().Configure);
            modelBuilder.Entity<AcaoBracoPulsoEntity>(new AcaoBracoPulsoMap().Configure);
            modelBuilder.Entity<AcaoCabecaInclinacaoEntity>(new AcaoCabecaInclinacaoMap().Configure);
            modelBuilder.Entity<AcaoCabecaRotacaoEntity>(new AcaoCabecaRotacaoMap().Configure);
            modelBuilder.Entity<RoboEntity>(new RoboMap().Configure);

            modelBuilder.Entity<AcaoBracoCotoveloEntity>().HasData(
                new AcaoBracoCotoveloEntity
                {
                    Id = (long)Acoes.Cotovelo.Repouso,
                    Descricao = "Em Repouso",
                    DataCriacao = DateTime.UtcNow
                },
                new AcaoBracoCotoveloEntity
                {
                    Id = (long)Acoes.Cotovelo.LevementeContraido,
                    Descricao = "Levemente Contraído",
                    DataCriacao = DateTime.UtcNow
                },
                new AcaoBracoCotoveloEntity
                {
                    Id = (long)Acoes.Cotovelo.Contraido,
                    Descricao = "Contraído",
                    DataCriacao = DateTime.UtcNow
                },
                new AcaoBracoCotoveloEntity
                {
                    Id = (long)Acoes.Cotovelo.FortementeContraido,
                    Descricao = "Fortemente Contraído",
                    DataCriacao = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<AcaoBracoPulsoEntity>().HasData(
            new AcaoBracoPulsoEntity
            {
                Id = (long)Acoes.Pulso.RotacaoMenos90,
                Descricao = "Rotação para -90°",
                DataCriacao = DateTime.UtcNow
            },
            new AcaoBracoPulsoEntity
            {
                Id = (long)Acoes.Pulso.RotacaoMenos45,
                Descricao = "Rotação para -45°",
                DataCriacao = DateTime.UtcNow
            },
            new AcaoBracoPulsoEntity
            {
                Id = (long)Acoes.Pulso.Repouso,
                Descricao = "Em Repouso",
                DataCriacao = DateTime.UtcNow
            },
            new AcaoBracoPulsoEntity
            {
                Id = (long)Acoes.Pulso.Rotacao45,
                Descricao = "Rotação para 45°",
                DataCriacao = DateTime.UtcNow
            },
            new AcaoBracoPulsoEntity
            {
                Id = (long)Acoes.Pulso.Rotacao90,
                Descricao = "Rotação para 90°",
                DataCriacao = DateTime.UtcNow
            },
            new AcaoBracoPulsoEntity
            {
                Id = (long)Acoes.Pulso.Rotacao135,
                Descricao = "Rotação para 135°",
                DataCriacao = DateTime.UtcNow
            },
            new AcaoBracoPulsoEntity
            {
                Id = (long)Acoes.Pulso.Rotacao180,
                Descricao = "Rotação para 180°",
                DataCriacao = DateTime.UtcNow
            }
           );

            modelBuilder.Entity<AcaoCabecaInclinacaoEntity>().HasData(
                new AcaoCabecaInclinacaoEntity
                {
                    Id = (long)Acoes.Inclinacao.ParaCima,
                    Descricao = "Para Cima",
                    DataCriacao = DateTime.UtcNow
                },
                new AcaoCabecaInclinacaoEntity
                {
                    Id = (long)Acoes.Inclinacao.Repouso,
                    Descricao = "Em Repouso",
                    DataCriacao = DateTime.UtcNow
                },
                new AcaoCabecaInclinacaoEntity
                {
                    Id = (long)Acoes.Inclinacao.ParaBaixo,
                    Descricao = "Para Baixo",
                    DataCriacao = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<AcaoCabecaRotacaoEntity>().HasData(
              new AcaoCabecaRotacaoEntity
              {
                  Id = (long)Acoes.Rotacao.RotacaoMenos90,
                  Descricao = "Rotação -90°",
                  DataCriacao = DateTime.UtcNow
              },
              new AcaoCabecaRotacaoEntity
              {
                  Id = (long)Acoes.Rotacao.RotacaoMenos45,
                  Descricao = "Rotação -45°",
                  DataCriacao = DateTime.UtcNow
              },
              new AcaoCabecaRotacaoEntity
              {
                  Id = (long)Acoes.Rotacao.Repouso,
                  Descricao = "Em Repouso",
                  DataCriacao = DateTime.UtcNow
              },
              new AcaoCabecaRotacaoEntity
              {
                  Id = (long)Acoes.Rotacao.Rotacao45,
                  Descricao = "Rotação 45°",
                  DataCriacao = DateTime.UtcNow
              },
              new AcaoCabecaRotacaoEntity
              {
                  Id = (long)Acoes.Rotacao.Rotacao90,
                  Descricao = "Rotação 90°",
                  DataCriacao = DateTime.UtcNow
              }
          );

            modelBuilder.Entity<RoboEntity>().HasData(
                new RoboEntity
                {
                    Id = 1,
                    CotoveloDireito = (long)Acoes.Cotovelo.Repouso,
                    CotoveloEsquerdo = (long)Acoes.Cotovelo.Repouso,
                    PulsoDireito = (long)Acoes.Pulso.Repouso,
                    PulsoEsquerdo = (long)Acoes.Pulso.Repouso,
                    CabecaInclinacao = (long)Acoes.Inclinacao.Repouso,
                    CabecaRotacao = (long)Acoes.Rotacao.Repouso
                }    
            );
        }
    }
}
