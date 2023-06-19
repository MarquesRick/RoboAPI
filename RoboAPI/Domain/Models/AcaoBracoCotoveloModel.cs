namespace RoboAPI.Domain.Models
{
    public class AcaoBracoCotoveloModel : BaseModel
    {
        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
    }
}
