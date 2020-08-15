using System;

namespace mwo.SimpleDI
{
    public interface IDependencyContainer
    {
        IDependencyContainer ParentContainer { get; set; }
        IDependencyContainer Register<T>(Func<IDependencyContainer, T> builder);
        IDependencyContainer RegisterWeak<T>(Func<IDependencyContainer, T> builder);
        IDependencyContainer RegisterStrong<T>(Func<IDependencyContainer, T> builder);
        bool IsRegistered<T>();
        T Resolve<T>();
        bool TryResolve<T>(out T obj);
    }
}
