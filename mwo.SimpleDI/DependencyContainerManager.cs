using System.Collections.Generic;

namespace mwo.SimpleDI
{
    public static class DependencyContainerManager
    {
        public static Dictionary<string, IDependencyContainer> ManagedContainers = new Dictionary<string, IDependencyContainer>();

        private static DependencyContainer _default;
        public static IDependencyContainer Default
        {
            get
            {
                if (_default == null) _default = new DependencyContainer();
                return _default;
            }
        }

        public static IDependencyContainer Unique
        {
            get => new DependencyContainer(Default);
        }

        public static IDependencyContainer GetOrCreate(string name, IDependencyContainer parent = null)
        {
            if (!ManagedContainers.ContainsKey(name))
                ManagedContainers.Add(name, new DependencyContainer(parent ?? Default));

            return ManagedContainers[name];
        }

        public static void Reset()
        {
            _default = null;
            ManagedContainers.Clear();
        }
    }
}
