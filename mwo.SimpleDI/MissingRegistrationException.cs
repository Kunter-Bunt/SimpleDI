using System;

namespace mwo.SimpleDI
{
    [Serializable]
    public class MissingRegistrationException : InvalidOperationException
    {
        public MissingRegistrationException(Type t) : base($"Nothing registered for <{t.FullName}>")
        {
        }

        public MissingRegistrationException(string message) : base(message)
        {
        }

        public MissingRegistrationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public MissingRegistrationException() : base()
        {
        }

        protected MissingRegistrationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {
        }
    }
}
