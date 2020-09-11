using System;

namespace mwo.SimpleDI
{
    /// <summary>
    /// The exception is thrown if the state of the registrations is not correct while resolving.
    /// </summary>
    [Serializable]
    public class MissingRegistrationException : InvalidOperationException
    {
        /// <summary>
        /// Initializes a new instance of the mwo.SimpleDI.MissingRegistrationException class.
        /// </summary>
        /// <param name="t">The type that was missing a registration, is wrapped into a message that describes the error.</param>
        public MissingRegistrationException(Type t) : base($"Nothing registered for <{t.FullName}>")
        {
        }

        /// <summary>
        /// Initializes a new instance of the mwo.SimpleDI.MissingRegistrationException class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public MissingRegistrationException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the mwo.SimpleDI.MissingRegistrationException class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public MissingRegistrationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the mwo.SimpleDI.MissingRegistrationException class.
        /// </summary>
        public MissingRegistrationException() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the mwo.SimpleDI.MissingRegistrationException class with serailized data.
        /// </summary>
        /// <param name="serializationInfo">The object that holds the serialized object data.</param>
        /// <param name="streamingContext">The contextual information about the source or destination.</param>
        protected MissingRegistrationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {
        }
    }
}
