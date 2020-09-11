using System;

namespace mwo.SimpleDI
{
    /// <summary>
    /// The exception is thrown if the state of the registrations is not correct while registering.
    /// </summary>
    [Serializable]
    public class DuplicateRegistrationException : InvalidOperationException
    {
        /// <summary>
        /// Initializes a new instance of the mwo.SimpleDI.DuplicateRegistrationException class.
        /// </summary>
        /// <param name="t">The type that was already registered, is wrapped into a message that describes the error.</param>
        public DuplicateRegistrationException(Type t) : base($"There is already a Registration for <{t.FullName}>")
        {
        }

        /// <summary>
        /// Initializes a new instance of the mwo.SimpleDI.DuplicateRegistrationException class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public DuplicateRegistrationException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the mwo.SimpleDI.DuplicateRegistrationException class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public DuplicateRegistrationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the mwo.SimpleDI.DuplicateRegistrationException class.
        /// </summary>
        public DuplicateRegistrationException() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the mwo.SimpleDI.DuplicateRegistrationException class with serailized data.
        /// </summary>
        /// <param name="serializationInfo">The object that holds the serialized object data.</param>
        /// <param name="streamingContext">The contextual information about the source or destination.</param>
        protected DuplicateRegistrationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {
        }
    }
}
