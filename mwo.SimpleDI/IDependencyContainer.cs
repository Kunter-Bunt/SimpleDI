using System;

namespace mwo.SimpleDI
{
    /// <summary>
    /// A container to register to and resolve dependencies from.
    /// </summary>
    public interface IDependencyContainer
    {
        /// <summary>
        /// Containers may have a parent container that is considered when resolving.
        /// </summary>
        IDependencyContainer ParentContainer { get; set; }
        /// <summary>
        /// Registers the builder as a generator for resolving the given type.
        /// Throws if a builder is already registered for the type.
        /// </summary>
        /// <typeparam name="T">The type that shall be registered.</typeparam>
        /// <param name="builder">The function to be executed when the given type is resolved.</param>
        /// <returns>The container.</returns>
        IDependencyContainer Register<T>(Func<IDependencyContainer, T> builder);
        /// <summary>
        /// Registers the builder as a generator for resolving the given type.
        /// Skips registration if the type is already present in the Registrations.
        /// </summary>
        /// <typeparam name="T">The type that shall be registered.</typeparam>
        /// <param name="builder">The function to be executed when the given type is resolved.</param>
        /// <returns>The container.</returns>
        IDependencyContainer RegisterWeak<T>(Func<IDependencyContainer, T> builder);
        /// <summary>
        /// Registers the builder as a generator for resolving the given type.
        /// Overwrites existing registrations for the type.
        /// </summary>
        /// <typeparam name="T">The type that shall be registered.</typeparam>
        /// <param name="builder">The function to be executed when the given type is resolved.</param>
        /// <returns>The container.</returns>
        IDependencyContainer RegisterStrong<T>(Func<IDependencyContainer, T> builder);
        /// <summary>
        /// Checks whether a registration is present for the given type.
        /// </summary>
        /// <typeparam name="T">The type that shall be checked.</typeparam>
        /// <returns>true if the type is registered to the container or its parent.</returns>
        bool IsRegistered<T>();
        /// <summary>
        /// Resolves a previously registered object.
        /// </summary>
        /// <typeparam name="T">The type that shall be resolved.</typeparam>
        /// <returns>An object of the type T.</returns>
        T Resolve<T>();
        /// <summary>
        /// Tries to resolve an objectt of the given type.
        /// </summary>
        /// <typeparam name="T">The type that shall be resolved.</typeparam>
        /// <param name="obj">If true is returned, contains an object of type T, otherwise obj is default.</param>
        /// <returns>true, if resolved sucessfully.</returns>
        bool TryResolve<T>(out T obj);
    }
}
