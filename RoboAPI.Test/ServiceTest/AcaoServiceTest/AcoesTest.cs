using RoboAPI.Domain.Dtos.Acao;
using RoboAPI.Domain.Dtos.Robo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboAPI.Test.ServiceTest.AcaoServiceTest
{
    public class AcoesTest
    {
        public long Id { get; set; }
        public DateTime? DataCriacao { get; set; }
        public string Descricao { get; set; }

        public List<AcaoDto> listaAcaoDto = new();
        public AcaoDto acaoDto;
        public AcoesDto acoesDto;
        public List<AcoesDto> listaAcoesDto = new();

        public AcoesTest()
        {
            Id = 0;
            DataCriacao = DateTime.UtcNow;
            Descricao = "Teste";

            for (int i = 0; i < 10; i++)
            {
                var dto = new AcaoDto()
                {
                    Id = 0 + i,
                    Descricao = $"Teste {i}",
                    DataCriacao = DateTime.UtcNow
                };
                listaAcaoDto.Add(dto);
            }

            acaoDto = new AcaoDto
            {
                Id = Id,
                Descricao = Descricao,
                DataCriacao = DataCriacao
            };

            acoesDto = new AcoesDto
            {
                Id = Id,
                Descricao = Descricao,
                DataCriacao = DataCriacao,
                TipoAcao = 1
            };

            for (int i = 0; i < 10; i++)
            {
                var dto = new AcoesDto()
                {
                    Id = 0 + i,
                    Descricao = $"Teste {i}",
                    DataCriacao = DateTime.UtcNow,
                    TipoAcao = 1
                };
                listaAcoesDto.Add(dto);
            }
        }
    }
}
