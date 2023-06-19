namespace RoboAPI.Domain.Entities
{
    public class RoboEntity : BaseEntity
    {
        public long CotoveloEsquerdo { get; set; }
        public long CotoveloDireito { get; set; }
        public long PulsoEsquerdo { get; set; }
        public long PulsoDireito { get; set; }
        public long CabecaRotacao { get; set; }
        public long CabecaInclinacao { get; set; }
    }
}
