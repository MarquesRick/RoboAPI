namespace RoboAPI.Domain.Models
{
    public class RoboModel : BaseModel
    { 
        private long _cotoveloEsquerdo;
        public long CotoveloEsquerdo
        {
            get { return _cotoveloEsquerdo; }
            set { _cotoveloEsquerdo = value; }
        }

        private long _cotoveloDireito;
        public long CotoveloDireito
        {
            get { return _cotoveloDireito; }
            set { _cotoveloDireito = value; }
        }

        private long _pulsoEsquerdo;
        public long PulsoEsquerdo
        {
            get { return _pulsoEsquerdo; }
            set { _pulsoEsquerdo = value; }
        }
        private long _pulsoDireito;
        public long PulsoDireito
        {
            get { return _pulsoDireito; }
            set { _pulsoDireito = value; }
        }

        private long _cabecaRotacao;
        public long CabecaRotacao
        {
            get { return _cabecaRotacao; }
            set { _cabecaRotacao = value; }
        }

        private long _cabecaInclinacao;
        public long CabecaInclinacao
        {
            get { return _cabecaInclinacao; }
            set { _cabecaInclinacao = value; }
        }
    }
}
