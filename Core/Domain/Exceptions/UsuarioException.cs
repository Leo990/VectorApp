using System;
using System.Runtime.Serialization;

namespace Domain.Exceptions
{
    [Serializable]
    public class UsuarioException : Exception
    {
        public UsuarioException() :
            base()
        {
        }

        public UsuarioException(string message) :
            base(message)
        {
        }

        public UsuarioException(string message, Exception inner) :
            base(message, inner)
        {
        }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        protected UsuarioException(
            SerializationInfo info,
            StreamingContext context
        ) :
            base(info, context)
        {
        }
    }
}
