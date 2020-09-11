using System.Collections.Generic;

namespace mwo.SimpleDI
{
    /// <summary>
    /// Manager class to interact with IDependencyContainers.
    /// </summary>
    public static class DependencyContainerManager
    {
        /// <summary>
        /// Stores references to named dependency containers.
        /// </summary>
        public static Dictionary<string, IDependencyContainer> ManagedContainers { get; }  = new Dictionary<string, IDependencyContainer>();

        private static DependencyContainer _default;

        /// <summary>
        /// A Singleton Container that will always yield the same DependencyContainer no matter from where the Property was called.
        /// </summary>
        public static IDependencyContainer Default
        {
            get
            {
                if (_default == null) _default = new DependencyContainer();
                return _default;
            }
        }

        /// <summary>
        /// Always generates a new Unique Container with Default Container as Parent.
        /// </summary>
        public static IDependencyContainer Unique
        {
            get => new DependencyContainer(Default);
        }

        /// <summary>
        /// Gets or creates a named container.
        /// A reference to the container will be held in ManagedContainers. If called again, existing container will be taken from there.
        /// </summary>
        /// <param name="name">A key for identifying the named container.</param>
        /// <param name="parent">Optionally pass a parent for container hirachies. If not Specified, Default is taken.</param>
        /// <returns>A deoendency container.</returns>
        public static IDependencyContainer GetOrCreate(string name, IDependencyContainer parent = null)
        {
            if (!ManagedContainers.ContainsKey(name))
                ManagedContainers.Add(name, new DependencyContainer(parent ?? Default));

            return ManagedContainers[name];
        }

        /// <summary>
        /// Remove all references to containers managed.
        /// </summary>
        public static void Reset()
        {
            _default = null;
            ManagedContainers.Clear();
        }
    }
}
