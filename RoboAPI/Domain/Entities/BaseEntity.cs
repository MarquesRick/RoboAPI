using System.ComponentModel.DataAnnotations;

namespace RoboAPI.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public long Id { get; set; }
        private DateTime? _dataCriacao;
        public DateTime? DataCriacao
        {
            get { return _dataCriacao; }
            set { _dataCriacao = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? DataAtualizacao { get; set; }
    }
}
