using System.Runtime.Serialization;

namespace Barfer.Entidades.Validaciones
{
    [Serializable]
    public class preparacionesCargadasException : Exception
    {
        public preparacionesCargadasException()
        {
        }

        public preparacionesCargadasException(string? message) : base(message)
        {
        }

        public preparacionesCargadasException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected preparacionesCargadasException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}