namespace RoboAPI.Domain.Models
{
    public abstract class BaseModel
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private DateTime _dataCriacao;
        public DateTime DataCriacao
        {
            get { return _dataCriacao; }
            set
            {
                _dataCriacao = value == null ? DateTime.UtcNow : value;
            }
        }

        private DateTime _dataAtualizacao;
        public DateTime DataAtualizacao
        {
            get { return _dataAtualizacao; }
            set { _dataAtualizacao = value; }
        }
    }
}
