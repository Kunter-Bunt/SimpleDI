using System;
using System.Collections.Generic;

namespace mwo.SimpleDI
{
    /// <summary>
    /// A container to register to and resolve dependencies from.
    /// </summary>
    public class DependencyContainer : IDependencyContainer
    {
        /// <summary>
        /// A collection holding all locally registered types. ParentContainer may contain more in its Registrations.
        /// Local Registrations beat the Registrations of the ParentContainer.
        /// </summary>
        public Dictionary<Type, Func<IDependencyContainer, object>> Registrations { get; protected set; }

        /// <summary>
        /// Containers may have a parent container that is considered when resolving.
        /// </summary>
        public IDependencyContainer ParentContainer { get; set; }

        /// <summary>
        /// Initializes a new instance of the mwo.SimpleDI.DependencyContainer class.
        /// </summary>
        /// <param name="parentContainer">A container to be set as the parent. Is considered when resolving.</param>
        public DependencyContainer(IDependencyContainer parentContainer) : this()
        {
            ParentContainer = parentContainer;
        }

        /// <summary>
        /// Initializes a new instance of the mwo.SimpleDI.DependencyContainer class.
        /// </summary>
        public DependencyContainer()
        {
            Registrations = new Dictionary<Type, Func<IDependencyContainer, object>>
            {
                { typeof(IDependencyContainer), _ => this },
                { GetType(), _ => this }
            };
        }

        /// <summary>
        /// Checks whether a registration is present for the given type.
        /// </summary>
        /// <typeparam name="T">The type that shall be checked.</typeparam>
        /// <returns>true if the type is registered to the container or its parent.</returns>
        public bool IsRegistered<T>()
        {
            return IsRegisteredLocal<T>() || IsRegisteredParent<T>();
        }

        private bool IsRegisteredLocal<T>()
        {
            return Registrations.ContainsKey(typeof(T));
        }

        private bool IsRegisteredParent<T>()
        {
            return ParentContainer?.IsRegistered<T>() == true;
        }

        /// <summary>
        /// Registers the builder as a generator for resolving the given type.
        /// Throws if a builder is already registered for the type.
        /// </summary>
        /// <typeparam name="T">The type that shall be registered.</typeparam>
        /// <param name="builder">The function to be executed when the given type is resolved.</param>
        /// <returns>The container.</returns>
        /// <exception cref="DuplicateRegistrationException">Thrown when a Registration was already present for the type</exception>
        public IDependencyContainer Register<T>(Func<IDependencyContainer, T> builder)
        {
            if (IsRegisteredLocal<T>())
                throw new DuplicateRegistrationException(typeof(T));

            Registrations.Add(typeof(T), _ => builder(_));
            return this;
        }

        /// <summary>
        /// Registers the builder as a generator for resolving the given type.
        /// Overwrites existing registrations for the type.
        /// </summary>
        /// <typeparam name="T">The type that shall be registered.</typeparam>
        /// <param name="builder">The function to be executed when the given type is resolved.</param>
        /// <returns>The container.</returns>
        public IDependencyContainer RegisterStrong<T>(Func<IDependencyContainer, T> builder)
        {
            if (IsRegisteredLocal<T>())
                Registrations.Remove(typeof(T));

            Register(builder);
            return this;
        }

        /// <summary>
        /// Registers the builder as a generator for resolving the given type.
        /// Skips registration if the type is already present in the Registrations.
        /// </summary>
        /// <typeparam name="T">The type that shall be registered.</typeparam>
        /// <param name="builder">The function to be executed when the given type is resolved.</param>
        /// <returns>The container.</returns>
        public IDependencyContainer RegisterWeak<T>(Func<IDependencyContainer, T> builder)
        {
            if (!IsRegisteredLocal<T>())
                Register(builder);

            return this;
        }

        /// <summary>
        /// Resolves a previously registered object.
        /// </summary>
        /// <typeparam name="T">The type that shall be resolved.</typeparam>
        /// <returns>An object of the type T</returns>
        /// <exception cref="MissingRegistrationException">Thrown when no Registration was detected for the type.</exception>
        public T Resolve<T>()
        {
            if (IsRegisteredLocal<T>())
                return (T)Registrations[typeof(T)].Invoke(this);

            if (IsRegisteredParent<T>())
                return ParentContainer.Resolve<T>();

            throw new MissingRegistrationException(typeof(T));
        }

        /// <summary>
        /// Tries to resolve an objectt of the given type.
        /// </summary>
        /// <typeparam name="T">The type that shall be resolved.</typeparam>
        /// <param name="obj">If true is returned, contains an object of type T, otherwise obj is default.</param>
        /// <returns>true, if resolved sucessfully.</returns>
        public bool TryResolve<T>(out T obj)
        {
            try
            {
                obj = Resolve<T>();
                return true;
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception)
            {
                obj = default;
                return false;
            }
#pragma warning restore CA1031 // Do not catch general exception types
        }
    }
}
