using System;

namespace mwo.SimpleDI
{
    [Serializable]
    public class DuplicateRegistrationException : InvalidOperationException
    {
        public DuplicateRegistrationException(Type t) : base($"There is already a Registration for <{t.FullName}>")
        {
        }

        public DuplicateRegistrationException(string message) : base(message)
        {
        }

        public DuplicateRegistrationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public DuplicateRegistrationException() : base()
        {
        }

        protected DuplicateRegistrationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {
        }
    }
}
