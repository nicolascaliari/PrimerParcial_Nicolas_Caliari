using System.Runtime.Serialization;

namespace Barfer.Entidades.Validaciones
{
    [Serializable]
    public class ExceptionCampos : Exception
    {
        public ExceptionCampos()
        {
        }

        public ExceptionCampos(string? message) : base(message)
        {
        }

        public ExceptionCampos(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ExceptionCampos(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}