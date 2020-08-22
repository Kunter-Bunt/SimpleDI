using System.Collections.Generic;

namespace mwo.SimpleDI
{
    public static class DependencyContainerManager
    {
        public static Dictionary<string, DependencyContainer> ManagedContainers = new Dictionary<string, DependencyContainer>();

        private static DependencyContainer _default;
        public static DependencyContainer Default
        {
            get
            {
                if (_default == null) _default = new DependencyContainer();
                return _default;
            }
        }

        public static DependencyContainer Unique
        {
            get => new DependencyContainer(Default);
        }

        public static DependencyContainer GetOrCreate(string name, DependencyContainer parent = null)
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
