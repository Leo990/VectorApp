using System;
using System.Runtime.Serialization;

namespace Domain.Exceptions
{
    [Serializable]
    public class TelefonoException : Exception
    {
        public TelefonoException() :
            base()
        {
        }

        public TelefonoException(string message) :
            base(message)
        {
        }

        public TelefonoException(string message, Exception inner) :
            base(message, inner)
        {
        }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        protected TelefonoException(
            SerializationInfo info,
            StreamingContext context
        ) :
            base(info, context)
        {
        }
    }
}
