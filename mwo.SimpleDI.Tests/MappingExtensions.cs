using System;
using AutoMapper;

namespace mwo.SimpleDI.Tests
{
    public static class MappingExtensions
    {
        private const string ContainerName = "Dependency";
        public static void SetDependencyContainer(this IMappingOperationOptions opt, IDependencyContainer container)
        {
            opt.Items[ContainerName] = container;
        }

        public static IDependencyContainer GetDependencyContainer(this ResolutionContext opt)
        {
            var container = opt.Items[ContainerName] as DependencyContainer;
            if (container == null)
                throw new InvalidOperationException("Mapper requests DependencyContainer but none is specified!");
            return container;
        }
        public static void MapWithDependency<TDependency, TSource, TDestination, TMember, TResult>(this IMemberConfigurationExpression<TSource, TDestination, TMember> config, Func<TSource, TDependency, TResult> func, Func<IDependencyContainer, TDependency> resolver)
        {
            config.MapFrom((s, d, m, c) => func(s, resolver.Invoke(c.GetDependencyContainer())));
        }

        public static TDestination Map<TSource, TDestination>(this IMapper mapper, TSource source, IDependencyContainer container)
        {
            return mapper.Map<TDestination>(source, _ => _.SetDependencyContainer(DependencyContainerManager.Default));
        }
    }
}
