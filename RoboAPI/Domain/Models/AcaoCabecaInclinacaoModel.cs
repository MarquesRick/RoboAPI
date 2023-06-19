namespace RoboAPI.Domain.Models
{
    public class AcaoCabecaInclinacaoModel : BaseModel
    {
        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

    }
}
