using System.ComponentModel.DataAnnotations;

namespace RoboAPI.Domain.Dtos.Robo
{
    public class RoboUpdateDto
    {
        [Required(ErrorMessage = "Id é um campo obrigatório")]
        public long Id { get; set; }
        [Required(ErrorMessage = "Cotovelo do braço esquerdo é um campo obrigatório")]
        public long CotoveloEsquerdo { get; set; }
        [Required(ErrorMessage = "Cotovelo do braço direito é um campo obrigatório")]
        public long CotoveloDireito { get; set; }

        [Required(ErrorMessage = "Pulso do braço esquerdo é um campo obrigatório")]
        public long PulsoEsquerdo { get; set; }
        [Required(ErrorMessage = "Pulso do braço direito é um campo obrigatório")]
        public long PulsoDireito { get; set; }
        [Required(ErrorMessage = "A rotação da cabeça é um campo obrigatório")]
        public long CabecaRotacao { get; set; }

        [Required(ErrorMessage = "A inclinação da cabeça é um campo obrigatório")]
        public long CabecaInclinacao { get; set; }
        public DateTime DataAtualizacao { get; set; } = DateTime.UtcNow;
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
    }
}
