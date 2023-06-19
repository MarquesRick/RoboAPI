using System.Runtime.Serialization;

namespace RoboAPI.Service.Util
{
    public class CustomValidationException : Exception
    {
        public string MensagemErro { get; set; }
        public string Titulo { get; set; }

        public CustomValidationException() : base() { }

        public CustomValidationException(string mensagem) : base(mensagem) { }

        public CustomValidationException(string mensagem, Exception inner) : base(mensagem, inner) { }

        public CustomValidationException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
