namespace RoboAPI.Domain.Dtos.Robo
{
    public class RoboDto
    {
        public long Id { get; set; }
        public long CotoveloEsquerdo { get; set; }
        public long CotoveloDireito { get; set; }
        public long PulsoEsquerdo { get; set; }
        public long PulsoDireito { get; set; }
        public long CabecaRotacao { get; set; }
        public long CabecaInclinacao { get; set; }
        public DateTime DataAtualizacao { get; set; } = DateTime.UtcNow;
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
    }
}
