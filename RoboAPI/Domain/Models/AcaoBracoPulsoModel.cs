﻿namespace RoboAPI.Domain.Models
{
    public class AcaoBracoPulsoModel : BaseModel
    {
        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

    }
}
