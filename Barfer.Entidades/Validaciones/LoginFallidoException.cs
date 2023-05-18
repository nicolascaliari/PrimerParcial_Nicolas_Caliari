using System.Runtime.Serialization;

namespace Barfer.Entidades.Validaciones
{
    [Serializable]
    public class LoginFallidoException : Exception
    {
        public LoginFallidoException()
        {
        }

        public LoginFallidoException(string? message) : base(message)
        {
        }

        public LoginFallidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected LoginFallidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}