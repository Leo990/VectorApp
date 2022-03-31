using System;
using System.Runtime.Serialization;

namespace Domain.Exceptions
{
    [Serializable]
    public class EspecializacionException : Exception
    {
        public EspecializacionException() :
            base()
        {
        }

        public EspecializacionException(string message) :
            base(message)
        {
        }

        public EspecializacionException(string message, Exception inner) :
            base(message, inner)
        {
        }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        protected EspecializacionException(
            SerializationInfo info,
            StreamingContext context
        ) :
            base(info, context)
        {
        }
    }
}
