using RoboAPI.Domain.Dtos.Robo;

namespace RoboAPI.Test.ServiceTest.RoboServiceTest
{
    public class RobosTest
    {
        public long Id { get; set; }
        public long CotoveloEsquerdo { get; set; }
        public long CotoveloDireito { get; set; }
        public long PulsoEsquerdo { get; set; }
        public long PulsoDireito { get; set; }
        public long CabecaRotacao { get; set; }
        public long CabecaInclinacao { get; set; }

        public List<RoboDto> listaRoboDto = new();
        public RoboDto roboDto;
        public RoboUpdateDto roboUpdateDto;

        public RobosTest()
        {
            Id = 0;
            CotoveloEsquerdo = 0;
            CotoveloDireito = 0;
            PulsoEsquerdo = 0;
            PulsoDireito = 0;
            CabecaRotacao = 0;
            CabecaInclinacao = 0;

            for (int i = 0; i < 10; i++)
            {
                var dto = new RoboDto()
                {
                    Id = 0 + i,
                    CotoveloEsquerdo = 0 + i,
                    CotoveloDireito = 0 + i,
                    PulsoEsquerdo = 0 + i,
                    PulsoDireito = 0 + i,
                    CabecaRotacao = 0 + i,
                    CabecaInclinacao = 0 + i
                };
                listaRoboDto.Add(dto);
            }

            roboDto = new RoboDto
            {
                Id = Id,
                CotoveloEsquerdo = CotoveloEsquerdo,
                CotoveloDireito = CotoveloDireito,
                PulsoEsquerdo = PulsoEsquerdo,
                PulsoDireito = PulsoDireito,
                CabecaRotacao = CotoveloEsquerdo,
                CabecaInclinacao = CabecaInclinacao
            };

            roboUpdateDto = new RoboUpdateDto
            {
                Id = Id,
                CotoveloEsquerdo = CotoveloEsquerdo,
                CotoveloDireito = CotoveloDireito,
                PulsoEsquerdo = PulsoEsquerdo,
                PulsoDireito = PulsoDireito,
                CabecaRotacao = CotoveloEsquerdo,
                CabecaInclinacao = CabecaInclinacao
            };
        }
    }
}
