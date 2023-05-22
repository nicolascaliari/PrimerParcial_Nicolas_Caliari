using System.Runtime.Serialization;

namespace Barfer.Entidades.Validaciones
{
    [Serializable]
    public class AltaFallidoException : Exception
    {
        public AltaFallidoException()
        {
        }

        public AltaFallidoException(string? message) : base(message)
        {
        }

        public AltaFallidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AltaFallidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}