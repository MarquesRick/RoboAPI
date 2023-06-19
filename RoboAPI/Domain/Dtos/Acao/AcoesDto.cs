namespace RoboAPI.Domain.Dtos.Acao
{
    public class AcoesDto
    {
        public long Id { get; set; }
        public DateTime? DataCriacao { get; set; }
        public string Descricao { get; set; }
        public long TipoAcao { get; set;}
    }
}
