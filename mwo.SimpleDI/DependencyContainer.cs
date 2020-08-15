using System;
using System.Collections.Generic;

namespace mwo.SimpleDI
{
    public class DependencyContainer : IDependencyContainer
    {
        public Dictionary<Type, Func<IDependencyContainer, object>> Registrations { get; protected set; }
        public IDependencyContainer ParentContainer { get; set; }
        private bool HasParent => ParentContainer != null;

        public DependencyContainer(IDependencyContainer parentContainer) : this()
        {
            ParentContainer = parentContainer;
        }

        public DependencyContainer()
        {
            Registrations = new Dictionary<Type, Func<IDependencyContainer, object>>
            {
                { typeof(IDependencyContainer), _ => this },
                { GetType(), _ => this }
            };
        }

        public bool IsRegistered<T>()
        {
            return Registrations.ContainsKey(typeof(T));
        }

        public IDependencyContainer Register<T>(Func<IDependencyContainer, T> builder)
        {
            if (IsRegistered<T>())
                throw new DuplicateRegistrationException(typeof(T));

            Registrations.Add(typeof(T), _ => builder(_));
            return this;
        }

        public IDependencyContainer RegisterStrong<T>(Func<IDependencyContainer, T> builder)
        {
            if (IsRegistered<T>())
                Registrations.Remove(typeof(T));

            Register(builder);
            return this;
        }

        public IDependencyContainer RegisterWeak<T>(Func<IDependencyContainer, T> builder)
        {
            try
            {
                Register(builder);
            }
            catch (DuplicateRegistrationException)
            {
            }
            return this;
        }

        public T Resolve<T>()
        {
            if (IsRegistered<T>())
                return (T)Registrations[typeof(T)].Invoke(this);

            if (HasParent)
                return ParentContainer.Resolve<T>();

            throw new MissingRegistrationException(typeof(T));
        }

        public bool TryResolve<T>(out T obj)
        {
            try
            {
                obj = Resolve<T>();
                return true;
            }
            catch (MissingRegistrationException)
            {
                obj = default;
                return false;
            }
        }
    }
}
