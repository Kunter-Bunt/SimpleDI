<a name='assembly'></a>
# mwo.SimpleDI.Doc

## Contents

- [AutoMapAttribute](#T-AutoMapper-AutoMapAttribute 'AutoMapper.AutoMapAttribute')
  - [ConstructUsingServiceLocator](#P-AutoMapper-AutoMapAttribute-ConstructUsingServiceLocator 'AutoMapper.AutoMapAttribute.ConstructUsingServiceLocator')
  - [DisableCtorValidation](#P-AutoMapper-AutoMapAttribute-DisableCtorValidation 'AutoMapper.AutoMapAttribute.DisableCtorValidation')
  - [IncludeAllDerived](#P-AutoMapper-AutoMapAttribute-IncludeAllDerived 'AutoMapper.AutoMapAttribute.IncludeAllDerived')
  - [MaxDepth](#P-AutoMapper-AutoMapAttribute-MaxDepth 'AutoMapper.AutoMapAttribute.MaxDepth')
  - [PreserveReferences](#P-AutoMapper-AutoMapAttribute-PreserveReferences 'AutoMapper.AutoMapAttribute.PreserveReferences')
  - [TypeConverter](#P-AutoMapper-AutoMapAttribute-TypeConverter 'AutoMapper.AutoMapAttribute.TypeConverter')
- [AutoMapperMappingException](#T-AutoMapper-AutoMapperMappingException 'AutoMapper.AutoMapperMappingException')
- [DependencyContainer](#T-mwo-SimpleDI-DependencyContainer 'mwo.SimpleDI.DependencyContainer')
  - [#ctor(parentContainer)](#M-mwo-SimpleDI-DependencyContainer-#ctor-mwo-SimpleDI-IDependencyContainer- 'mwo.SimpleDI.DependencyContainer.#ctor(mwo.SimpleDI.IDependencyContainer)')
  - [#ctor()](#M-mwo-SimpleDI-DependencyContainer-#ctor 'mwo.SimpleDI.DependencyContainer.#ctor')
  - [ParentContainer](#P-mwo-SimpleDI-DependencyContainer-ParentContainer 'mwo.SimpleDI.DependencyContainer.ParentContainer')
  - [Registrations](#P-mwo-SimpleDI-DependencyContainer-Registrations 'mwo.SimpleDI.DependencyContainer.Registrations')
  - [IsRegistered\`\`1()](#M-mwo-SimpleDI-DependencyContainer-IsRegistered``1 'mwo.SimpleDI.DependencyContainer.IsRegistered``1')
  - [RegisterStrong\`\`1(builder)](#M-mwo-SimpleDI-DependencyContainer-RegisterStrong``1-System-Func{mwo-SimpleDI-IDependencyContainer,``0}- 'mwo.SimpleDI.DependencyContainer.RegisterStrong``1(System.Func{mwo.SimpleDI.IDependencyContainer,``0})')
  - [RegisterWeak\`\`1(builder)](#M-mwo-SimpleDI-DependencyContainer-RegisterWeak``1-System-Func{mwo-SimpleDI-IDependencyContainer,``0}- 'mwo.SimpleDI.DependencyContainer.RegisterWeak``1(System.Func{mwo.SimpleDI.IDependencyContainer,``0})')
  - [Register\`\`1(builder)](#M-mwo-SimpleDI-DependencyContainer-Register``1-System-Func{mwo-SimpleDI-IDependencyContainer,``0}- 'mwo.SimpleDI.DependencyContainer.Register``1(System.Func{mwo.SimpleDI.IDependencyContainer,``0})')
  - [Resolve\`\`1()](#M-mwo-SimpleDI-DependencyContainer-Resolve``1 'mwo.SimpleDI.DependencyContainer.Resolve``1')
  - [TryResolve\`\`1(obj)](#M-mwo-SimpleDI-DependencyContainer-TryResolve``1-``0@- 'mwo.SimpleDI.DependencyContainer.TryResolve``1(``0@)')
- [DependencyContainerManager](#T-mwo-SimpleDI-DependencyContainerManager 'mwo.SimpleDI.DependencyContainerManager')
  - [Default](#P-mwo-SimpleDI-DependencyContainerManager-Default 'mwo.SimpleDI.DependencyContainerManager.Default')
  - [ManagedContainers](#P-mwo-SimpleDI-DependencyContainerManager-ManagedContainers 'mwo.SimpleDI.DependencyContainerManager.ManagedContainers')
  - [Unique](#P-mwo-SimpleDI-DependencyContainerManager-Unique 'mwo.SimpleDI.DependencyContainerManager.Unique')
  - [GetOrCreate(name,parent)](#M-mwo-SimpleDI-DependencyContainerManager-GetOrCreate-System-String,mwo-SimpleDI-IDependencyContainer- 'mwo.SimpleDI.DependencyContainerManager.GetOrCreate(System.String,mwo.SimpleDI.IDependencyContainer)')
  - [Reset()](#M-mwo-SimpleDI-DependencyContainerManager-Reset 'mwo.SimpleDI.DependencyContainerManager.Reset')
- [DuplicateRegistrationException](#T-mwo-SimpleDI-DuplicateRegistrationException 'mwo.SimpleDI.DuplicateRegistrationException')
  - [#ctor(t)](#M-mwo-SimpleDI-DuplicateRegistrationException-#ctor-System-Type- 'mwo.SimpleDI.DuplicateRegistrationException.#ctor(System.Type)')
  - [#ctor(message)](#M-mwo-SimpleDI-DuplicateRegistrationException-#ctor-System-String- 'mwo.SimpleDI.DuplicateRegistrationException.#ctor(System.String)')
  - [#ctor(message,innerException)](#M-mwo-SimpleDI-DuplicateRegistrationException-#ctor-System-String,System-Exception- 'mwo.SimpleDI.DuplicateRegistrationException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-mwo-SimpleDI-DuplicateRegistrationException-#ctor 'mwo.SimpleDI.DuplicateRegistrationException.#ctor')
  - [#ctor(serializationInfo,streamingContext)](#M-mwo-SimpleDI-DuplicateRegistrationException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'mwo.SimpleDI.DuplicateRegistrationException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [Extensions](#T-AutoMapper-QueryableExtensions-Extensions 'AutoMapper.QueryableExtensions.Extensions')
  - [Map\`\`2(sourceQuery,destQuery,config)](#M-AutoMapper-QueryableExtensions-Extensions-Map``2-System-Linq-IQueryable{``0},System-Linq-IQueryable{``1},AutoMapper-IConfigurationProvider- 'AutoMapper.QueryableExtensions.Extensions.Map``2(System.Linq.IQueryable{``0},System.Linq.IQueryable{``1},AutoMapper.IConfigurationProvider)')
  - [ProjectTo(source,destinationType,configuration)](#M-AutoMapper-QueryableExtensions-Extensions-ProjectTo-System-Linq-IQueryable,System-Type,AutoMapper-IConfigurationProvider- 'AutoMapper.QueryableExtensions.Extensions.ProjectTo(System.Linq.IQueryable,System.Type,AutoMapper.IConfigurationProvider)')
  - [ProjectTo(source,destinationType,configuration,parameters,membersToExpand)](#M-AutoMapper-QueryableExtensions-Extensions-ProjectTo-System-Linq-IQueryable,System-Type,AutoMapper-IConfigurationProvider,System-Collections-Generic-IDictionary{System-String,System-Object},System-String[]- 'AutoMapper.QueryableExtensions.Extensions.ProjectTo(System.Linq.IQueryable,System.Type,AutoMapper.IConfigurationProvider,System.Collections.Generic.IDictionary{System.String,System.Object},System.String[])')
  - [ProjectTo\`\`1(source,configuration,parameters,membersToExpand)](#M-AutoMapper-QueryableExtensions-Extensions-ProjectTo``1-System-Linq-IQueryable,AutoMapper-IConfigurationProvider,System-Object,System-Linq-Expressions-Expression{System-Func{``0,System-Object}}[]- 'AutoMapper.QueryableExtensions.Extensions.ProjectTo``1(System.Linq.IQueryable,AutoMapper.IConfigurationProvider,System.Object,System.Linq.Expressions.Expression{System.Func{``0,System.Object}}[])')
  - [ProjectTo\`\`1(source,configuration,membersToExpand)](#M-AutoMapper-QueryableExtensions-Extensions-ProjectTo``1-System-Linq-IQueryable,AutoMapper-IConfigurationProvider,System-Linq-Expressions-Expression{System-Func{``0,System-Object}}[]- 'AutoMapper.QueryableExtensions.Extensions.ProjectTo``1(System.Linq.IQueryable,AutoMapper.IConfigurationProvider,System.Linq.Expressions.Expression{System.Func{``0,System.Object}}[])')
  - [ProjectTo\`\`1(source,configuration,parameters,membersToExpand)](#M-AutoMapper-QueryableExtensions-Extensions-ProjectTo``1-System-Linq-IQueryable,AutoMapper-IConfigurationProvider,System-Collections-Generic-IDictionary{System-String,System-Object},System-String[]- 'AutoMapper.QueryableExtensions.Extensions.ProjectTo``1(System.Linq.IQueryable,AutoMapper.IConfigurationProvider,System.Collections.Generic.IDictionary{System.String,System.Object},System.String[])')
- [Features\`1](#T-AutoMapper-Features-Features`1 'AutoMapper.Features.Features`1')
  - [Get\`\`1()](#M-AutoMapper-Features-Features`1-Get``1 'AutoMapper.Features.Features`1.Get``1')
  - [Set(feature)](#M-AutoMapper-Features-Features`1-Set-`0- 'AutoMapper.Features.Features`1.Set(`0)')
- [IConfigurationProvider](#T-AutoMapper-IConfigurationProvider 'AutoMapper.IConfigurationProvider')
  - [AssertConfigurationIsValid()](#M-AutoMapper-IConfigurationProvider-AssertConfigurationIsValid 'AutoMapper.IConfigurationProvider.AssertConfigurationIsValid')
  - [BuildExecutionPlan(sourceType,destinationType)](#M-AutoMapper-IConfigurationProvider-BuildExecutionPlan-System-Type,System-Type- 'AutoMapper.IConfigurationProvider.BuildExecutionPlan(System.Type,System.Type)')
  - [CompileMappings()](#M-AutoMapper-IConfigurationProvider-CompileMappings 'AutoMapper.IConfigurationProvider.CompileMappings')
  - [CreateMapper()](#M-AutoMapper-IConfigurationProvider-CreateMapper 'AutoMapper.IConfigurationProvider.CreateMapper')
  - [CreateMapper(serviceCtor)](#M-AutoMapper-IConfigurationProvider-CreateMapper-System-Func{System-Type,System-Object}- 'AutoMapper.IConfigurationProvider.CreateMapper(System.Func{System.Type,System.Object})')
- [ICtorParamConfigurationExpression](#T-AutoMapper-Configuration-ICtorParamConfigurationExpression 'AutoMapper.Configuration.ICtorParamConfigurationExpression')
  - [MapFrom(sourceMembersPath)](#M-AutoMapper-Configuration-ICtorParamConfigurationExpression-MapFrom-System-String- 'AutoMapper.Configuration.ICtorParamConfigurationExpression.MapFrom(System.String)')
- [ICtorParamConfigurationExpression\`1](#T-AutoMapper-Configuration-ICtorParamConfigurationExpression`1 'AutoMapper.Configuration.ICtorParamConfigurationExpression`1')
  - [MapFrom\`\`1(sourceMember)](#M-AutoMapper-Configuration-ICtorParamConfigurationExpression`1-MapFrom``1-System-Linq-Expressions-Expression{System-Func{`0,``0}}- 'AutoMapper.Configuration.ICtorParamConfigurationExpression`1.MapFrom``1(System.Linq.Expressions.Expression{System.Func{`0,``0}})')
  - [MapFrom\`\`1(resolver)](#M-AutoMapper-Configuration-ICtorParamConfigurationExpression`1-MapFrom``1-System-Func{`0,AutoMapper-ResolutionContext,``0}- 'AutoMapper.Configuration.ICtorParamConfigurationExpression`1.MapFrom``1(System.Func{`0,AutoMapper.ResolutionContext,``0})')
- [IDependencyContainer](#T-mwo-SimpleDI-IDependencyContainer 'mwo.SimpleDI.IDependencyContainer')
  - [ParentContainer](#P-mwo-SimpleDI-IDependencyContainer-ParentContainer 'mwo.SimpleDI.IDependencyContainer.ParentContainer')
  - [IsRegistered\`\`1()](#M-mwo-SimpleDI-IDependencyContainer-IsRegistered``1 'mwo.SimpleDI.IDependencyContainer.IsRegistered``1')
  - [RegisterStrong\`\`1(builder)](#M-mwo-SimpleDI-IDependencyContainer-RegisterStrong``1-System-Func{mwo-SimpleDI-IDependencyContainer,``0}- 'mwo.SimpleDI.IDependencyContainer.RegisterStrong``1(System.Func{mwo.SimpleDI.IDependencyContainer,``0})')
  - [RegisterWeak\`\`1(builder)](#M-mwo-SimpleDI-IDependencyContainer-RegisterWeak``1-System-Func{mwo-SimpleDI-IDependencyContainer,``0}- 'mwo.SimpleDI.IDependencyContainer.RegisterWeak``1(System.Func{mwo.SimpleDI.IDependencyContainer,``0})')
  - [Register\`\`1(builder)](#M-mwo-SimpleDI-IDependencyContainer-Register``1-System-Func{mwo-SimpleDI-IDependencyContainer,``0}- 'mwo.SimpleDI.IDependencyContainer.Register``1(System.Func{mwo.SimpleDI.IDependencyContainer,``0})')
  - [Resolve\`\`1()](#M-mwo-SimpleDI-IDependencyContainer-Resolve``1 'mwo.SimpleDI.IDependencyContainer.Resolve``1')
  - [TryResolve\`\`1(obj)](#M-mwo-SimpleDI-IDependencyContainer-TryResolve``1-``0@- 'mwo.SimpleDI.IDependencyContainer.TryResolve``1(``0@)')
- [IGlobalConfiguration](#T-AutoMapper-Internal-IGlobalConfiguration 'AutoMapper.Internal.IGlobalConfiguration')
  - [EnableNullPropagationForQueryMapping](#P-AutoMapper-Internal-IGlobalConfiguration-EnableNullPropagationForQueryMapping 'AutoMapper.Internal.IGlobalConfiguration.EnableNullPropagationForQueryMapping')
  - [Features](#P-AutoMapper-Internal-IGlobalConfiguration-Features 'AutoMapper.Internal.IGlobalConfiguration.Features')
  - [ServiceCtor](#P-AutoMapper-Internal-IGlobalConfiguration-ServiceCtor 'AutoMapper.Internal.IGlobalConfiguration.ServiceCtor')
  - [AssertConfigurationIsValid(typeMap)](#M-AutoMapper-Internal-IGlobalConfiguration-AssertConfigurationIsValid-AutoMapper-TypeMap- 'AutoMapper.Internal.IGlobalConfiguration.AssertConfigurationIsValid(AutoMapper.TypeMap)')
  - [AssertConfigurationIsValid(profileName)](#M-AutoMapper-Internal-IGlobalConfiguration-AssertConfigurationIsValid-System-String- 'AutoMapper.Internal.IGlobalConfiguration.AssertConfigurationIsValid(System.String)')
  - [AssertConfigurationIsValid\`\`1()](#M-AutoMapper-Internal-IGlobalConfiguration-AssertConfigurationIsValid``1 'AutoMapper.Internal.IGlobalConfiguration.AssertConfigurationIsValid``1')
  - [BuildExecutionPlan(mapRequest)](#M-AutoMapper-Internal-IGlobalConfiguration-BuildExecutionPlan-AutoMapper-Internal-MapRequest@- 'AutoMapper.Internal.IGlobalConfiguration.BuildExecutionPlan(AutoMapper.Internal.MapRequest@)')
  - [FindMapper(types)](#M-AutoMapper-Internal-IGlobalConfiguration-FindMapper-AutoMapper-Internal-TypePair@- 'AutoMapper.Internal.IGlobalConfiguration.FindMapper(AutoMapper.Internal.TypePair@)')
  - [FindTypeMapFor(sourceType,destinationType)](#M-AutoMapper-Internal-IGlobalConfiguration-FindTypeMapFor-System-Type,System-Type- 'AutoMapper.Internal.IGlobalConfiguration.FindTypeMapFor(System.Type,System.Type)')
  - [FindTypeMapFor(typePair)](#M-AutoMapper-Internal-IGlobalConfiguration-FindTypeMapFor-AutoMapper-Internal-TypePair@- 'AutoMapper.Internal.IGlobalConfiguration.FindTypeMapFor(AutoMapper.Internal.TypePair@)')
  - [FindTypeMapFor\`\`2()](#M-AutoMapper-Internal-IGlobalConfiguration-FindTypeMapFor``2 'AutoMapper.Internal.IGlobalConfiguration.FindTypeMapFor``2')
  - [GetAllTypeMaps()](#M-AutoMapper-Internal-IGlobalConfiguration-GetAllTypeMaps 'AutoMapper.Internal.IGlobalConfiguration.GetAllTypeMaps')
  - [GetMappers()](#M-AutoMapper-Internal-IGlobalConfiguration-GetMappers 'AutoMapper.Internal.IGlobalConfiguration.GetMappers')
  - [ResolveTypeMap(sourceType,destinationType)](#M-AutoMapper-Internal-IGlobalConfiguration-ResolveTypeMap-System-Type,System-Type- 'AutoMapper.Internal.IGlobalConfiguration.ResolveTypeMap(System.Type,System.Type)')
  - [ResolveTypeMap(typePair)](#M-AutoMapper-Internal-IGlobalConfiguration-ResolveTypeMap-AutoMapper-Internal-TypePair@- 'AutoMapper.Internal.IGlobalConfiguration.ResolveTypeMap(AutoMapper.Internal.TypePair@)')
- [IGlobalConfigurationExpression](#T-AutoMapper-Internal-IGlobalConfigurationExpression 'AutoMapper.Internal.IGlobalConfigurationExpression')
  - [AllowAdditiveTypeMapCreation](#P-AutoMapper-Internal-IGlobalConfigurationExpression-AllowAdditiveTypeMapCreation 'AutoMapper.Internal.IGlobalConfigurationExpression.AllowAdditiveTypeMapCreation')
  - [Features](#P-AutoMapper-Internal-IGlobalConfigurationExpression-Features 'AutoMapper.Internal.IGlobalConfigurationExpression.Features')
  - [Mappers](#P-AutoMapper-Internal-IGlobalConfigurationExpression-Mappers 'AutoMapper.Internal.IGlobalConfigurationExpression.Mappers')
  - [MaxExecutionPlanDepth](#P-AutoMapper-Internal-IGlobalConfigurationExpression-MaxExecutionPlanDepth 'AutoMapper.Internal.IGlobalConfigurationExpression.MaxExecutionPlanDepth')
  - [RecursiveQueriesMaxDepth](#P-AutoMapper-Internal-IGlobalConfigurationExpression-RecursiveQueriesMaxDepth 'AutoMapper.Internal.IGlobalConfigurationExpression.RecursiveQueriesMaxDepth')
  - [Validator(validator)](#M-AutoMapper-Internal-IGlobalConfigurationExpression-Validator-System-Action{AutoMapper-Configuration-ValidationContext}- 'AutoMapper.Internal.IGlobalConfigurationExpression.Validator(System.Action{AutoMapper.Configuration.ValidationContext})')
- [IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper')
  - [ConfigurationProvider](#P-AutoMapper-IMapper-ConfigurationProvider 'AutoMapper.IMapper.ConfigurationProvider')
  - [Map(source,sourceType,destinationType,opts)](#M-AutoMapper-IMapper-Map-System-Object,System-Type,System-Type,System-Action{AutoMapper-IMappingOperationOptions{System-Object,System-Object}}- 'AutoMapper.IMapper.Map(System.Object,System.Type,System.Type,System.Action{AutoMapper.IMappingOperationOptions{System.Object,System.Object}})')
  - [Map(source,destination,sourceType,destinationType,opts)](#M-AutoMapper-IMapper-Map-System-Object,System-Object,System-Type,System-Type,System-Action{AutoMapper-IMappingOperationOptions{System-Object,System-Object}}- 'AutoMapper.IMapper.Map(System.Object,System.Object,System.Type,System.Type,System.Action{AutoMapper.IMappingOperationOptions{System.Object,System.Object}})')
  - [Map\`\`1(source,opts)](#M-AutoMapper-IMapper-Map``1-System-Object,System-Action{AutoMapper-IMappingOperationOptions{System-Object,``0}}- 'AutoMapper.IMapper.Map``1(System.Object,System.Action{AutoMapper.IMappingOperationOptions{System.Object,``0}})')
  - [Map\`\`2(source,opts)](#M-AutoMapper-IMapper-Map``2-``0,System-Action{AutoMapper-IMappingOperationOptions{``0,``1}}- 'AutoMapper.IMapper.Map``2(``0,System.Action{AutoMapper.IMappingOperationOptions{``0,``1}})')
  - [Map\`\`2(source,destination,opts)](#M-AutoMapper-IMapper-Map``2-``0,``1,System-Action{AutoMapper-IMappingOperationOptions{``0,``1}}- 'AutoMapper.IMapper.Map``2(``0,``1,System.Action{AutoMapper.IMappingOperationOptions{``0,``1}})')
  - [ProjectTo(source,destinationType,parameters,membersToExpand)](#M-AutoMapper-IMapper-ProjectTo-System-Linq-IQueryable,System-Type,System-Collections-Generic-IDictionary{System-String,System-Object},System-String[]- 'AutoMapper.IMapper.ProjectTo(System.Linq.IQueryable,System.Type,System.Collections.Generic.IDictionary{System.String,System.Object},System.String[])')
  - [ProjectTo\`\`1(source,parameters,membersToExpand)](#M-AutoMapper-IMapper-ProjectTo``1-System-Linq-IQueryable,System-Object,System-Linq-Expressions-Expression{System-Func{``0,System-Object}}[]- 'AutoMapper.IMapper.ProjectTo``1(System.Linq.IQueryable,System.Object,System.Linq.Expressions.Expression{System.Func{``0,System.Object}}[])')
  - [ProjectTo\`\`1(source,parameters,membersToExpand)](#M-AutoMapper-IMapper-ProjectTo``1-System-Linq-IQueryable,System-Collections-Generic-IDictionary{System-String,System-Object},System-String[]- 'AutoMapper.IMapper.ProjectTo``1(System.Linq.IQueryable,System.Collections.Generic.IDictionary{System.String,System.Object},System.String[])')
- [IMapperBase](#T-AutoMapper-IMapperBase 'AutoMapper.IMapperBase')
  - [Map(source,sourceType,destinationType)](#M-AutoMapper-IMapperBase-Map-System-Object,System-Type,System-Type- 'AutoMapper.IMapperBase.Map(System.Object,System.Type,System.Type)')
  - [Map(source,destination,sourceType,destinationType)](#M-AutoMapper-IMapperBase-Map-System-Object,System-Object,System-Type,System-Type- 'AutoMapper.IMapperBase.Map(System.Object,System.Object,System.Type,System.Type)')
  - [Map\`\`1(source)](#M-AutoMapper-IMapperBase-Map``1-System-Object- 'AutoMapper.IMapperBase.Map``1(System.Object)')
  - [Map\`\`2(source)](#M-AutoMapper-IMapperBase-Map``2-``0- 'AutoMapper.IMapperBase.Map``2(``0)')
  - [Map\`\`2(source,destination)](#M-AutoMapper-IMapperBase-Map``2-``0,``1- 'AutoMapper.IMapperBase.Map``2(``0,``1)')
- [IMapperConfigurationExpression](#T-AutoMapper-IMapperConfigurationExpression 'AutoMapper.IMapperConfigurationExpression')
  - [AddMaps(assembliesToScan)](#M-AutoMapper-IMapperConfigurationExpression-AddMaps-System-Collections-Generic-IEnumerable{System-Reflection-Assembly}- 'AutoMapper.IMapperConfigurationExpression.AddMaps(System.Collections.Generic.IEnumerable{System.Reflection.Assembly})')
  - [AddMaps(assembliesToScan)](#M-AutoMapper-IMapperConfigurationExpression-AddMaps-System-Reflection-Assembly[]- 'AutoMapper.IMapperConfigurationExpression.AddMaps(System.Reflection.Assembly[])')
  - [AddMaps(assemblyNamesToScan)](#M-AutoMapper-IMapperConfigurationExpression-AddMaps-System-Collections-Generic-IEnumerable{System-String}- 'AutoMapper.IMapperConfigurationExpression.AddMaps(System.Collections.Generic.IEnumerable{System.String})')
  - [AddMaps(assemblyNamesToScan)](#M-AutoMapper-IMapperConfigurationExpression-AddMaps-System-String[]- 'AutoMapper.IMapperConfigurationExpression.AddMaps(System.String[])')
  - [AddMaps(typesFromAssembliesContainingMappingDefinitions)](#M-AutoMapper-IMapperConfigurationExpression-AddMaps-System-Collections-Generic-IEnumerable{System-Type}- 'AutoMapper.IMapperConfigurationExpression.AddMaps(System.Collections.Generic.IEnumerable{System.Type})')
  - [AddMaps(typesFromAssembliesContainingMappingDefinitions)](#M-AutoMapper-IMapperConfigurationExpression-AddMaps-System-Type[]- 'AutoMapper.IMapperConfigurationExpression.AddMaps(System.Type[])')
  - [AddProfile(profile)](#M-AutoMapper-IMapperConfigurationExpression-AddProfile-AutoMapper-Profile- 'AutoMapper.IMapperConfigurationExpression.AddProfile(AutoMapper.Profile)')
  - [AddProfile(profileType)](#M-AutoMapper-IMapperConfigurationExpression-AddProfile-System-Type- 'AutoMapper.IMapperConfigurationExpression.AddProfile(System.Type)')
  - [AddProfile\`\`1()](#M-AutoMapper-IMapperConfigurationExpression-AddProfile``1 'AutoMapper.IMapperConfigurationExpression.AddProfile``1')
  - [AddProfiles(enumerableOfProfiles)](#M-AutoMapper-IMapperConfigurationExpression-AddProfiles-System-Collections-Generic-IEnumerable{AutoMapper-Profile}- 'AutoMapper.IMapperConfigurationExpression.AddProfiles(System.Collections.Generic.IEnumerable{AutoMapper.Profile})')
  - [ConstructServicesUsing(constructor)](#M-AutoMapper-IMapperConfigurationExpression-ConstructServicesUsing-System-Func{System-Type,System-Object}- 'AutoMapper.IMapperConfigurationExpression.ConstructServicesUsing(System.Func{System.Type,System.Object})')
  - [CreateProfile(profileName,config)](#M-AutoMapper-IMapperConfigurationExpression-CreateProfile-System-String,System-Action{AutoMapper-IProfileExpression}- 'AutoMapper.IMapperConfigurationExpression.CreateProfile(System.String,System.Action{AutoMapper.IProfileExpression})')
- [IMappingAction\`2](#T-AutoMapper-IMappingAction`2 'AutoMapper.IMappingAction`2')
  - [Process(source,destination,context)](#M-AutoMapper-IMappingAction`2-Process-`0,`1,AutoMapper-ResolutionContext- 'AutoMapper.IMappingAction`2.Process(`0,`1,AutoMapper.ResolutionContext)')
- [IMappingExpression](#T-AutoMapper-IMappingExpression 'AutoMapper.IMappingExpression')
  - [ForAllMembers(memberOptions)](#M-AutoMapper-IMappingExpression-ForAllMembers-System-Action{AutoMapper-IMemberConfigurationExpression}- 'AutoMapper.IMappingExpression.ForAllMembers(System.Action{AutoMapper.IMemberConfigurationExpression})')
  - [ForMember(name,memberOptions)](#M-AutoMapper-IMappingExpression-ForMember-System-String,System-Action{AutoMapper-IMemberConfigurationExpression}- 'AutoMapper.IMappingExpression.ForMember(System.String,System.Action{AutoMapper.IMemberConfigurationExpression})')
  - [IncludeMembers(memberNames)](#M-AutoMapper-IMappingExpression-IncludeMembers-System-String[]- 'AutoMapper.IMappingExpression.IncludeMembers(System.String[])')
  - [ReverseMap()](#M-AutoMapper-IMappingExpression-ReverseMap 'AutoMapper.IMappingExpression.ReverseMap')
- [IMappingExpressionBase\`3](#T-AutoMapper-IMappingExpressionBase`3 'AutoMapper.IMappingExpressionBase`3')
  - [AfterMap(afterFunction)](#M-AutoMapper-IMappingExpressionBase`3-AfterMap-System-Action{`0,`1}- 'AutoMapper.IMappingExpressionBase`3.AfterMap(System.Action{`0,`1})')
  - [AfterMap(afterFunction)](#M-AutoMapper-IMappingExpressionBase`3-AfterMap-System-Action{`0,`1,AutoMapper-ResolutionContext}- 'AutoMapper.IMappingExpressionBase`3.AfterMap(System.Action{`0,`1,AutoMapper.ResolutionContext})')
  - [AfterMap\`\`1()](#M-AutoMapper-IMappingExpressionBase`3-AfterMap``1 'AutoMapper.IMappingExpressionBase`3.AfterMap``1')
  - [As(typeOverride)](#M-AutoMapper-IMappingExpressionBase`3-As-System-Type- 'AutoMapper.IMappingExpressionBase`3.As(System.Type)')
  - [AsProxy()](#M-AutoMapper-IMappingExpressionBase`3-AsProxy 'AutoMapper.IMappingExpressionBase`3.AsProxy')
  - [BeforeMap(beforeFunction)](#M-AutoMapper-IMappingExpressionBase`3-BeforeMap-System-Action{`0,`1}- 'AutoMapper.IMappingExpressionBase`3.BeforeMap(System.Action{`0,`1})')
  - [BeforeMap(beforeFunction)](#M-AutoMapper-IMappingExpressionBase`3-BeforeMap-System-Action{`0,`1,AutoMapper-ResolutionContext}- 'AutoMapper.IMappingExpressionBase`3.BeforeMap(System.Action{`0,`1,AutoMapper.ResolutionContext})')
  - [BeforeMap\`\`1()](#M-AutoMapper-IMappingExpressionBase`3-BeforeMap``1 'AutoMapper.IMappingExpressionBase`3.BeforeMap``1')
  - [ConstructUsing(ctor)](#M-AutoMapper-IMappingExpressionBase`3-ConstructUsing-System-Func{`0,AutoMapper-ResolutionContext,`1}- 'AutoMapper.IMappingExpressionBase`3.ConstructUsing(System.Func{`0,AutoMapper.ResolutionContext,`1})')
  - [ConstructUsingServiceLocator()](#M-AutoMapper-IMappingExpressionBase`3-ConstructUsingServiceLocator 'AutoMapper.IMappingExpressionBase`3.ConstructUsingServiceLocator')
  - [ConvertUsing(typeConverterType)](#M-AutoMapper-IMappingExpressionBase`3-ConvertUsing-System-Type- 'AutoMapper.IMappingExpressionBase`3.ConvertUsing(System.Type)')
  - [ConvertUsing(mappingFunction)](#M-AutoMapper-IMappingExpressionBase`3-ConvertUsing-System-Func{`0,`1,`1}- 'AutoMapper.IMappingExpressionBase`3.ConvertUsing(System.Func{`0,`1,`1})')
  - [ConvertUsing(mappingFunction)](#M-AutoMapper-IMappingExpressionBase`3-ConvertUsing-System-Func{`0,`1,AutoMapper-ResolutionContext,`1}- 'AutoMapper.IMappingExpressionBase`3.ConvertUsing(System.Func{`0,`1,AutoMapper.ResolutionContext,`1})')
  - [ConvertUsing(converter)](#M-AutoMapper-IMappingExpressionBase`3-ConvertUsing-AutoMapper-ITypeConverter{`0,`1}- 'AutoMapper.IMappingExpressionBase`3.ConvertUsing(AutoMapper.ITypeConverter{`0,`1})')
  - [ConvertUsing\`\`1()](#M-AutoMapper-IMappingExpressionBase`3-ConvertUsing``1 'AutoMapper.IMappingExpressionBase`3.ConvertUsing``1')
  - [DisableCtorValidation()](#M-AutoMapper-IMappingExpressionBase`3-DisableCtorValidation 'AutoMapper.IMappingExpressionBase`3.DisableCtorValidation')
  - [ForSourceMember(sourceMemberName,memberOptions)](#M-AutoMapper-IMappingExpressionBase`3-ForSourceMember-System-String,System-Action{AutoMapper-Configuration-ISourceMemberConfigurationExpression}- 'AutoMapper.IMappingExpressionBase`3.ForSourceMember(System.String,System.Action{AutoMapper.Configuration.ISourceMemberConfigurationExpression})')
  - [IgnoreAllPropertiesWithAnInaccessibleSetter()](#M-AutoMapper-IMappingExpressionBase`3-IgnoreAllPropertiesWithAnInaccessibleSetter 'AutoMapper.IMappingExpressionBase`3.IgnoreAllPropertiesWithAnInaccessibleSetter')
  - [IgnoreAllSourcePropertiesWithAnInaccessibleSetter()](#M-AutoMapper-IMappingExpressionBase`3-IgnoreAllSourcePropertiesWithAnInaccessibleSetter 'AutoMapper.IMappingExpressionBase`3.IgnoreAllSourcePropertiesWithAnInaccessibleSetter')
  - [Include(derivedSourceType,derivedDestinationType)](#M-AutoMapper-IMappingExpressionBase`3-Include-System-Type,System-Type- 'AutoMapper.IMappingExpressionBase`3.Include(System.Type,System.Type)')
  - [IncludeAllDerived()](#M-AutoMapper-IMappingExpressionBase`3-IncludeAllDerived 'AutoMapper.IMappingExpressionBase`3.IncludeAllDerived')
  - [IncludeBase(sourceBase,destinationBase)](#M-AutoMapper-IMappingExpressionBase`3-IncludeBase-System-Type,System-Type- 'AutoMapper.IMappingExpressionBase`3.IncludeBase(System.Type,System.Type)')
  - [PreserveReferences()](#M-AutoMapper-IMappingExpressionBase`3-PreserveReferences 'AutoMapper.IMappingExpressionBase`3.PreserveReferences')
- [IMappingExpression\`2](#T-AutoMapper-IMappingExpression`2 'AutoMapper.IMappingExpression`2')
  - [As\`\`1()](#M-AutoMapper-IMappingExpression`2-As``1 'AutoMapper.IMappingExpression`2.As``1')
  - [ForAllMembers(memberOptions)](#M-AutoMapper-IMappingExpression`2-ForAllMembers-System-Action{AutoMapper-IMemberConfigurationExpression{`0,`1,System-Object}}- 'AutoMapper.IMappingExpression`2.ForAllMembers(System.Action{AutoMapper.IMemberConfigurationExpression{`0,`1,System.Object}})')
  - [ForMember(name,memberOptions)](#M-AutoMapper-IMappingExpression`2-ForMember-System-String,System-Action{AutoMapper-IMemberConfigurationExpression{`0,`1,System-Object}}- 'AutoMapper.IMappingExpression`2.ForMember(System.String,System.Action{AutoMapper.IMemberConfigurationExpression{`0,`1,System.Object}})')
  - [ForMember\`\`1(destinationMember,memberOptions)](#M-AutoMapper-IMappingExpression`2-ForMember``1-System-Linq-Expressions-Expression{System-Func{`1,``0}},System-Action{AutoMapper-IMemberConfigurationExpression{`0,`1,``0}}- 'AutoMapper.IMappingExpression`2.ForMember``1(System.Linq.Expressions.Expression{System.Func{`1,``0}},System.Action{AutoMapper.IMemberConfigurationExpression{`0,`1,``0}})')
  - [ForPath\`\`1(destinationMember,memberOptions)](#M-AutoMapper-IMappingExpression`2-ForPath``1-System-Linq-Expressions-Expression{System-Func{`1,``0}},System-Action{AutoMapper-Configuration-IPathConfigurationExpression{`0,`1,``0}}- 'AutoMapper.IMappingExpression`2.ForPath``1(System.Linq.Expressions.Expression{System.Func{`1,``0}},System.Action{AutoMapper.Configuration.IPathConfigurationExpression{`0,`1,``0}})')
  - [ForSourceMember(sourceMember,memberOptions)](#M-AutoMapper-IMappingExpression`2-ForSourceMember-System-Linq-Expressions-Expression{System-Func{`0,System-Object}},System-Action{AutoMapper-Configuration-ISourceMemberConfigurationExpression}- 'AutoMapper.IMappingExpression`2.ForSourceMember(System.Linq.Expressions.Expression{System.Func{`0,System.Object}},System.Action{AutoMapper.Configuration.ISourceMemberConfigurationExpression})')
  - [IncludeBase\`\`2()](#M-AutoMapper-IMappingExpression`2-IncludeBase``2 'AutoMapper.IMappingExpression`2.IncludeBase``2')
  - [Include\`\`2()](#M-AutoMapper-IMappingExpression`2-Include``2 'AutoMapper.IMappingExpression`2.Include``2')
  - [ReverseMap()](#M-AutoMapper-IMappingExpression`2-ReverseMap 'AutoMapper.IMappingExpression`2.ReverseMap')
- [IMappingOperationOptions](#T-AutoMapper-IMappingOperationOptions 'AutoMapper.IMappingOperationOptions')
  - [Items](#P-AutoMapper-IMappingOperationOptions-Items 'AutoMapper.IMappingOperationOptions.Items')
  - [AfterMap(afterFunction)](#M-AutoMapper-IMappingOperationOptions-AfterMap-System-Action{System-Object,System-Object}- 'AutoMapper.IMappingOperationOptions.AfterMap(System.Action{System.Object,System.Object})')
  - [BeforeMap(beforeFunction)](#M-AutoMapper-IMappingOperationOptions-BeforeMap-System-Action{System-Object,System-Object}- 'AutoMapper.IMappingOperationOptions.BeforeMap(System.Action{System.Object,System.Object})')
  - [ConstructServicesUsing(constructor)](#M-AutoMapper-IMappingOperationOptions-ConstructServicesUsing-System-Func{System-Type,System-Object}- 'AutoMapper.IMappingOperationOptions.ConstructServicesUsing(System.Func{System.Type,System.Object})')
- [IMappingOperationOptions\`2](#T-AutoMapper-IMappingOperationOptions`2 'AutoMapper.IMappingOperationOptions`2')
  - [AfterMap(afterFunction)](#M-AutoMapper-IMappingOperationOptions`2-AfterMap-System-Action{`0,`1}- 'AutoMapper.IMappingOperationOptions`2.AfterMap(System.Action{`0,`1})')
  - [BeforeMap(beforeFunction)](#M-AutoMapper-IMappingOperationOptions`2-BeforeMap-System-Action{`0,`1}- 'AutoMapper.IMappingOperationOptions`2.BeforeMap(System.Action{`0,`1})')
- [IMemberConfigurationExpression](#T-AutoMapper-IMemberConfigurationExpression 'AutoMapper.IMemberConfigurationExpression')
  - [ConvertUsing(valueConverterType)](#M-AutoMapper-IMemberConfigurationExpression-ConvertUsing-System-Type- 'AutoMapper.IMemberConfigurationExpression.ConvertUsing(System.Type)')
  - [ConvertUsing(valueConverterType,sourceMemberName)](#M-AutoMapper-IMemberConfigurationExpression-ConvertUsing-System-Type,System-String- 'AutoMapper.IMemberConfigurationExpression.ConvertUsing(System.Type,System.String)')
  - [ConvertUsing\`\`2(valueConverter,sourceMemberName)](#M-AutoMapper-IMemberConfigurationExpression-ConvertUsing``2-AutoMapper-IValueConverter{``0,``1},System-String- 'AutoMapper.IMemberConfigurationExpression.ConvertUsing``2(AutoMapper.IValueConverter{``0,``1},System.String)')
  - [MapFrom(valueResolverType)](#M-AutoMapper-IMemberConfigurationExpression-MapFrom-System-Type- 'AutoMapper.IMemberConfigurationExpression.MapFrom(System.Type)')
  - [MapFrom(valueResolverType,sourceMemberName)](#M-AutoMapper-IMemberConfigurationExpression-MapFrom-System-Type,System-String- 'AutoMapper.IMemberConfigurationExpression.MapFrom(System.Type,System.String)')
  - [MapFrom\`\`4(valueResolver,sourceMemberName)](#M-AutoMapper-IMemberConfigurationExpression-MapFrom``4-AutoMapper-IMemberValueResolver{``0,``1,``2,``3},System-String- 'AutoMapper.IMemberConfigurationExpression.MapFrom``4(AutoMapper.IMemberValueResolver{``0,``1,``2,``3},System.String)')
- [IMemberConfigurationExpression\`3](#T-AutoMapper-IMemberConfigurationExpression`3 'AutoMapper.IMemberConfigurationExpression`3')
  - [DestinationMember](#P-AutoMapper-IMemberConfigurationExpression`3-DestinationMember 'AutoMapper.IMemberConfigurationExpression`3.DestinationMember')
  - [Condition(condition)](#M-AutoMapper-IMemberConfigurationExpression`3-Condition-System-Func{`0,`1,`2,`2,AutoMapper-ResolutionContext,System-Boolean}- 'AutoMapper.IMemberConfigurationExpression`3.Condition(System.Func{`0,`1,`2,`2,AutoMapper.ResolutionContext,System.Boolean})')
  - [Condition(condition)](#M-AutoMapper-IMemberConfigurationExpression`3-Condition-System-Func{`0,`1,`2,`2,System-Boolean}- 'AutoMapper.IMemberConfigurationExpression`3.Condition(System.Func{`0,`1,`2,`2,System.Boolean})')
  - [Condition(condition)](#M-AutoMapper-IMemberConfigurationExpression`3-Condition-System-Func{`0,`1,`2,System-Boolean}- 'AutoMapper.IMemberConfigurationExpression`3.Condition(System.Func{`0,`1,`2,System.Boolean})')
  - [Condition(condition)](#M-AutoMapper-IMemberConfigurationExpression`3-Condition-System-Func{`0,`1,System-Boolean}- 'AutoMapper.IMemberConfigurationExpression`3.Condition(System.Func{`0,`1,System.Boolean})')
  - [Condition(condition)](#M-AutoMapper-IMemberConfigurationExpression`3-Condition-System-Func{`0,System-Boolean}- 'AutoMapper.IMemberConfigurationExpression`3.Condition(System.Func{`0,System.Boolean})')
  - [ConvertUsing\`\`1(valueConverter)](#M-AutoMapper-IMemberConfigurationExpression`3-ConvertUsing``1-AutoMapper-IValueConverter{``0,`2}- 'AutoMapper.IMemberConfigurationExpression`3.ConvertUsing``1(AutoMapper.IValueConverter{``0,`2})')
  - [ConvertUsing\`\`1(valueConverter,sourceMember)](#M-AutoMapper-IMemberConfigurationExpression`3-ConvertUsing``1-AutoMapper-IValueConverter{``0,`2},System-Linq-Expressions-Expression{System-Func{`0,``0}}- 'AutoMapper.IMemberConfigurationExpression`3.ConvertUsing``1(AutoMapper.IValueConverter{``0,`2},System.Linq.Expressions.Expression{System.Func{`0,``0}})')
  - [ConvertUsing\`\`1(valueConverter,sourceMemberName)](#M-AutoMapper-IMemberConfigurationExpression`3-ConvertUsing``1-AutoMapper-IValueConverter{``0,`2},System-String- 'AutoMapper.IMemberConfigurationExpression`3.ConvertUsing``1(AutoMapper.IValueConverter{``0,`2},System.String)')
  - [ConvertUsing\`\`2()](#M-AutoMapper-IMemberConfigurationExpression`3-ConvertUsing``2 'AutoMapper.IMemberConfigurationExpression`3.ConvertUsing``2')
  - [ConvertUsing\`\`2(sourceMember)](#M-AutoMapper-IMemberConfigurationExpression`3-ConvertUsing``2-System-Linq-Expressions-Expression{System-Func{`0,``1}}- 'AutoMapper.IMemberConfigurationExpression`3.ConvertUsing``2(System.Linq.Expressions.Expression{System.Func{`0,``1}})')
  - [ConvertUsing\`\`2(sourceMemberName)](#M-AutoMapper-IMemberConfigurationExpression`3-ConvertUsing``2-System-String- 'AutoMapper.IMemberConfigurationExpression`3.ConvertUsing``2(System.String)')
  - [DoNotUseDestinationValue()](#M-AutoMapper-IMemberConfigurationExpression`3-DoNotUseDestinationValue 'AutoMapper.IMemberConfigurationExpression`3.DoNotUseDestinationValue')
  - [MapAtRuntime()](#M-AutoMapper-IMemberConfigurationExpression`3-MapAtRuntime 'AutoMapper.IMemberConfigurationExpression`3.MapAtRuntime')
  - [MapFrom(valueResolver)](#M-AutoMapper-IMemberConfigurationExpression`3-MapFrom-AutoMapper-IValueResolver{`0,`1,`2}- 'AutoMapper.IMemberConfigurationExpression`3.MapFrom(AutoMapper.IValueResolver{`0,`1,`2})')
  - [MapFrom(sourceMembersPath)](#M-AutoMapper-IMemberConfigurationExpression`3-MapFrom-System-String- 'AutoMapper.IMemberConfigurationExpression`3.MapFrom(System.String)')
  - [MapFrom\`\`1()](#M-AutoMapper-IMemberConfigurationExpression`3-MapFrom``1 'AutoMapper.IMemberConfigurationExpression`3.MapFrom``1')
  - [MapFrom\`\`1(valueResolver,sourceMember)](#M-AutoMapper-IMemberConfigurationExpression`3-MapFrom``1-AutoMapper-IMemberValueResolver{`0,`1,``0,`2},System-Linq-Expressions-Expression{System-Func{`0,``0}}- 'AutoMapper.IMemberConfigurationExpression`3.MapFrom``1(AutoMapper.IMemberValueResolver{`0,`1,``0,`2},System.Linq.Expressions.Expression{System.Func{`0,``0}})')
  - [MapFrom\`\`1(mappingFunction)](#M-AutoMapper-IMemberConfigurationExpression`3-MapFrom``1-System-Func{`0,`1,``0}- 'AutoMapper.IMemberConfigurationExpression`3.MapFrom``1(System.Func{`0,`1,``0})')
  - [MapFrom\`\`1(mappingFunction)](#M-AutoMapper-IMemberConfigurationExpression`3-MapFrom``1-System-Func{`0,`1,`2,``0}- 'AutoMapper.IMemberConfigurationExpression`3.MapFrom``1(System.Func{`0,`1,`2,``0})')
  - [MapFrom\`\`1(mappingFunction)](#M-AutoMapper-IMemberConfigurationExpression`3-MapFrom``1-System-Func{`0,`1,`2,AutoMapper-ResolutionContext,``0}- 'AutoMapper.IMemberConfigurationExpression`3.MapFrom``1(System.Func{`0,`1,`2,AutoMapper.ResolutionContext,``0})')
  - [MapFrom\`\`2()](#M-AutoMapper-IMemberConfigurationExpression`3-MapFrom``2-System-Linq-Expressions-Expression{System-Func{`0,``1}}- 'AutoMapper.IMemberConfigurationExpression`3.MapFrom``2(System.Linq.Expressions.Expression{System.Func{`0,``1}})')
  - [MapFrom\`\`2(sourceMemberName)](#M-AutoMapper-IMemberConfigurationExpression`3-MapFrom``2-System-String- 'AutoMapper.IMemberConfigurationExpression`3.MapFrom``2(System.String)')
  - [PreCondition(condition)](#M-AutoMapper-IMemberConfigurationExpression`3-PreCondition-System-Func{`0,System-Boolean}- 'AutoMapper.IMemberConfigurationExpression`3.PreCondition(System.Func{`0,System.Boolean})')
  - [PreCondition(condition)](#M-AutoMapper-IMemberConfigurationExpression`3-PreCondition-System-Func{AutoMapper-ResolutionContext,System-Boolean}- 'AutoMapper.IMemberConfigurationExpression`3.PreCondition(System.Func{AutoMapper.ResolutionContext,System.Boolean})')
  - [PreCondition(condition)](#M-AutoMapper-IMemberConfigurationExpression`3-PreCondition-System-Func{`0,AutoMapper-ResolutionContext,System-Boolean}- 'AutoMapper.IMemberConfigurationExpression`3.PreCondition(System.Func{`0,AutoMapper.ResolutionContext,System.Boolean})')
  - [PreCondition(condition)](#M-AutoMapper-IMemberConfigurationExpression`3-PreCondition-System-Func{`0,`1,AutoMapper-ResolutionContext,System-Boolean}- 'AutoMapper.IMemberConfigurationExpression`3.PreCondition(System.Func{`0,`1,AutoMapper.ResolutionContext,System.Boolean})')
  - [SetMappingOrder(mappingOrder)](#M-AutoMapper-IMemberConfigurationExpression`3-SetMappingOrder-System-Int32- 'AutoMapper.IMemberConfigurationExpression`3.SetMappingOrder(System.Int32)')
  - [UseDestinationValue()](#M-AutoMapper-IMemberConfigurationExpression`3-UseDestinationValue 'AutoMapper.IMemberConfigurationExpression`3.UseDestinationValue')
- [IMemberValueResolver\`4](#T-AutoMapper-IMemberValueResolver`4 'AutoMapper.IMemberValueResolver`4')
  - [Resolve(source,destination,sourceMember,destMember,context)](#M-AutoMapper-IMemberValueResolver`4-Resolve-`0,`1,`2,`3,AutoMapper-ResolutionContext- 'AutoMapper.IMemberValueResolver`4.Resolve(`0,`1,`2,`3,AutoMapper.ResolutionContext)')
- [INamingConvention](#T-AutoMapper-INamingConvention 'AutoMapper.INamingConvention')
  - [SplittingExpression](#P-AutoMapper-INamingConvention-SplittingExpression 'AutoMapper.INamingConvention.SplittingExpression')
- [IObjectMapper](#T-AutoMapper-Internal-Mappers-IObjectMapper 'AutoMapper.Internal.Mappers.IObjectMapper')
  - [IsMatch(context)](#M-AutoMapper-Internal-Mappers-IObjectMapper-IsMatch-AutoMapper-Internal-TypePair@- 'AutoMapper.Internal.Mappers.IObjectMapper.IsMatch(AutoMapper.Internal.TypePair@)')
  - [MapExpression(configurationProvider,profileMap,memberMap,sourceExpression,destExpression)](#M-AutoMapper-Internal-Mappers-IObjectMapper-MapExpression-AutoMapper-Internal-IGlobalConfiguration,AutoMapper-ProfileMap,AutoMapper-MemberMap,System-Linq-Expressions-Expression,System-Linq-Expressions-Expression- 'AutoMapper.Internal.Mappers.IObjectMapper.MapExpression(AutoMapper.Internal.IGlobalConfiguration,AutoMapper.ProfileMap,AutoMapper.MemberMap,System.Linq.Expressions.Expression,System.Linq.Expressions.Expression)')
- [IPathConfigurationExpression\`3](#T-AutoMapper-Configuration-IPathConfigurationExpression`3 'AutoMapper.Configuration.IPathConfigurationExpression`3')
  - [Ignore()](#M-AutoMapper-Configuration-IPathConfigurationExpression`3-Ignore 'AutoMapper.Configuration.IPathConfigurationExpression`3.Ignore')
  - [MapFrom\`\`1(sourceMember)](#M-AutoMapper-Configuration-IPathConfigurationExpression`3-MapFrom``1-System-Linq-Expressions-Expression{System-Func{`0,``0}}- 'AutoMapper.Configuration.IPathConfigurationExpression`3.MapFrom``1(System.Linq.Expressions.Expression{System.Func{`0,``0}})')
- [IProfileConfiguration](#T-AutoMapper-IProfileConfiguration 'AutoMapper.IProfileConfiguration')
  - [ShouldMapField](#P-AutoMapper-IProfileConfiguration-ShouldMapField 'AutoMapper.IProfileConfiguration.ShouldMapField')
  - [ShouldMapMethod](#P-AutoMapper-IProfileConfiguration-ShouldMapMethod 'AutoMapper.IProfileConfiguration.ShouldMapMethod')
  - [ShouldMapProperty](#P-AutoMapper-IProfileConfiguration-ShouldMapProperty 'AutoMapper.IProfileConfiguration.ShouldMapProperty')
  - [ShouldUseConstructor](#P-AutoMapper-IProfileConfiguration-ShouldUseConstructor 'AutoMapper.IProfileConfiguration.ShouldUseConstructor')
  - [SourceExtensionMethods](#P-AutoMapper-IProfileConfiguration-SourceExtensionMethods 'AutoMapper.IProfileConfiguration.SourceExtensionMethods')
- [IProfileExpression](#T-AutoMapper-IProfileExpression 'AutoMapper.IProfileExpression')
  - [AllowNullCollections](#P-AutoMapper-IProfileExpression-AllowNullCollections 'AutoMapper.IProfileExpression.AllowNullCollections')
  - [AllowNullDestinationValues](#P-AutoMapper-IProfileExpression-AllowNullDestinationValues 'AutoMapper.IProfileExpression.AllowNullDestinationValues')
  - [DestinationMemberNamingConvention](#P-AutoMapper-IProfileExpression-DestinationMemberNamingConvention 'AutoMapper.IProfileExpression.DestinationMemberNamingConvention')
  - [SourceMemberNamingConvention](#P-AutoMapper-IProfileExpression-SourceMemberNamingConvention 'AutoMapper.IProfileExpression.SourceMemberNamingConvention')
  - [ValueTransformers](#P-AutoMapper-IProfileExpression-ValueTransformers 'AutoMapper.IProfileExpression.ValueTransformers')
  - [AddGlobalIgnore(propertyNameStartingWith)](#M-AutoMapper-IProfileExpression-AddGlobalIgnore-System-String- 'AutoMapper.IProfileExpression.AddGlobalIgnore(System.String)')
  - [ClearPrefixes()](#M-AutoMapper-IProfileExpression-ClearPrefixes 'AutoMapper.IProfileExpression.ClearPrefixes')
  - [CreateMap(sourceType,destinationType)](#M-AutoMapper-IProfileExpression-CreateMap-System-Type,System-Type- 'AutoMapper.IProfileExpression.CreateMap(System.Type,System.Type)')
  - [CreateMap(sourceType,destinationType,memberList)](#M-AutoMapper-IProfileExpression-CreateMap-System-Type,System-Type,AutoMapper-MemberList- 'AutoMapper.IProfileExpression.CreateMap(System.Type,System.Type,AutoMapper.MemberList)')
  - [CreateMap\`\`2()](#M-AutoMapper-IProfileExpression-CreateMap``2 'AutoMapper.IProfileExpression.CreateMap``2')
  - [CreateMap\`\`2(memberList)](#M-AutoMapper-IProfileExpression-CreateMap``2-AutoMapper-MemberList- 'AutoMapper.IProfileExpression.CreateMap``2(AutoMapper.MemberList)')
  - [CreateProjection\`\`2()](#M-AutoMapper-IProfileExpression-CreateProjection``2 'AutoMapper.IProfileExpression.CreateProjection``2')
  - [CreateProjection\`\`2(memberList)](#M-AutoMapper-IProfileExpression-CreateProjection``2-AutoMapper-MemberList- 'AutoMapper.IProfileExpression.CreateProjection``2(AutoMapper.MemberList)')
  - [DisableConstructorMapping()](#M-AutoMapper-IProfileExpression-DisableConstructorMapping 'AutoMapper.IProfileExpression.DisableConstructorMapping')
  - [IncludeSourceExtensionMethods(type)](#M-AutoMapper-IProfileExpression-IncludeSourceExtensionMethods-System-Type- 'AutoMapper.IProfileExpression.IncludeSourceExtensionMethods(System.Type)')
  - [RecognizeDestinationPostfixes(postfixes)](#M-AutoMapper-IProfileExpression-RecognizeDestinationPostfixes-System-String[]- 'AutoMapper.IProfileExpression.RecognizeDestinationPostfixes(System.String[])')
  - [RecognizeDestinationPrefixes(prefixes)](#M-AutoMapper-IProfileExpression-RecognizeDestinationPrefixes-System-String[]- 'AutoMapper.IProfileExpression.RecognizeDestinationPrefixes(System.String[])')
  - [RecognizePostfixes(postfixes)](#M-AutoMapper-IProfileExpression-RecognizePostfixes-System-String[]- 'AutoMapper.IProfileExpression.RecognizePostfixes(System.String[])')
  - [RecognizePrefixes(prefixes)](#M-AutoMapper-IProfileExpression-RecognizePrefixes-System-String[]- 'AutoMapper.IProfileExpression.RecognizePrefixes(System.String[])')
  - [ReplaceMemberName(original,newValue)](#M-AutoMapper-IProfileExpression-ReplaceMemberName-System-String,System-String- 'AutoMapper.IProfileExpression.ReplaceMemberName(System.String,System.String)')
- [IProfileExpressionInternal](#T-AutoMapper-Internal-IProfileExpressionInternal 'AutoMapper.Internal.IProfileExpressionInternal')
  - [EnableNullPropagationForQueryMapping](#P-AutoMapper-Internal-IProfileExpressionInternal-EnableNullPropagationForQueryMapping 'AutoMapper.Internal.IProfileExpressionInternal.EnableNullPropagationForQueryMapping')
  - [FieldMappingEnabled](#P-AutoMapper-Internal-IProfileExpressionInternal-FieldMappingEnabled 'AutoMapper.Internal.IProfileExpressionInternal.FieldMappingEnabled')
  - [MethodMappingEnabled](#P-AutoMapper-Internal-IProfileExpressionInternal-MethodMappingEnabled 'AutoMapper.Internal.IProfileExpressionInternal.MethodMappingEnabled')
  - [ForAllMaps(configuration)](#M-AutoMapper-Internal-IProfileExpressionInternal-ForAllMaps-System-Action{AutoMapper-TypeMap,AutoMapper-IMappingExpression}- 'AutoMapper.Internal.IProfileExpressionInternal.ForAllMaps(System.Action{AutoMapper.TypeMap,AutoMapper.IMappingExpression})')
  - [ForAllPropertyMaps(condition,memberOptions)](#M-AutoMapper-Internal-IProfileExpressionInternal-ForAllPropertyMaps-System-Func{AutoMapper-PropertyMap,System-Boolean},System-Action{AutoMapper-PropertyMap,AutoMapper-IMemberConfigurationExpression}- 'AutoMapper.Internal.IProfileExpressionInternal.ForAllPropertyMaps(System.Func{AutoMapper.PropertyMap,System.Boolean},System.Action{AutoMapper.PropertyMap,AutoMapper.IMemberConfigurationExpression})')
- [IProjectionExpressionBase\`3](#T-AutoMapper-IProjectionExpressionBase`3 'AutoMapper.IProjectionExpressionBase`3')
  - [ValueTransformers](#P-AutoMapper-IProjectionExpressionBase`3-ValueTransformers 'AutoMapper.IProjectionExpressionBase`3.ValueTransformers')
  - [ConstructUsing(ctor)](#M-AutoMapper-IProjectionExpressionBase`3-ConstructUsing-System-Linq-Expressions-Expression{System-Func{`0,`1}}- 'AutoMapper.IProjectionExpressionBase`3.ConstructUsing(System.Linq.Expressions.Expression{System.Func{`0,`1}})')
  - [ConvertUsing(mappingExpression)](#M-AutoMapper-IProjectionExpressionBase`3-ConvertUsing-System-Linq-Expressions-Expression{System-Func{`0,`1}}- 'AutoMapper.IProjectionExpressionBase`3.ConvertUsing(System.Linq.Expressions.Expression{System.Func{`0,`1}})')
  - [ForCtorParam(ctorParamName,paramOptions)](#M-AutoMapper-IProjectionExpressionBase`3-ForCtorParam-System-String,System-Action{AutoMapper-Configuration-ICtorParamConfigurationExpression{`0}}- 'AutoMapper.IProjectionExpressionBase`3.ForCtorParam(System.String,System.Action{AutoMapper.Configuration.ICtorParamConfigurationExpression{`0}})')
  - [MaxDepth(depth)](#M-AutoMapper-IProjectionExpressionBase`3-MaxDepth-System-Int32- 'AutoMapper.IProjectionExpressionBase`3.MaxDepth(System.Int32)')
  - [ValidateMemberList(memberList)](#M-AutoMapper-IProjectionExpressionBase`3-ValidateMemberList-AutoMapper-MemberList- 'AutoMapper.IProjectionExpressionBase`3.ValidateMemberList(AutoMapper.MemberList)')
- [IProjectionExpression\`2](#T-AutoMapper-IProjectionExpression`2 'AutoMapper.IProjectionExpression`2')
  - [ForMember\`\`1(destinationMember,memberOptions)](#M-AutoMapper-IProjectionExpression`2-ForMember``1-System-Linq-Expressions-Expression{System-Func{`1,``0}},System-Action{AutoMapper-IProjectionMemberConfiguration{`0,`1,``0}}- 'AutoMapper.IProjectionExpression`2.ForMember``1(System.Linq.Expressions.Expression{System.Func{`1,``0}},System.Action{AutoMapper.IProjectionMemberConfiguration{`0,`1,``0}})')
- [IProjectionExpression\`3](#T-AutoMapper-IProjectionExpression`3 'AutoMapper.IProjectionExpression`3')
  - [AddTransform\`\`1(transformer)](#M-AutoMapper-IProjectionExpression`3-AddTransform``1-System-Linq-Expressions-Expression{System-Func{``0,``0}}- 'AutoMapper.IProjectionExpression`3.AddTransform``1(System.Linq.Expressions.Expression{System.Func{``0,``0}})')
  - [IncludeMembers(memberExpressions)](#M-AutoMapper-IProjectionExpression`3-IncludeMembers-System-Linq-Expressions-Expression{System-Func{`0,System-Object}}[]- 'AutoMapper.IProjectionExpression`3.IncludeMembers(System.Linq.Expressions.Expression{System.Func{`0,System.Object}}[])')
- [IProjectionMemberConfiguration\`3](#T-AutoMapper-IProjectionMemberConfiguration`3 'AutoMapper.IProjectionMemberConfiguration`3')
  - [AddTransform(transformer)](#M-AutoMapper-IProjectionMemberConfiguration`3-AddTransform-System-Linq-Expressions-Expression{System-Func{`2,`2}}- 'AutoMapper.IProjectionMemberConfiguration`3.AddTransform(System.Linq.Expressions.Expression{System.Func{`2,`2}})')
  - [AllowNull()](#M-AutoMapper-IProjectionMemberConfiguration`3-AllowNull 'AutoMapper.IProjectionMemberConfiguration`3.AllowNull')
  - [DoNotAllowNull()](#M-AutoMapper-IProjectionMemberConfiguration`3-DoNotAllowNull 'AutoMapper.IProjectionMemberConfiguration`3.DoNotAllowNull')
  - [ExplicitExpansion()](#M-AutoMapper-IProjectionMemberConfiguration`3-ExplicitExpansion 'AutoMapper.IProjectionMemberConfiguration`3.ExplicitExpansion')
  - [Ignore()](#M-AutoMapper-IProjectionMemberConfiguration`3-Ignore 'AutoMapper.IProjectionMemberConfiguration`3.Ignore')
  - [MapFrom\`\`1(mapExpression)](#M-AutoMapper-IProjectionMemberConfiguration`3-MapFrom``1-System-Linq-Expressions-Expression{System-Func{`0,``0}}- 'AutoMapper.IProjectionMemberConfiguration`3.MapFrom``1(System.Linq.Expressions.Expression{System.Func{`0,``0}})')
  - [NullSubstitute(nullSubstitute)](#M-AutoMapper-IProjectionMemberConfiguration`3-NullSubstitute-System-Object- 'AutoMapper.IProjectionMemberConfiguration`3.NullSubstitute(System.Object)')
- [ISourceMemberConfigurationExpression](#T-AutoMapper-Configuration-ISourceMemberConfigurationExpression 'AutoMapper.Configuration.ISourceMemberConfigurationExpression')
  - [DoNotValidate()](#M-AutoMapper-Configuration-ISourceMemberConfigurationExpression-DoNotValidate 'AutoMapper.Configuration.ISourceMemberConfigurationExpression.DoNotValidate')
- [ITypeConverter\`2](#T-AutoMapper-ITypeConverter`2 'AutoMapper.ITypeConverter`2')
  - [Convert(source,destination,context)](#M-AutoMapper-ITypeConverter`2-Convert-`0,`1,AutoMapper-ResolutionContext- 'AutoMapper.ITypeConverter`2.Convert(`0,`1,AutoMapper.ResolutionContext)')
- [IValueConverter\`2](#T-AutoMapper-IValueConverter`2 'AutoMapper.IValueConverter`2')
  - [Convert(sourceMember,context)](#M-AutoMapper-IValueConverter`2-Convert-`0,AutoMapper-ResolutionContext- 'AutoMapper.IValueConverter`2.Convert(`0,AutoMapper.ResolutionContext)')
- [IValueResolver\`3](#T-AutoMapper-IValueResolver`3 'AutoMapper.IValueResolver`3')
  - [Resolve(source,destination,destMember,context)](#M-AutoMapper-IValueResolver`3-Resolve-`0,`1,`2,AutoMapper-ResolutionContext- 'AutoMapper.IValueResolver`3.Resolve(`0,`1,`2,AutoMapper.ResolutionContext)')
- [IgnoreAttribute](#T-AutoMapper-Configuration-Annotations-IgnoreAttribute 'AutoMapper.Configuration.Annotations.IgnoreAttribute')
- [MapAtRuntimeAttribute](#T-AutoMapper-Configuration-Annotations-MapAtRuntimeAttribute 'AutoMapper.Configuration.Annotations.MapAtRuntimeAttribute')
- [MapperConfigurationExpression](#T-AutoMapper-MapperConfigurationExpression 'AutoMapper.MapperConfigurationExpression')
  - [AutoMapper#Internal#IGlobalConfigurationExpression#AllowAdditiveTypeMapCreation](#P-AutoMapper-MapperConfigurationExpression-AutoMapper#Internal#IGlobalConfigurationExpression#AllowAdditiveTypeMapCreation 'AutoMapper.MapperConfigurationExpression.AutoMapper#Internal#IGlobalConfigurationExpression#AllowAdditiveTypeMapCreation')
  - [AutoMapper#Internal#IGlobalConfigurationExpression#MaxExecutionPlanDepth](#P-AutoMapper-MapperConfigurationExpression-AutoMapper#Internal#IGlobalConfigurationExpression#MaxExecutionPlanDepth 'AutoMapper.MapperConfigurationExpression.AutoMapper#Internal#IGlobalConfigurationExpression#MaxExecutionPlanDepth')
  - [AutoMapper#Internal#IGlobalConfigurationExpression#RecursiveQueriesMaxDepth](#P-AutoMapper-MapperConfigurationExpression-AutoMapper#Internal#IGlobalConfigurationExpression#RecursiveQueriesMaxDepth 'AutoMapper.MapperConfigurationExpression.AutoMapper#Internal#IGlobalConfigurationExpression#RecursiveQueriesMaxDepth')
  - [AutoMapper#Internal#IGlobalConfigurationExpression#Validator(validator)](#M-AutoMapper-MapperConfigurationExpression-AutoMapper#Internal#IGlobalConfigurationExpression#Validator-System-Action{AutoMapper-Configuration-ValidationContext}- 'AutoMapper.MapperConfigurationExpression.AutoMapper#Internal#IGlobalConfigurationExpression#Validator(System.Action{AutoMapper.Configuration.ValidationContext})')
- [MappingOrderAttribute](#T-AutoMapper-Configuration-Annotations-MappingOrderAttribute 'AutoMapper.Configuration.Annotations.MappingOrderAttribute')
- [MemberList](#T-AutoMapper-MemberList 'AutoMapper.MemberList')
  - [Destination](#F-AutoMapper-MemberList-Destination 'AutoMapper.MemberList.Destination')
  - [None](#F-AutoMapper-MemberList-None 'AutoMapper.MemberList.None')
  - [Source](#F-AutoMapper-MemberList-Source 'AutoMapper.MemberList.Source')
- [MemberMap](#T-AutoMapper-MemberMap 'AutoMapper.MemberMap')
- [MissingRegistrationException](#T-mwo-SimpleDI-MissingRegistrationException 'mwo.SimpleDI.MissingRegistrationException')
  - [#ctor(t)](#M-mwo-SimpleDI-MissingRegistrationException-#ctor-System-Type- 'mwo.SimpleDI.MissingRegistrationException.#ctor(System.Type)')
  - [#ctor(message)](#M-mwo-SimpleDI-MissingRegistrationException-#ctor-System-String- 'mwo.SimpleDI.MissingRegistrationException.#ctor(System.String)')
  - [#ctor(message,innerException)](#M-mwo-SimpleDI-MissingRegistrationException-#ctor-System-String,System-Exception- 'mwo.SimpleDI.MissingRegistrationException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-mwo-SimpleDI-MissingRegistrationException-#ctor 'mwo.SimpleDI.MissingRegistrationException.#ctor')
  - [#ctor(serializationInfo,streamingContext)](#M-mwo-SimpleDI-MissingRegistrationException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'mwo.SimpleDI.MissingRegistrationException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [NullSubstituteAttribute](#T-AutoMapper-Configuration-Annotations-NullSubstituteAttribute 'AutoMapper.Configuration.Annotations.NullSubstituteAttribute')
  - [Value](#P-AutoMapper-Configuration-Annotations-NullSubstituteAttribute-Value 'AutoMapper.Configuration.Annotations.NullSubstituteAttribute.Value')
- [NullsafeQueryRewriter](#T-AutoMapper-QueryableExtensions-NullsafeQueryRewriter 'AutoMapper.QueryableExtensions.NullsafeQueryRewriter')
  - [VisitMember()](#M-AutoMapper-QueryableExtensions-NullsafeQueryRewriter-VisitMember-System-Linq-Expressions-MemberExpression- 'AutoMapper.QueryableExtensions.NullsafeQueryRewriter.VisitMember(System.Linq.Expressions.MemberExpression)')
  - [VisitMethodCall()](#M-AutoMapper-QueryableExtensions-NullsafeQueryRewriter-VisitMethodCall-System-Linq-Expressions-MethodCallExpression- 'AutoMapper.QueryableExtensions.NullsafeQueryRewriter.VisitMethodCall(System.Linq.Expressions.MethodCallExpression)')
- [ObjectMapper\`2](#T-AutoMapper-Internal-Mappers-ObjectMapper`2 'AutoMapper.Internal.Mappers.ObjectMapper`2')
  - [IsMatch(context)](#M-AutoMapper-Internal-Mappers-ObjectMapper`2-IsMatch-AutoMapper-Internal-TypePair@- 'AutoMapper.Internal.Mappers.ObjectMapper`2.IsMatch(AutoMapper.Internal.TypePair@)')
  - [Map(source,destination,sourceType,destinationType,context)](#M-AutoMapper-Internal-Mappers-ObjectMapper`2-Map-`0,`1,System-Type,System-Type,AutoMapper-ResolutionContext- 'AutoMapper.Internal.Mappers.ObjectMapper`2.Map(`0,`1,System.Type,System.Type,AutoMapper.ResolutionContext)')
- [Profile](#T-AutoMapper-Profile 'AutoMapper.Profile')
- [QueryMapperHelper](#T-AutoMapper-QueryableExtensions-Impl-QueryMapperHelper 'AutoMapper.QueryableExtensions.Impl.QueryMapperHelper')
  - [ReplaceItemType(targetType,oldType,newType)](#M-AutoMapper-QueryableExtensions-Impl-QueryMapperHelper-ReplaceItemType-System-Type,System-Type,System-Type- 'AutoMapper.QueryableExtensions.Impl.QueryMapperHelper.ReplaceItemType(System.Type,System.Type,System.Type)')
- [ResolutionContext](#T-AutoMapper-ResolutionContext 'AutoMapper.ResolutionContext')
  - [InstanceCache](#P-AutoMapper-ResolutionContext-InstanceCache 'AutoMapper.ResolutionContext.InstanceCache')
  - [Items](#P-AutoMapper-ResolutionContext-Items 'AutoMapper.ResolutionContext.Items')
  - [Mapper](#P-AutoMapper-ResolutionContext-Mapper 'AutoMapper.ResolutionContext.Mapper')
  - [Options](#P-AutoMapper-ResolutionContext-Options 'AutoMapper.ResolutionContext.Options')
  - [TypeDepth](#P-AutoMapper-ResolutionContext-TypeDepth 'AutoMapper.ResolutionContext.TypeDepth')
- [SourceMemberAttribute](#T-AutoMapper-Configuration-Annotations-SourceMemberAttribute 'AutoMapper.Configuration.Annotations.SourceMemberAttribute')
- [SourceMemberConfig](#T-AutoMapper-Configuration-SourceMemberConfig 'AutoMapper.Configuration.SourceMemberConfig')
- [TypeDetails](#T-AutoMapper-Internal-TypeDetails 'AutoMapper.Internal.TypeDetails')
- [TypeMap](#T-AutoMapper-TypeMap 'AutoMapper.TypeMap')
- [UseExistingValueAttribute](#T-AutoMapper-Configuration-Annotations-UseExistingValueAttribute 'AutoMapper.Configuration.Annotations.UseExistingValueAttribute')
- [ValueConverterAttribute](#T-AutoMapper-Configuration-Annotations-ValueConverterAttribute 'AutoMapper.Configuration.Annotations.ValueConverterAttribute')
  - [Type](#P-AutoMapper-Configuration-Annotations-ValueConverterAttribute-Type 'AutoMapper.Configuration.Annotations.ValueConverterAttribute.Type')
- [ValueResolverAttribute](#T-AutoMapper-Configuration-Annotations-ValueResolverAttribute 'AutoMapper.Configuration.Annotations.ValueResolverAttribute')
  - [Type](#P-AutoMapper-Configuration-Annotations-ValueResolverAttribute-Type 'AutoMapper.Configuration.Annotations.ValueResolverAttribute.Type')
- [ValueTransformerConfigurationExtensions](#T-AutoMapper-ValueTransformerConfigurationExtensions 'AutoMapper.ValueTransformerConfigurationExtensions')
  - [Add\`\`1(valueTransformers,transformer)](#M-AutoMapper-ValueTransformerConfigurationExtensions-Add``1-System-Collections-Generic-List{AutoMapper-ValueTransformerConfiguration},System-Linq-Expressions-Expression{System-Func{``0,``0}}- 'AutoMapper.ValueTransformerConfigurationExtensions.Add``1(System.Collections.Generic.List{AutoMapper.ValueTransformerConfiguration},System.Linq.Expressions.Expression{System.Func{``0,``0}})')

<a name='T-AutoMapper-AutoMapAttribute'></a>
## AutoMapAttribute `type`

##### Namespace

AutoMapper

##### Summary

Auto map to this destination type from the specified source type.
Discovered during scanning assembly scanning for configuration when calling [](#O-AutoMapper-IMapperConfigurationExpression-AddMaps 'AutoMapper.IMapperConfigurationExpression.AddMaps')

<a name='P-AutoMapper-AutoMapAttribute-ConstructUsingServiceLocator'></a>
### ConstructUsingServiceLocator `property`

##### Summary

If set to true, construct the destination object using the service locator.

<a name='P-AutoMapper-AutoMapAttribute-DisableCtorValidation'></a>
### DisableCtorValidation `property`

##### Summary

If set to true, disable constructor validation.

<a name='P-AutoMapper-AutoMapAttribute-IncludeAllDerived'></a>
### IncludeAllDerived `property`

##### Summary

If set to true, include this configuration in all derived types' maps.

<a name='P-AutoMapper-AutoMapAttribute-MaxDepth'></a>
### MaxDepth `property`

##### Summary

For self-referential types, limit recurse depth.

<a name='P-AutoMapper-AutoMapAttribute-PreserveReferences'></a>
### PreserveReferences `property`

##### Summary

If set to true, preserve object identity. Useful for circular references.

<a name='P-AutoMapper-AutoMapAttribute-TypeConverter'></a>
### TypeConverter `property`

##### Summary

Skip normal member mapping and convert using a [ITypeConverter\`2](#T-AutoMapper-ITypeConverter`2 'AutoMapper.ITypeConverter`2') instantiated during mapping.

<a name='T-AutoMapper-AutoMapperMappingException'></a>
## AutoMapperMappingException `type`

##### Namespace

AutoMapper

##### Summary

Wraps mapping exceptions. Check exception.ToString() for the full error message.

<a name='T-mwo-SimpleDI-DependencyContainer'></a>
## DependencyContainer `type`

##### Namespace

mwo.SimpleDI

##### Summary

A container to register to and resolve dependencies from.

<a name='M-mwo-SimpleDI-DependencyContainer-#ctor-mwo-SimpleDI-IDependencyContainer-'></a>
### #ctor(parentContainer) `constructor`

##### Summary

Initializes a new instance of the mwo.SimpleDI.DependencyContainer class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parentContainer | [mwo.SimpleDI.IDependencyContainer](#T-mwo-SimpleDI-IDependencyContainer 'mwo.SimpleDI.IDependencyContainer') | A container to be set as the parent. Is considered when resolving. |

<a name='M-mwo-SimpleDI-DependencyContainer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the mwo.SimpleDI.DependencyContainer class.

##### Parameters

This constructor has no parameters.

<a name='P-mwo-SimpleDI-DependencyContainer-ParentContainer'></a>
### ParentContainer `property`

##### Summary

Containers may have a parent container that is considered when resolving.

<a name='P-mwo-SimpleDI-DependencyContainer-Registrations'></a>
### Registrations `property`

##### Summary

A collection holding all locally registered types. ParentContainer may contain more in its Registrations.
Local Registrations beat the Registrations of the ParentContainer.

<a name='M-mwo-SimpleDI-DependencyContainer-IsRegistered``1'></a>
### IsRegistered\`\`1() `method`

##### Summary

Checks whether a registration is present for the given type.

##### Returns

true if the type is registered to the container or its parent.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that shall be checked. |

<a name='M-mwo-SimpleDI-DependencyContainer-RegisterStrong``1-System-Func{mwo-SimpleDI-IDependencyContainer,``0}-'></a>
### RegisterStrong\`\`1(builder) `method`

##### Summary

Registers the builder as a generator for resolving the given type.
Overwrites existing registrations for the type.

##### Returns

The container.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [System.Func{mwo.SimpleDI.IDependencyContainer,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{mwo.SimpleDI.IDependencyContainer,``0}') | The function to be executed when the given type is resolved. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that shall be registered. |

<a name='M-mwo-SimpleDI-DependencyContainer-RegisterWeak``1-System-Func{mwo-SimpleDI-IDependencyContainer,``0}-'></a>
### RegisterWeak\`\`1(builder) `method`

##### Summary

Registers the builder as a generator for resolving the given type.
Skips registration if the type is already present in the Registrations.

##### Returns

The container.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [System.Func{mwo.SimpleDI.IDependencyContainer,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{mwo.SimpleDI.IDependencyContainer,``0}') | The function to be executed when the given type is resolved. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that shall be registered. |

<a name='M-mwo-SimpleDI-DependencyContainer-Register``1-System-Func{mwo-SimpleDI-IDependencyContainer,``0}-'></a>
### Register\`\`1(builder) `method`

##### Summary

Registers the builder as a generator for resolving the given type.
Throws if a builder is already registered for the type.

##### Returns

The container.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [System.Func{mwo.SimpleDI.IDependencyContainer,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{mwo.SimpleDI.IDependencyContainer,``0}') | The function to be executed when the given type is resolved. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that shall be registered. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [mwo.SimpleDI.DuplicateRegistrationException](#T-mwo-SimpleDI-DuplicateRegistrationException 'mwo.SimpleDI.DuplicateRegistrationException') | Thrown when a Registration was already present for the type |

<a name='M-mwo-SimpleDI-DependencyContainer-Resolve``1'></a>
### Resolve\`\`1() `method`

##### Summary

Resolves a previously registered object.

##### Returns

An object of the type T

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that shall be resolved. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [mwo.SimpleDI.MissingRegistrationException](#T-mwo-SimpleDI-MissingRegistrationException 'mwo.SimpleDI.MissingRegistrationException') | Thrown when no Registration was detected for the type. |

<a name='M-mwo-SimpleDI-DependencyContainer-TryResolve``1-``0@-'></a>
### TryResolve\`\`1(obj) `method`

##### Summary

Tries to resolve an objectt of the given type.

##### Returns

true, if resolved sucessfully.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [\`\`0@](#T-``0@ '``0@') | If true is returned, contains an object of type T, otherwise obj is default. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that shall be resolved. |

<a name='T-mwo-SimpleDI-DependencyContainerManager'></a>
## DependencyContainerManager `type`

##### Namespace

mwo.SimpleDI

##### Summary

Manager class to interact with IDependencyContainers.

<a name='P-mwo-SimpleDI-DependencyContainerManager-Default'></a>
### Default `property`

##### Summary

A Singleton Container that will always yield the same DependencyContainer no matter from where the Property was called.

<a name='P-mwo-SimpleDI-DependencyContainerManager-ManagedContainers'></a>
### ManagedContainers `property`

##### Summary

Stores references to named dependency containers.

<a name='P-mwo-SimpleDI-DependencyContainerManager-Unique'></a>
### Unique `property`

##### Summary

Always generates a new Unique Container with Default Container as Parent.

<a name='M-mwo-SimpleDI-DependencyContainerManager-GetOrCreate-System-String,mwo-SimpleDI-IDependencyContainer-'></a>
### GetOrCreate(name,parent) `method`

##### Summary

Gets or creates a named container.
A reference to the container will be held in ManagedContainers. If called again, existing container will be taken from there.

##### Returns

A deoendency container.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A key for identifying the named container. |
| parent | [mwo.SimpleDI.IDependencyContainer](#T-mwo-SimpleDI-IDependencyContainer 'mwo.SimpleDI.IDependencyContainer') | Optionally pass a parent for container hirachies. If not Specified, Default is taken. |

<a name='M-mwo-SimpleDI-DependencyContainerManager-Reset'></a>
### Reset() `method`

##### Summary

Remove all references to containers managed.

##### Parameters

This method has no parameters.

<a name='T-mwo-SimpleDI-DuplicateRegistrationException'></a>
## DuplicateRegistrationException `type`

##### Namespace

mwo.SimpleDI

##### Summary

The exception is thrown if the state of the registrations is not correct while registering.

<a name='M-mwo-SimpleDI-DuplicateRegistrationException-#ctor-System-Type-'></a>
### #ctor(t) `constructor`

##### Summary

Initializes a new instance of the mwo.SimpleDI.DuplicateRegistrationException class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The type that was already registered, is wrapped into a message that describes the error. |

<a name='M-mwo-SimpleDI-DuplicateRegistrationException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Initializes a new instance of the mwo.SimpleDI.DuplicateRegistrationException class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message that describes the error. |

<a name='M-mwo-SimpleDI-DuplicateRegistrationException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,innerException) `constructor`

##### Summary

Initializes a new instance of the mwo.SimpleDI.DuplicateRegistrationException class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message that describes the error. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The exception that is the cause of the current exception. |

<a name='M-mwo-SimpleDI-DuplicateRegistrationException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the mwo.SimpleDI.DuplicateRegistrationException class.

##### Parameters

This constructor has no parameters.

<a name='M-mwo-SimpleDI-DuplicateRegistrationException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor(serializationInfo,streamingContext) `constructor`

##### Summary

Initializes a new instance of the mwo.SimpleDI.DuplicateRegistrationException class with serailized data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serializationInfo | [System.Runtime.Serialization.SerializationInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.SerializationInfo 'System.Runtime.Serialization.SerializationInfo') | The object that holds the serialized object data. |
| streamingContext | [System.Runtime.Serialization.StreamingContext](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.StreamingContext 'System.Runtime.Serialization.StreamingContext') | The contextual information about the source or destination. |

<a name='T-AutoMapper-QueryableExtensions-Extensions'></a>
## Extensions `type`

##### Namespace

AutoMapper.QueryableExtensions

##### Summary

Queryable extensions for AutoMapper

<a name='M-AutoMapper-QueryableExtensions-Extensions-Map``2-System-Linq-IQueryable{``0},System-Linq-IQueryable{``1},AutoMapper-IConfigurationProvider-'></a>
### Map\`\`2(sourceQuery,destQuery,config) `method`

##### Summary

Maps a queryable expression of a source type to a queryable expression of a destination type

##### Returns

Mapped destination queryable

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceQuery | [System.Linq.IQueryable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable{``0}') | Source queryable |
| destQuery | [System.Linq.IQueryable{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable{``1}') | Destination queryable |
| config | [AutoMapper.IConfigurationProvider](#T-AutoMapper-IConfigurationProvider 'AutoMapper.IConfigurationProvider') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Source type |
| TDestination | Destination type |

<a name='M-AutoMapper-QueryableExtensions-Extensions-ProjectTo-System-Linq-IQueryable,System-Type,AutoMapper-IConfigurationProvider-'></a>
### ProjectTo(source,destinationType,configuration) `method`

##### Summary

Extension method to project from a queryable using the provided mapping engine

##### Returns

Expression to project into

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Linq.IQueryable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable') | Queryable source |
| destinationType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Destination type |
| configuration | [AutoMapper.IConfigurationProvider](#T-AutoMapper-IConfigurationProvider 'AutoMapper.IConfigurationProvider') | Mapper configuration |

##### Remarks

Projections are only calculated once and cached

<a name='M-AutoMapper-QueryableExtensions-Extensions-ProjectTo-System-Linq-IQueryable,System-Type,AutoMapper-IConfigurationProvider,System-Collections-Generic-IDictionary{System-String,System-Object},System-String[]-'></a>
### ProjectTo(source,destinationType,configuration,parameters,membersToExpand) `method`

##### Summary

Projects the source type to the destination type given the mapping configuration

##### Returns

Queryable result, use queryable extension methods to project and execute result

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Linq.IQueryable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable') | Queryable source |
| destinationType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Destination type to map to |
| configuration | [AutoMapper.IConfigurationProvider](#T-AutoMapper-IConfigurationProvider 'AutoMapper.IConfigurationProvider') | Mapper configuration |
| parameters | [System.Collections.Generic.IDictionary{System.String,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{System.String,System.Object}') | Optional parameter object for parameterized mapping expressions |
| membersToExpand | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Explicit members to expand |

<a name='M-AutoMapper-QueryableExtensions-Extensions-ProjectTo``1-System-Linq-IQueryable,AutoMapper-IConfigurationProvider,System-Object,System-Linq-Expressions-Expression{System-Func{``0,System-Object}}[]-'></a>
### ProjectTo\`\`1(source,configuration,parameters,membersToExpand) `method`

##### Summary

Extension method to project from a queryable using the provided mapping engine

##### Returns

Expression to project into

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Linq.IQueryable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable') | Queryable source |
| configuration | [AutoMapper.IConfigurationProvider](#T-AutoMapper-IConfigurationProvider 'AutoMapper.IConfigurationProvider') | Mapper configuration |
| parameters | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Optional parameter object for parameterized mapping expressions |
| membersToExpand | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Object}}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,System.Object}}[]') | Explicit members to expand |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDestination | Destination type |

##### Remarks

Projections are only calculated once and cached

<a name='M-AutoMapper-QueryableExtensions-Extensions-ProjectTo``1-System-Linq-IQueryable,AutoMapper-IConfigurationProvider,System-Linq-Expressions-Expression{System-Func{``0,System-Object}}[]-'></a>
### ProjectTo\`\`1(source,configuration,membersToExpand) `method`

##### Summary

Extension method to project from a queryable using the provided mapping engine

##### Returns

Expression to project into

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Linq.IQueryable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable') | Queryable source |
| configuration | [AutoMapper.IConfigurationProvider](#T-AutoMapper-IConfigurationProvider 'AutoMapper.IConfigurationProvider') | Mapper configuration |
| membersToExpand | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Object}}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,System.Object}}[]') | Explicit members to expand |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDestination | Destination type |

##### Remarks

Projections are only calculated once and cached

<a name='M-AutoMapper-QueryableExtensions-Extensions-ProjectTo``1-System-Linq-IQueryable,AutoMapper-IConfigurationProvider,System-Collections-Generic-IDictionary{System-String,System-Object},System-String[]-'></a>
### ProjectTo\`\`1(source,configuration,parameters,membersToExpand) `method`

##### Summary

Projects the source type to the destination type given the mapping configuration

##### Returns

Queryable result, use queryable extension methods to project and execute result

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Linq.IQueryable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable') | Queryable source |
| configuration | [AutoMapper.IConfigurationProvider](#T-AutoMapper-IConfigurationProvider 'AutoMapper.IConfigurationProvider') | Mapper configuration |
| parameters | [System.Collections.Generic.IDictionary{System.String,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{System.String,System.Object}') | Optional parameter object for parameterized mapping expressions |
| membersToExpand | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Explicit members to expand |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDestination | Destination type to map to |

<a name='T-AutoMapper-Features-Features`1'></a>
## Features\`1 `type`

##### Namespace

AutoMapper.Features

<a name='M-AutoMapper-Features-Features`1-Get``1'></a>
### Get\`\`1() `method`

##### Summary

Gets the feature of type `TFeatureToFind`.

##### Returns

The feature or null if feature not exists.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TFeatureToFind | The type of the feature. |

<a name='M-AutoMapper-Features-Features`1-Set-`0-'></a>
### Set(feature) `method`

##### Summary

Add or update the feature. Existing feature of the same type will be replaced.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| feature | [\`0](#T-`0 '`0') | The feature. |

<a name='T-AutoMapper-IConfigurationProvider'></a>
## IConfigurationProvider `type`

##### Namespace

AutoMapper

<a name='M-AutoMapper-IConfigurationProvider-AssertConfigurationIsValid'></a>
### AssertConfigurationIsValid() `method`

##### Summary

Dry run all configured type maps and throw [AutoMapperConfigurationException](#T-AutoMapper-AutoMapperConfigurationException 'AutoMapper.AutoMapperConfigurationException') for each problem

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-IConfigurationProvider-BuildExecutionPlan-System-Type,System-Type-'></a>
### BuildExecutionPlan(sourceType,destinationType) `method`

##### Summary

Builds the execution plan used to map the source to destination.
Useful to understand what exactly is happening during mapping.
See for details.

##### Returns

the execution plan

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | the runtime type of the source object |
| destinationType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | the runtime type of the destination object |

<a name='M-AutoMapper-IConfigurationProvider-CompileMappings'></a>
### CompileMappings() `method`

##### Summary

Compile all underlying mapping expressions to cached delegates.
Use if you want AutoMapper to compile all mappings up front instead of deferring expression compilation for each first map.

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-IConfigurationProvider-CreateMapper'></a>
### CreateMapper() `method`

##### Summary

Create a mapper instance based on this configuration. Mapper instances are lightweight and can be created as needed.

##### Returns

The mapper instance

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-IConfigurationProvider-CreateMapper-System-Func{System-Type,System-Object}-'></a>
### CreateMapper(serviceCtor) `method`

##### Summary

Create a mapper instance with the specified service constructor to be used for resolvers and type converters.

##### Returns

The mapper instance

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceCtor | [System.Func{System.Type,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Type,System.Object}') | Service factory to create services |

<a name='T-AutoMapper-Configuration-ICtorParamConfigurationExpression'></a>
## ICtorParamConfigurationExpression `type`

##### Namespace

AutoMapper.Configuration

<a name='M-AutoMapper-Configuration-ICtorParamConfigurationExpression-MapFrom-System-String-'></a>
### MapFrom(sourceMembersPath) `method`

##### Summary

Specify the source member(s) to map from.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceMembersPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Property name referencing the source member to map against. Or a dot separated member path. |

<a name='T-AutoMapper-Configuration-ICtorParamConfigurationExpression`1'></a>
## ICtorParamConfigurationExpression\`1 `type`

##### Namespace

AutoMapper.Configuration

<a name='M-AutoMapper-Configuration-ICtorParamConfigurationExpression`1-MapFrom``1-System-Linq-Expressions-Expression{System-Func{`0,``0}}-'></a>
### MapFrom\`\`1(sourceMember) `method`

##### Summary

Map constructor parameter from member expression

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceMember | [System.Linq.Expressions.Expression{System.Func{\`0,\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{`0,``0}}') | Member expression |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TMember | Member type |

<a name='M-AutoMapper-Configuration-ICtorParamConfigurationExpression`1-MapFrom``1-System-Func{`0,AutoMapper-ResolutionContext,``0}-'></a>
### MapFrom\`\`1(resolver) `method`

##### Summary

Map constructor parameter from custom func that has access to [ResolutionContext](#T-AutoMapper-ResolutionContext 'AutoMapper.ResolutionContext')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resolver | [System.Func{\`0,AutoMapper.ResolutionContext,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,AutoMapper.ResolutionContext,``0}') | Custom func |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='T-mwo-SimpleDI-IDependencyContainer'></a>
## IDependencyContainer `type`

##### Namespace

mwo.SimpleDI

##### Summary

A container to register to and resolve dependencies from.

<a name='P-mwo-SimpleDI-IDependencyContainer-ParentContainer'></a>
### ParentContainer `property`

##### Summary

Containers may have a parent container that is considered when resolving.

<a name='M-mwo-SimpleDI-IDependencyContainer-IsRegistered``1'></a>
### IsRegistered\`\`1() `method`

##### Summary

Checks whether a registration is present for the given type.

##### Returns

true if the type is registered to the container or its parent.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that shall be checked. |

<a name='M-mwo-SimpleDI-IDependencyContainer-RegisterStrong``1-System-Func{mwo-SimpleDI-IDependencyContainer,``0}-'></a>
### RegisterStrong\`\`1(builder) `method`

##### Summary

Registers the builder as a generator for resolving the given type.
Overwrites existing registrations for the type.

##### Returns

The container.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [System.Func{mwo.SimpleDI.IDependencyContainer,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{mwo.SimpleDI.IDependencyContainer,``0}') | The function to be executed when the given type is resolved. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that shall be registered. |

<a name='M-mwo-SimpleDI-IDependencyContainer-RegisterWeak``1-System-Func{mwo-SimpleDI-IDependencyContainer,``0}-'></a>
### RegisterWeak\`\`1(builder) `method`

##### Summary

Registers the builder as a generator for resolving the given type.
Skips registration if the type is already present in the Registrations.

##### Returns

The container.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [System.Func{mwo.SimpleDI.IDependencyContainer,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{mwo.SimpleDI.IDependencyContainer,``0}') | The function to be executed when the given type is resolved. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that shall be registered. |

<a name='M-mwo-SimpleDI-IDependencyContainer-Register``1-System-Func{mwo-SimpleDI-IDependencyContainer,``0}-'></a>
### Register\`\`1(builder) `method`

##### Summary

Registers the builder as a generator for resolving the given type.
Throws if a builder is already registered for the type.

##### Returns

The container.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [System.Func{mwo.SimpleDI.IDependencyContainer,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{mwo.SimpleDI.IDependencyContainer,``0}') | The function to be executed when the given type is resolved. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that shall be registered. |

<a name='M-mwo-SimpleDI-IDependencyContainer-Resolve``1'></a>
### Resolve\`\`1() `method`

##### Summary

Resolves a previously registered object.

##### Returns

An object of the type T.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that shall be resolved. |

<a name='M-mwo-SimpleDI-IDependencyContainer-TryResolve``1-``0@-'></a>
### TryResolve\`\`1(obj) `method`

##### Summary

Tries to resolve an objectt of the given type.

##### Returns

true, if resolved sucessfully.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [\`\`0@](#T-``0@ '``0@') | If true is returned, contains an object of type T, otherwise obj is default. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that shall be resolved. |

<a name='T-AutoMapper-Internal-IGlobalConfiguration'></a>
## IGlobalConfiguration `type`

##### Namespace

AutoMapper.Internal

<a name='P-AutoMapper-Internal-IGlobalConfiguration-EnableNullPropagationForQueryMapping'></a>
### EnableNullPropagationForQueryMapping `property`

##### Summary

Allows to enable null-value propagation for query mapping.

<a name='P-AutoMapper-Internal-IGlobalConfiguration-Features'></a>
### Features `property`

##### Summary

Gets the features collection.

<a name='P-AutoMapper-Internal-IGlobalConfiguration-ServiceCtor'></a>
### ServiceCtor `property`

##### Summary

Factory method to create formatters, resolvers and type converters

<a name='M-AutoMapper-Internal-IGlobalConfiguration-AssertConfigurationIsValid-AutoMapper-TypeMap-'></a>
### AssertConfigurationIsValid(typeMap) `method`

##### Summary

Dry run single type map

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| typeMap | [AutoMapper.TypeMap](#T-AutoMapper-TypeMap 'AutoMapper.TypeMap') | Type map to check |

<a name='M-AutoMapper-Internal-IGlobalConfiguration-AssertConfigurationIsValid-System-String-'></a>
### AssertConfigurationIsValid(profileName) `method`

##### Summary

Dry run all type maps in given profile

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| profileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Profile name of type maps to test |

<a name='M-AutoMapper-Internal-IGlobalConfiguration-AssertConfigurationIsValid``1'></a>
### AssertConfigurationIsValid\`\`1() `method`

##### Summary

Dry run all type maps in given profile

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TProfile | Profile type |

<a name='M-AutoMapper-Internal-IGlobalConfiguration-BuildExecutionPlan-AutoMapper-Internal-MapRequest@-'></a>
### BuildExecutionPlan(mapRequest) `method`

##### Summary

Builds the execution plan used to map the source to destination.
Useful to understand what exactly is happening during mapping.
See for details.

##### Returns

the execution plan

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mapRequest | [AutoMapper.Internal.MapRequest@](#T-AutoMapper-Internal-MapRequest@ 'AutoMapper.Internal.MapRequest@') | The source/destination map request |

<a name='M-AutoMapper-Internal-IGlobalConfiguration-FindMapper-AutoMapper-Internal-TypePair@-'></a>
### FindMapper(types) `method`

##### Summary

Find a matching object mapper.

##### Returns

the matching mapper or null

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| types | [AutoMapper.Internal.TypePair@](#T-AutoMapper-Internal-TypePair@ 'AutoMapper.Internal.TypePair@') | the types to match |

<a name='M-AutoMapper-Internal-IGlobalConfiguration-FindTypeMapFor-System-Type,System-Type-'></a>
### FindTypeMapFor(sourceType,destinationType) `method`

##### Summary

Find the [TypeMap](#T-AutoMapper-TypeMap 'AutoMapper.TypeMap') for the configured source and destination type

##### Returns

Type map configuration

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Configured source type |
| destinationType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Configured destination type |

<a name='M-AutoMapper-Internal-IGlobalConfiguration-FindTypeMapFor-AutoMapper-Internal-TypePair@-'></a>
### FindTypeMapFor(typePair) `method`

##### Summary

Find the [TypeMap](#T-AutoMapper-TypeMap 'AutoMapper.TypeMap') for the configured type pair

##### Returns

Type map configuration

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| typePair | [AutoMapper.Internal.TypePair@](#T-AutoMapper-Internal-TypePair@ 'AutoMapper.Internal.TypePair@') | Type pair |

<a name='M-AutoMapper-Internal-IGlobalConfiguration-FindTypeMapFor``2'></a>
### FindTypeMapFor\`\`2() `method`

##### Summary

Find the [TypeMap](#T-AutoMapper-TypeMap 'AutoMapper.TypeMap') for the configured source and destination type

##### Returns

Type map configuration

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Source type |
| TDestination | Destination type |

<a name='M-AutoMapper-Internal-IGlobalConfiguration-GetAllTypeMaps'></a>
### GetAllTypeMaps() `method`

##### Summary

Get all configured type maps created

##### Returns

All configured type maps

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-Internal-IGlobalConfiguration-GetMappers'></a>
### GetMappers() `method`

##### Summary

Get all configured mappers

##### Returns

List of mappers

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-Internal-IGlobalConfiguration-ResolveTypeMap-System-Type,System-Type-'></a>
### ResolveTypeMap(sourceType,destinationType) `method`

##### Summary

Resolve the [TypeMap](#T-AutoMapper-TypeMap 'AutoMapper.TypeMap') for the configured source and destination type, checking parent types

##### Returns

Type map configuration

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Configured source type |
| destinationType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Configured destination type |

<a name='M-AutoMapper-Internal-IGlobalConfiguration-ResolveTypeMap-AutoMapper-Internal-TypePair@-'></a>
### ResolveTypeMap(typePair) `method`

##### Summary

Resolve the [TypeMap](#T-AutoMapper-TypeMap 'AutoMapper.TypeMap') for the configured type pair, checking parent types

##### Returns

Type map configuration

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| typePair | [AutoMapper.Internal.TypePair@](#T-AutoMapper-Internal-TypePair@ 'AutoMapper.Internal.TypePair@') | Type pair |

<a name='T-AutoMapper-Internal-IGlobalConfigurationExpression'></a>
## IGlobalConfigurationExpression `type`

##### Namespace

AutoMapper.Internal

<a name='P-AutoMapper-Internal-IGlobalConfigurationExpression-AllowAdditiveTypeMapCreation'></a>
### AllowAdditiveTypeMapCreation `property`

##### Summary

Allow the same map to exist in different profiles.
The default is to throw an exception, true means the maps are merged.

<a name='P-AutoMapper-Internal-IGlobalConfigurationExpression-Features'></a>
### Features `property`

##### Summary

Get the features collection.

<a name='P-AutoMapper-Internal-IGlobalConfigurationExpression-Mappers'></a>
### Mappers `property`

##### Summary

Object mappers

<a name='P-AutoMapper-Internal-IGlobalConfigurationExpression-MaxExecutionPlanDepth'></a>
### MaxExecutionPlanDepth `property`

##### Summary

How many levels deep should AutoMapper try to inline the execution plan for child classes.
See for details.

<a name='P-AutoMapper-Internal-IGlobalConfigurationExpression-RecursiveQueriesMaxDepth'></a>
### RecursiveQueriesMaxDepth `property`

##### Summary

How many levels deep should recursive queries be expanded.
Must be zero for EF6. Can be greater than zero for EF Core.

<a name='M-AutoMapper-Internal-IGlobalConfigurationExpression-Validator-System-Action{AutoMapper-Configuration-ValidationContext}-'></a>
### Validator(validator) `method`

##### Summary

Add an action to be called when validating the configuration.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| validator | [System.Action{AutoMapper.Configuration.ValidationContext}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.Configuration.ValidationContext}') | the validation callback |

<a name='T-AutoMapper-IMapper'></a>
## IMapper `type`

##### Namespace

AutoMapper

<a name='P-AutoMapper-IMapper-ConfigurationProvider'></a>
### ConfigurationProvider `property`

##### Summary

Configuration provider for performing maps

<a name='M-AutoMapper-IMapper-Map-System-Object,System-Type,System-Type,System-Action{AutoMapper-IMappingOperationOptions{System-Object,System-Object}}-'></a>
### Map(source,sourceType,destinationType,opts) `method`

##### Summary

Execute a mapping from the source object to a new destination object with explicit [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') objects and supplied mapping options.

##### Returns

Mapped destination object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Source object to map from |
| sourceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Source type to use |
| destinationType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Destination type to create |
| opts | [System.Action{AutoMapper.IMappingOperationOptions{System.Object,System.Object}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.IMappingOperationOptions{System.Object,System.Object}}') | Mapping options |

<a name='M-AutoMapper-IMapper-Map-System-Object,System-Object,System-Type,System-Type,System-Action{AutoMapper-IMappingOperationOptions{System-Object,System-Object}}-'></a>
### Map(source,destination,sourceType,destinationType,opts) `method`

##### Summary

Execute a mapping from the source object to existing destination object with supplied mapping options and explicit [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') objects

##### Returns

Mapped destination object, same instance as the `destination` object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Source object to map from |
| destination | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Destination object to map into |
| sourceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Source type to use |
| destinationType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Destination type to use |
| opts | [System.Action{AutoMapper.IMappingOperationOptions{System.Object,System.Object}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.IMappingOperationOptions{System.Object,System.Object}}') | Mapping options |

<a name='M-AutoMapper-IMapper-Map``1-System-Object,System-Action{AutoMapper-IMappingOperationOptions{System-Object,``0}}-'></a>
### Map\`\`1(source,opts) `method`

##### Summary

Execute a mapping from the source object to a new destination object with supplied mapping options.

##### Returns

Mapped destination object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Source object to map from |
| opts | [System.Action{AutoMapper.IMappingOperationOptions{System.Object,\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.IMappingOperationOptions{System.Object,``0}}') | Mapping options |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDestination | Destination type to create |

<a name='M-AutoMapper-IMapper-Map``2-``0,System-Action{AutoMapper-IMappingOperationOptions{``0,``1}}-'></a>
### Map\`\`2(source,opts) `method`

##### Summary

Execute a mapping from the source object to a new destination object with supplied mapping options.

##### Returns

Mapped destination object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [\`\`0](#T-``0 '``0') | Source object to map from |
| opts | [System.Action{AutoMapper.IMappingOperationOptions{\`\`0,\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.IMappingOperationOptions{``0,``1}}') | Mapping options |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Source type to use |
| TDestination | Destination type to create |

<a name='M-AutoMapper-IMapper-Map``2-``0,``1,System-Action{AutoMapper-IMappingOperationOptions{``0,``1}}-'></a>
### Map\`\`2(source,destination,opts) `method`

##### Summary

Execute a mapping from the source object to the existing destination object with supplied mapping options.

##### Returns

The mapped destination object, same instance as the `destination` object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [\`\`0](#T-``0 '``0') | Source object to map from |
| destination | [\`\`1](#T-``1 '``1') | Destination object to map into |
| opts | [System.Action{AutoMapper.IMappingOperationOptions{\`\`0,\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.IMappingOperationOptions{``0,``1}}') | Mapping options |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Source type to use |
| TDestination | Destination type |

<a name='M-AutoMapper-IMapper-ProjectTo-System-Linq-IQueryable,System-Type,System-Collections-Generic-IDictionary{System-String,System-Object},System-String[]-'></a>
### ProjectTo(source,destinationType,parameters,membersToExpand) `method`

##### Summary

Project the input queryable.

##### Returns

Queryable result, use queryable extension methods to project and execute result

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Linq.IQueryable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable') | Queryable source |
| destinationType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Destination type to map to |
| parameters | [System.Collections.Generic.IDictionary{System.String,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{System.String,System.Object}') | Optional parameter object for parameterized mapping expressions |
| membersToExpand | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Explicit members to expand |

<a name='M-AutoMapper-IMapper-ProjectTo``1-System-Linq-IQueryable,System-Object,System-Linq-Expressions-Expression{System-Func{``0,System-Object}}[]-'></a>
### ProjectTo\`\`1(source,parameters,membersToExpand) `method`

##### Summary

Project the input queryable.

##### Returns

Queryable result, use queryable extension methods to project and execute result

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Linq.IQueryable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable') | Queryable source |
| parameters | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Optional parameter object for parameterized mapping expressions |
| membersToExpand | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Object}}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,System.Object}}[]') | Explicit members to expand |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDestination | Destination type |

##### Remarks

Projections are only calculated once and cached

<a name='M-AutoMapper-IMapper-ProjectTo``1-System-Linq-IQueryable,System-Collections-Generic-IDictionary{System-String,System-Object},System-String[]-'></a>
### ProjectTo\`\`1(source,parameters,membersToExpand) `method`

##### Summary

Project the input queryable.

##### Returns

Queryable result, use queryable extension methods to project and execute result

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Linq.IQueryable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable') | Queryable source |
| parameters | [System.Collections.Generic.IDictionary{System.String,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{System.String,System.Object}') | Optional parameter object for parameterized mapping expressions |
| membersToExpand | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Explicit members to expand |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDestination | Destination type to map to |

<a name='T-AutoMapper-IMapperBase'></a>
## IMapperBase `type`

##### Namespace

AutoMapper

<a name='M-AutoMapper-IMapperBase-Map-System-Object,System-Type,System-Type-'></a>
### Map(source,sourceType,destinationType) `method`

##### Summary

Execute a mapping from the source object to a new destination object with explicit [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') objects

##### Returns

Mapped destination object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Source object to map from |
| sourceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Source type to use |
| destinationType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Destination type to create |

<a name='M-AutoMapper-IMapperBase-Map-System-Object,System-Object,System-Type,System-Type-'></a>
### Map(source,destination,sourceType,destinationType) `method`

##### Summary

Execute a mapping from the source object to existing destination object with explicit [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') objects

##### Returns

Mapped destination object, same instance as the `destination` object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Source object to map from |
| destination | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Destination object to map into |
| sourceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Source type to use |
| destinationType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Destination type to use |

<a name='M-AutoMapper-IMapperBase-Map``1-System-Object-'></a>
### Map\`\`1(source) `method`

##### Summary

Execute a mapping from the source object to a new destination object.
The source type is inferred from the source object.

##### Returns

Mapped destination object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Source object to map from |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDestination | Destination type to create |

<a name='M-AutoMapper-IMapperBase-Map``2-``0-'></a>
### Map\`\`2(source) `method`

##### Summary

Execute a mapping from the source object to a new destination object.

##### Returns

Mapped destination object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [\`\`0](#T-``0 '``0') | Source object to map from |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Source type to use, regardless of the runtime type |
| TDestination | Destination type to create |

<a name='M-AutoMapper-IMapperBase-Map``2-``0,``1-'></a>
### Map\`\`2(source,destination) `method`

##### Summary

Execute a mapping from the source object to the existing destination object.

##### Returns

The mapped destination object, same instance as the `destination` object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [\`\`0](#T-``0 '``0') | Source object to map from |
| destination | [\`\`1](#T-``1 '``1') | Destination object to map into |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Source type to use |
| TDestination | Destination type |

<a name='T-AutoMapper-IMapperConfigurationExpression'></a>
## IMapperConfigurationExpression `type`

##### Namespace

AutoMapper

<a name='M-AutoMapper-IMapperConfigurationExpression-AddMaps-System-Collections-Generic-IEnumerable{System-Reflection-Assembly}-'></a>
### AddMaps(assembliesToScan) `method`

##### Summary

Add mapping definitions contained in assemblies.
Looks for [Profile](#T-AutoMapper-Profile 'AutoMapper.Profile') definitions and classes decorated with [AutoMapAttribute](#T-AutoMapper-AutoMapAttribute 'AutoMapper.AutoMapAttribute')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| assembliesToScan | [System.Collections.Generic.IEnumerable{System.Reflection.Assembly}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Reflection.Assembly}') | Assemblies containing mapping definitions |

<a name='M-AutoMapper-IMapperConfigurationExpression-AddMaps-System-Reflection-Assembly[]-'></a>
### AddMaps(assembliesToScan) `method`

##### Summary

Add mapping definitions contained in assemblies.
Looks for [Profile](#T-AutoMapper-Profile 'AutoMapper.Profile') definitions and classes decorated with [AutoMapAttribute](#T-AutoMapper-AutoMapAttribute 'AutoMapper.AutoMapAttribute')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| assembliesToScan | [System.Reflection.Assembly[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.Assembly[] 'System.Reflection.Assembly[]') | Assemblies containing mapping definitions |

<a name='M-AutoMapper-IMapperConfigurationExpression-AddMaps-System-Collections-Generic-IEnumerable{System-String}-'></a>
### AddMaps(assemblyNamesToScan) `method`

##### Summary

Add mapping definitions contained in assemblies.
Looks for [Profile](#T-AutoMapper-Profile 'AutoMapper.Profile') definitions and classes decorated with [AutoMapAttribute](#T-AutoMapper-AutoMapAttribute 'AutoMapper.AutoMapAttribute')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| assemblyNamesToScan | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Assembly names to load and scan containing mapping definitions |

<a name='M-AutoMapper-IMapperConfigurationExpression-AddMaps-System-String[]-'></a>
### AddMaps(assemblyNamesToScan) `method`

##### Summary

Add mapping definitions contained in assemblies.
Looks for [Profile](#T-AutoMapper-Profile 'AutoMapper.Profile') definitions and classes decorated with [AutoMapAttribute](#T-AutoMapper-AutoMapAttribute 'AutoMapper.AutoMapAttribute')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| assemblyNamesToScan | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Assembly names to load and scan containing mapping definitions |

<a name='M-AutoMapper-IMapperConfigurationExpression-AddMaps-System-Collections-Generic-IEnumerable{System-Type}-'></a>
### AddMaps(typesFromAssembliesContainingMappingDefinitions) `method`

##### Summary

Add mapping definitions contained in assemblies.
Looks for [Profile](#T-AutoMapper-Profile 'AutoMapper.Profile') definitions and classes decorated with [AutoMapAttribute](#T-AutoMapper-AutoMapAttribute 'AutoMapper.AutoMapAttribute')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| typesFromAssembliesContainingMappingDefinitions | [System.Collections.Generic.IEnumerable{System.Type}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Type}') | Types from assemblies containing mapping definitions |

<a name='M-AutoMapper-IMapperConfigurationExpression-AddMaps-System-Type[]-'></a>
### AddMaps(typesFromAssembliesContainingMappingDefinitions) `method`

##### Summary

Add mapping definitions contained in assemblies.
Looks for [Profile](#T-AutoMapper-Profile 'AutoMapper.Profile') definitions and classes decorated with [AutoMapAttribute](#T-AutoMapper-AutoMapAttribute 'AutoMapper.AutoMapAttribute')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| typesFromAssembliesContainingMappingDefinitions | [System.Type[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type[] 'System.Type[]') | Types from assemblies containing mapping definitions |

<a name='M-AutoMapper-IMapperConfigurationExpression-AddProfile-AutoMapper-Profile-'></a>
### AddProfile(profile) `method`

##### Summary

Add an existing profile

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| profile | [AutoMapper.Profile](#T-AutoMapper-Profile 'AutoMapper.Profile') | Profile to add |

<a name='M-AutoMapper-IMapperConfigurationExpression-AddProfile-System-Type-'></a>
### AddProfile(profileType) `method`

##### Summary

Add an existing profile type. Profile will be instantiated and added to the configuration.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| profileType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Profile type |

<a name='M-AutoMapper-IMapperConfigurationExpression-AddProfile``1'></a>
### AddProfile\`\`1() `method`

##### Summary

Add an existing profile type. Profile will be instantiated and added to the configuration.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TProfile | Profile type |

<a name='M-AutoMapper-IMapperConfigurationExpression-AddProfiles-System-Collections-Generic-IEnumerable{AutoMapper-Profile}-'></a>
### AddProfiles(enumerableOfProfiles) `method`

##### Summary

Add profiles contained in an IEnumerable

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerableOfProfiles | [System.Collections.Generic.IEnumerable{AutoMapper.Profile}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AutoMapper.Profile}') | IEnumerable of Profile |

<a name='M-AutoMapper-IMapperConfigurationExpression-ConstructServicesUsing-System-Func{System-Type,System-Object}-'></a>
### ConstructServicesUsing(constructor) `method`

##### Summary

Supply a factory method callback for creating resolvers and type converters

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| constructor | [System.Func{System.Type,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Type,System.Object}') | Factory method |

<a name='M-AutoMapper-IMapperConfigurationExpression-CreateProfile-System-String,System-Action{AutoMapper-IProfileExpression}-'></a>
### CreateProfile(profileName,config) `method`

##### Summary

Create a named profile with the supplied configuration

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| profileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Profile name, must be unique |
| config | [System.Action{AutoMapper.IProfileExpression}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.IProfileExpression}') | Profile configuration |

<a name='T-AutoMapper-IMappingAction`2'></a>
## IMappingAction\`2 `type`

##### Namespace

AutoMapper

##### Summary

Custom mapping action

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Source type |
| TDestination | Destination type |

<a name='M-AutoMapper-IMappingAction`2-Process-`0,`1,AutoMapper-ResolutionContext-'></a>
### Process(source,destination,context) `method`

##### Summary

Implementors can modify both the source and destination objects

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [\`0](#T-`0 '`0') | Source object |
| destination | [\`1](#T-`1 '`1') | Destination object |
| context | [AutoMapper.ResolutionContext](#T-AutoMapper-ResolutionContext 'AutoMapper.ResolutionContext') | Resolution context |

<a name='T-AutoMapper-IMappingExpression'></a>
## IMappingExpression `type`

##### Namespace

AutoMapper

##### Summary

Mapping configuration options for non-generic maps

<a name='M-AutoMapper-IMappingExpression-ForAllMembers-System-Action{AutoMapper-IMemberConfigurationExpression}-'></a>
### ForAllMembers(memberOptions) `method`

##### Summary

Customize configuration for all members

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| memberOptions | [System.Action{AutoMapper.IMemberConfigurationExpression}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.IMemberConfigurationExpression}') | Callback for member options |

<a name='M-AutoMapper-IMappingExpression-ForMember-System-String,System-Action{AutoMapper-IMemberConfigurationExpression}-'></a>
### ForMember(name,memberOptions) `method`

##### Summary

Customize individual members

##### Returns

Itself

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the member |
| memberOptions | [System.Action{AutoMapper.IMemberConfigurationExpression}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.IMemberConfigurationExpression}') | Callback for configuring member |

<a name='M-AutoMapper-IMappingExpression-IncludeMembers-System-String[]-'></a>
### IncludeMembers(memberNames) `method`

##### Summary

Add extra configuration to the current map by also mapping the specified child objects to the destination object.
The maps from the child types to the destination need to be created explicitly.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| memberNames | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | the names of child object properties to map to the destination |

<a name='M-AutoMapper-IMappingExpression-ReverseMap'></a>
### ReverseMap() `method`

##### Summary

Create a type mapping from the destination to the source type, with validation disabled.
This allows for two-way mapping.

##### Returns

Itself

##### Parameters

This method has no parameters.

<a name='T-AutoMapper-IMappingExpressionBase`3'></a>
## IMappingExpressionBase\`3 `type`

##### Namespace

AutoMapper

##### Summary

Common mapping configuration options between generic and non-generic mapping configuration

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Source type |
| TDestination | Destination type |
| TMappingExpression | Concrete return type for fluent interface |

<a name='M-AutoMapper-IMappingExpressionBase`3-AfterMap-System-Action{`0,`1}-'></a>
### AfterMap(afterFunction) `method`

##### Summary

Execute a custom function to the source and/or destination types after member mapping

##### Returns

Itself

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| afterFunction | [System.Action{\`0,\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{`0,`1}') | Callback for the source/destination types |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMappingExpressionBase`3-AfterMap-System-Action{`0,`1,AutoMapper-ResolutionContext}-'></a>
### AfterMap(afterFunction) `method`

##### Summary

Execute a custom function to the source and/or destination types after member mapping

##### Returns

Itself

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| afterFunction | [System.Action{\`0,\`1,AutoMapper.ResolutionContext}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{`0,`1,AutoMapper.ResolutionContext}') | Callback for the source/destination types |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMappingExpressionBase`3-AfterMap``1'></a>
### AfterMap\`\`1() `method`

##### Summary

Execute a custom mapping action after member mapping

##### Returns

Itself

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TMappingAction | Mapping action type instantiated during mapping |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMappingExpressionBase`3-As-System-Type-'></a>
### As(typeOverride) `method`

##### Summary

Override the destination type mapping for looking up configuration and instantiation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| typeOverride | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-AutoMapper-IMappingExpressionBase`3-AsProxy'></a>
### AsProxy() `method`

##### Summary

Create at runtime a proxy type implementing the destination interface.

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-IMappingExpressionBase`3-BeforeMap-System-Action{`0,`1}-'></a>
### BeforeMap(beforeFunction) `method`

##### Summary

Execute a custom function to the source and/or destination types before member mapping

##### Returns

Itself

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| beforeFunction | [System.Action{\`0,\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{`0,`1}') | Callback for the source/destination types |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMappingExpressionBase`3-BeforeMap-System-Action{`0,`1,AutoMapper-ResolutionContext}-'></a>
### BeforeMap(beforeFunction) `method`

##### Summary

Execute a custom function to the source and/or destination types before member mapping

##### Returns

Itself

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| beforeFunction | [System.Action{\`0,\`1,AutoMapper.ResolutionContext}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{`0,`1,AutoMapper.ResolutionContext}') | Callback for the source/destination types |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMappingExpressionBase`3-BeforeMap``1'></a>
### BeforeMap\`\`1() `method`

##### Summary

Execute a custom mapping action before member mapping

##### Returns

Itself

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TMappingAction | Mapping action type instantiated during mapping |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMappingExpressionBase`3-ConstructUsing-System-Func{`0,AutoMapper-ResolutionContext,`1}-'></a>
### ConstructUsing(ctor) `method`

##### Summary

Supply a custom instantiation function for the destination type, based on the entire resolution context

##### Returns

Itself

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ctor | [System.Func{\`0,AutoMapper.ResolutionContext,\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,AutoMapper.ResolutionContext,`1}') | Callback to create the destination type given the current resolution context |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMappingExpressionBase`3-ConstructUsingServiceLocator'></a>
### ConstructUsingServiceLocator() `method`

##### Summary

Construct the destination object using the service locator

##### Returns

Itself

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-IMappingExpressionBase`3-ConvertUsing-System-Type-'></a>
### ConvertUsing(typeConverterType) `method`

##### Summary

Skip normal member mapping and convert using a [ITypeConverter\`2](#T-AutoMapper-ITypeConverter`2 'AutoMapper.ITypeConverter`2') instantiated during mapping
Use this method if you need to specify the converter type at runtime

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| typeConverterType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Type converter type |

<a name='M-AutoMapper-IMappingExpressionBase`3-ConvertUsing-System-Func{`0,`1,`1}-'></a>
### ConvertUsing(mappingFunction) `method`

##### Summary

Skip member mapping and use a custom function to convert to the destination type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mappingFunction | [System.Func{\`0,\`1,\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1,`1}') | Callback to convert from source type to destination type, including destination object |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMappingExpressionBase`3-ConvertUsing-System-Func{`0,`1,AutoMapper-ResolutionContext,`1}-'></a>
### ConvertUsing(mappingFunction) `method`

##### Summary

Skip member mapping and use a custom function to convert to the destination type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mappingFunction | [System.Func{\`0,\`1,AutoMapper.ResolutionContext,\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1,AutoMapper.ResolutionContext,`1}') | Callback to convert from source type to destination type, with source, destination and context |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMappingExpressionBase`3-ConvertUsing-AutoMapper-ITypeConverter{`0,`1}-'></a>
### ConvertUsing(converter) `method`

##### Summary

Skip member mapping and use a custom type converter instance to convert to the destination type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| converter | [AutoMapper.ITypeConverter{\`0,\`1}](#T-AutoMapper-ITypeConverter{`0,`1} 'AutoMapper.ITypeConverter{`0,`1}') | Type converter instance |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMappingExpressionBase`3-ConvertUsing``1'></a>
### ConvertUsing\`\`1() `method`

##### Summary

Skip member mapping and use a custom type converter instance to convert to the destination type

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TTypeConverter | Type converter type |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMappingExpressionBase`3-DisableCtorValidation'></a>
### DisableCtorValidation() `method`

##### Summary

Disable constructor validation. During mapping this map is used against an existing destination object and never constructed itself.

##### Returns

Itself

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-IMappingExpressionBase`3-ForSourceMember-System-String,System-Action{AutoMapper-Configuration-ISourceMemberConfigurationExpression}-'></a>
### ForSourceMember(sourceMemberName,memberOptions) `method`

##### Summary

Customize configuration for an individual source member. Member name not known until runtime

##### Returns

Itself

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceMemberName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Expression to source member. Must be a member of the `TSource` type |
| memberOptions | [System.Action{AutoMapper.Configuration.ISourceMemberConfigurationExpression}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.Configuration.ISourceMemberConfigurationExpression}') | Callback for member configuration options |

<a name='M-AutoMapper-IMappingExpressionBase`3-IgnoreAllPropertiesWithAnInaccessibleSetter'></a>
### IgnoreAllPropertiesWithAnInaccessibleSetter() `method`

##### Summary

Ignores all `TDestination` properties that have either a private or protected setter, forcing the mapper to respect encapsulation (note: order matters, so place this before explicit configuration of any properties with an inaccessible setter)

##### Returns

Itself

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-IMappingExpressionBase`3-IgnoreAllSourcePropertiesWithAnInaccessibleSetter'></a>
### IgnoreAllSourcePropertiesWithAnInaccessibleSetter() `method`

##### Summary

When using ReverseMap, ignores all `TSource` properties that have either a private or protected setter, keeping the reverse mapping consistent with the forward mapping (note: `TDestination` properties with an inaccessible setter may still be mapped unless IgnoreAllPropertiesWithAnInaccessibleSetter is also used)

##### Returns

Itself

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-IMappingExpressionBase`3-Include-System-Type,System-Type-'></a>
### Include(derivedSourceType,derivedDestinationType) `method`

##### Summary

Include this configuration in derived types' maps

##### Returns

Itself

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| derivedSourceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Derived source type |
| derivedDestinationType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Derived destination type |

<a name='M-AutoMapper-IMappingExpressionBase`3-IncludeAllDerived'></a>
### IncludeAllDerived() `method`

##### Summary

Include this configuration in all derived types' maps. Works by scanning all type maps for matches during configuration.

##### Returns

Itself

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-IMappingExpressionBase`3-IncludeBase-System-Type,System-Type-'></a>
### IncludeBase(sourceBase,destinationBase) `method`

##### Summary

Include the base type map's configuration in this map

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceBase | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Base source type |
| destinationBase | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Base destination type |

<a name='M-AutoMapper-IMappingExpressionBase`3-PreserveReferences'></a>
### PreserveReferences() `method`

##### Summary

Preserve object identity. Useful for circular references.

##### Returns

Itself

##### Parameters

This method has no parameters.

<a name='T-AutoMapper-IMappingExpression`2'></a>
## IMappingExpression\`2 `type`

##### Namespace

AutoMapper

##### Summary

Mapping configuration options

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Source type |
| TDestination | Destination type |

<a name='M-AutoMapper-IMappingExpression`2-As``1'></a>
### As\`\`1() `method`

##### Summary

Override the destination type mapping for looking up configuration and instantiation

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Destination type to use |

<a name='M-AutoMapper-IMappingExpression`2-ForAllMembers-System-Action{AutoMapper-IMemberConfigurationExpression{`0,`1,System-Object}}-'></a>
### ForAllMembers(memberOptions) `method`

##### Summary

Customize configuration for all members

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| memberOptions | [System.Action{AutoMapper.IMemberConfigurationExpression{\`0,\`1,System.Object}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.IMemberConfigurationExpression{`0,`1,System.Object}}') | Callback for member options |

<a name='M-AutoMapper-IMappingExpression`2-ForMember-System-String,System-Action{AutoMapper-IMemberConfigurationExpression{`0,`1,System-Object}}-'></a>
### ForMember(name,memberOptions) `method`

##### Summary

Customize configuration for individual member. Used when the name isn't known at compile-time

##### Returns

Itself

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Destination member name |
| memberOptions | [System.Action{AutoMapper.IMemberConfigurationExpression{\`0,\`1,System.Object}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.IMemberConfigurationExpression{`0,`1,System.Object}}') | Callback for member options |

<a name='M-AutoMapper-IMappingExpression`2-ForMember``1-System-Linq-Expressions-Expression{System-Func{`1,``0}},System-Action{AutoMapper-IMemberConfigurationExpression{`0,`1,``0}}-'></a>
### ForMember\`\`1(destinationMember,memberOptions) `method`

##### Summary

Customize configuration for individual member

##### Returns

Itself

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| destinationMember | [System.Linq.Expressions.Expression{System.Func{\`1,\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{`1,``0}}') | Expression to the top-level destination member. This must be a member on the `TDestination`TDestination |
| memberOptions | [System.Action{AutoMapper.IMemberConfigurationExpression{\`0,\`1,\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.IMemberConfigurationExpression{`0,`1,``0}}') | Callback for member options |

<a name='M-AutoMapper-IMappingExpression`2-ForPath``1-System-Linq-Expressions-Expression{System-Func{`1,``0}},System-Action{AutoMapper-Configuration-IPathConfigurationExpression{`0,`1,``0}}-'></a>
### ForPath\`\`1(destinationMember,memberOptions) `method`

##### Summary

Customize configuration for a path inside the destination object.

##### Returns

Itself

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| destinationMember | [System.Linq.Expressions.Expression{System.Func{\`1,\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{`1,``0}}') | Expression to the destination sub object |
| memberOptions | [System.Action{AutoMapper.Configuration.IPathConfigurationExpression{\`0,\`1,\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.Configuration.IPathConfigurationExpression{`0,`1,``0}}') | Callback for member options |

<a name='M-AutoMapper-IMappingExpression`2-ForSourceMember-System-Linq-Expressions-Expression{System-Func{`0,System-Object}},System-Action{AutoMapper-Configuration-ISourceMemberConfigurationExpression}-'></a>
### ForSourceMember(sourceMember,memberOptions) `method`

##### Summary

Customize configuration for an individual source member

##### Returns

Itself

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceMember | [System.Linq.Expressions.Expression{System.Func{\`0,System.Object}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{`0,System.Object}}') | Expression to source member. Must be a member of the `TSource` type |
| memberOptions | [System.Action{AutoMapper.Configuration.ISourceMemberConfigurationExpression}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.Configuration.ISourceMemberConfigurationExpression}') | Callback for member configuration options |

<a name='M-AutoMapper-IMappingExpression`2-IncludeBase``2'></a>
### IncludeBase\`\`2() `method`

##### Summary

Include the base type map's configuration in this map

##### Returns

Itself

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSourceBase | Base source type |
| TDestinationBase | Base destination type |

<a name='M-AutoMapper-IMappingExpression`2-Include``2'></a>
### Include\`\`2() `method`

##### Summary

Include this configuration in derived types' maps

##### Returns

Itself

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOtherSource | Derived source type |
| TOtherDestination | Derived destination type |

<a name='M-AutoMapper-IMappingExpression`2-ReverseMap'></a>
### ReverseMap() `method`

##### Summary

Create a type mapping from the destination to the source type, with validation disabled.
This allows for two-way mapping.

##### Returns

Itself

##### Parameters

This method has no parameters.

<a name='T-AutoMapper-IMappingOperationOptions'></a>
## IMappingOperationOptions `type`

##### Namespace

AutoMapper

##### Summary

Options for a single map operation

<a name='P-AutoMapper-IMappingOperationOptions-Items'></a>
### Items `property`

##### Summary

Add context items to be accessed at map time inside an [IValueResolver\`3](#T-AutoMapper-IValueResolver`3 'AutoMapper.IValueResolver`3') or [ITypeConverter\`2](#T-AutoMapper-ITypeConverter`2 'AutoMapper.ITypeConverter`2')

<a name='M-AutoMapper-IMappingOperationOptions-AfterMap-System-Action{System-Object,System-Object}-'></a>
### AfterMap(afterFunction) `method`

##### Summary

Execute a custom function to the source and/or destination types after member mapping

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| afterFunction | [System.Action{System.Object,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Object,System.Object}') | Callback for the source/destination types |

<a name='M-AutoMapper-IMappingOperationOptions-BeforeMap-System-Action{System-Object,System-Object}-'></a>
### BeforeMap(beforeFunction) `method`

##### Summary

Execute a custom function to the source and/or destination types before member mapping

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| beforeFunction | [System.Action{System.Object,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Object,System.Object}') | Callback for the source/destination types |

<a name='M-AutoMapper-IMappingOperationOptions-ConstructServicesUsing-System-Func{System-Type,System-Object}-'></a>
### ConstructServicesUsing(constructor) `method`

##### Summary

Construct services using this callback. Use this for child/nested containers

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| constructor | [System.Func{System.Type,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Type,System.Object}') |  |

<a name='T-AutoMapper-IMappingOperationOptions`2'></a>
## IMappingOperationOptions\`2 `type`

##### Namespace

AutoMapper

<a name='M-AutoMapper-IMappingOperationOptions`2-AfterMap-System-Action{`0,`1}-'></a>
### AfterMap(afterFunction) `method`

##### Summary

Execute a custom function to the source and/or destination types after member mapping

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| afterFunction | [System.Action{\`0,\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{`0,`1}') | Callback for the source/destination types |

<a name='M-AutoMapper-IMappingOperationOptions`2-BeforeMap-System-Action{`0,`1}-'></a>
### BeforeMap(beforeFunction) `method`

##### Summary

Execute a custom function to the source and/or destination types before member mapping

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| beforeFunction | [System.Action{\`0,\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{`0,`1}') | Callback for the source/destination types |

<a name='T-AutoMapper-IMemberConfigurationExpression'></a>
## IMemberConfigurationExpression `type`

##### Namespace

AutoMapper

##### Summary

Configuration options for an individual member

<a name='M-AutoMapper-IMemberConfigurationExpression-ConvertUsing-System-Type-'></a>
### ConvertUsing(valueConverterType) `method`

##### Summary

Specify a value converter type to convert from the matching source member to the destination member

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| valueConverterType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Value converter type |

##### Remarks

Value converters are similar to type converters, but scoped to a single member. Value resolvers receive the enclosed source/destination objects as parameters.
Value converters do not. This makes it possible to reuse value converters across multiple members and multiple maps.

<a name='M-AutoMapper-IMemberConfigurationExpression-ConvertUsing-System-Type,System-String-'></a>
### ConvertUsing(valueConverterType,sourceMemberName) `method`

##### Summary

Specify a value converter type to convert from the specified source member name to the destination member

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| valueConverterType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Value converter type |
| sourceMemberName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Source member name to supply to the value converter |

##### Remarks

Value converters are similar to type converters, but scoped to a single member. Value resolvers receive the enclosed source/destination objects as parameters.
Value converters do not. This makes it possible to reuse value converters across multiple members and multiple maps.

<a name='M-AutoMapper-IMemberConfigurationExpression-ConvertUsing``2-AutoMapper-IValueConverter{``0,``1},System-String-'></a>
### ConvertUsing\`\`2(valueConverter,sourceMemberName) `method`

##### Summary

Specify a value converter instance to convert from the specified source member name to the destination member

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| valueConverter | [AutoMapper.IValueConverter{\`\`0,\`\`1}](#T-AutoMapper-IValueConverter{``0,``1} 'AutoMapper.IValueConverter{``0,``1}') | Value converter instance |
| sourceMemberName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Source member name to supply to the value converter |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSourceMember | Source member type |
| TDestinationMember | Destination member type |

##### Remarks

Value converters are similar to type converters, but scoped to a single member. Value resolvers receive the enclosed source/destination objects as parameters.
Value converters do not. This makes it possible to reuse value converters across multiple members and multiple maps.

<a name='M-AutoMapper-IMemberConfigurationExpression-MapFrom-System-Type-'></a>
### MapFrom(valueResolverType) `method`

##### Summary

Map destination member using a custom value resolver. Used when the value resolver is not known at compile-time

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| valueResolverType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Value resolver type |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMemberConfigurationExpression-MapFrom-System-Type,System-String-'></a>
### MapFrom(valueResolverType,sourceMemberName) `method`

##### Summary

Map destination member using a custom value resolver. Used when the value resolver is not known at compile-time

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| valueResolverType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Value resolver type |
| sourceMemberName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Member to supply to value resolver |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMemberConfigurationExpression-MapFrom``4-AutoMapper-IMemberValueResolver{``0,``1,``2,``3},System-String-'></a>
### MapFrom\`\`4(valueResolver,sourceMemberName) `method`

##### Summary

Map destination member using a custom value resolver instance

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| valueResolver | [AutoMapper.IMemberValueResolver{\`\`0,\`\`1,\`\`2,\`\`3}](#T-AutoMapper-IMemberValueResolver{``0,``1,``2,``3} 'AutoMapper.IMemberValueResolver{``0,``1,``2,``3}') | Value resolver instance to use |
| sourceMemberName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Source member to supply to value resolver |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='T-AutoMapper-IMemberConfigurationExpression`3'></a>
## IMemberConfigurationExpression\`3 `type`

##### Namespace

AutoMapper

##### Summary

Member configuration options

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Source type for this member |
| TMember | Type for this member |
| TDestination | Destination type for this map |

<a name='P-AutoMapper-IMemberConfigurationExpression`3-DestinationMember'></a>
### DestinationMember `property`

##### Summary

The destination member being configured.

<a name='M-AutoMapper-IMemberConfigurationExpression`3-Condition-System-Func{`0,`1,`2,`2,AutoMapper-ResolutionContext,System-Boolean}-'></a>
### Condition(condition) `method`

##### Summary

Conditionally map this member against the source, destination, source and destination members

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Func{\`0,\`1,\`2,\`2,AutoMapper.ResolutionContext,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1,`2,`2,AutoMapper.ResolutionContext,System.Boolean}') | Condition to evaluate using the source object |

<a name='M-AutoMapper-IMemberConfigurationExpression`3-Condition-System-Func{`0,`1,`2,`2,System-Boolean}-'></a>
### Condition(condition) `method`

##### Summary

Conditionally map this member

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Func{\`0,\`1,\`2,\`2,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1,`2,`2,System.Boolean}') | Condition to evaluate using the source object |

<a name='M-AutoMapper-IMemberConfigurationExpression`3-Condition-System-Func{`0,`1,`2,System-Boolean}-'></a>
### Condition(condition) `method`

##### Summary

Conditionally map this member

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Func{\`0,\`1,\`2,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1,`2,System.Boolean}') | Condition to evaluate using the source object |

<a name='M-AutoMapper-IMemberConfigurationExpression`3-Condition-System-Func{`0,`1,System-Boolean}-'></a>
### Condition(condition) `method`

##### Summary

Conditionally map this member

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Func{\`0,\`1,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1,System.Boolean}') | Condition to evaluate using the source object |

<a name='M-AutoMapper-IMemberConfigurationExpression`3-Condition-System-Func{`0,System-Boolean}-'></a>
### Condition(condition) `method`

##### Summary

Conditionally map this member

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Func{\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,System.Boolean}') | Condition to evaluate using the source object |

<a name='M-AutoMapper-IMemberConfigurationExpression`3-ConvertUsing``1-AutoMapper-IValueConverter{``0,`2}-'></a>
### ConvertUsing\`\`1(valueConverter) `method`

##### Summary

Specify a value converter instance to convert from the matching source member to the destination member

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| valueConverter | [AutoMapper.IValueConverter{\`\`0,\`2}](#T-AutoMapper-IValueConverter{``0,`2} 'AutoMapper.IValueConverter{``0,`2}') | Value converter instance |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSourceMember | Source member type |

##### Remarks

Value converters are similar to type converters, but scoped to a single member. Value resolvers receive the enclosed source/destination objects as parameters.
Value converters do not. This makes it possible to reuse value converters across multiple members and multiple maps.

<a name='M-AutoMapper-IMemberConfigurationExpression`3-ConvertUsing``1-AutoMapper-IValueConverter{``0,`2},System-Linq-Expressions-Expression{System-Func{`0,``0}}-'></a>
### ConvertUsing\`\`1(valueConverter,sourceMember) `method`

##### Summary

Specify a value converter instance from the specified source member to the destination member

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| valueConverter | [AutoMapper.IValueConverter{\`\`0,\`2}](#T-AutoMapper-IValueConverter{``0,`2} 'AutoMapper.IValueConverter{``0,`2}') | Value converter instance |
| sourceMember | [System.Linq.Expressions.Expression{System.Func{\`0,\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{`0,``0}}') | Source member to supply to the value converter |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSourceMember | Source member type |

##### Remarks

Value converters are similar to type converters, but scoped to a single member. Value resolvers receive the enclosed source/destination objects as parameters.
Value converters do not. This makes it possible to reuse value converters across multiple members and multiple maps.

<a name='M-AutoMapper-IMemberConfigurationExpression`3-ConvertUsing``1-AutoMapper-IValueConverter{``0,`2},System-String-'></a>
### ConvertUsing\`\`1(valueConverter,sourceMemberName) `method`

##### Summary

Specify a value converter instance to convert from the specified source member name to the destination member

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| valueConverter | [AutoMapper.IValueConverter{\`\`0,\`2}](#T-AutoMapper-IValueConverter{``0,`2} 'AutoMapper.IValueConverter{``0,`2}') | Value converter instance |
| sourceMemberName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Source member name to supply to the value converter |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSourceMember | Source member type |

##### Remarks

Value converters are similar to type converters, but scoped to a single member. Value resolvers receive the enclosed source/destination objects as parameters.
Value converters do not. This makes it possible to reuse value converters across multiple members and multiple maps.

<a name='M-AutoMapper-IMemberConfigurationExpression`3-ConvertUsing``2'></a>
### ConvertUsing\`\`2() `method`

##### Summary

Specify a value converter to convert from the matching source member to the destination member

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValueConverter | Value converter type |
| TSourceMember | Source member type |

##### Remarks

Value converters are similar to type converters, but scoped to a single member. Value resolvers receive the enclosed source/destination objects as parameters.
Value converters do not. This makes it possible to reuse value converters across multiple members and multiple maps.

<a name='M-AutoMapper-IMemberConfigurationExpression`3-ConvertUsing``2-System-Linq-Expressions-Expression{System-Func{`0,``1}}-'></a>
### ConvertUsing\`\`2(sourceMember) `method`

##### Summary

Specify a value converter to convert from the specified source member to the destination member

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceMember | [System.Linq.Expressions.Expression{System.Func{\`0,\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{`0,``1}}') | Source member to supply to the value converter |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValueConverter | Value converter type |
| TSourceMember | Source member type |

##### Remarks

Value converters are similar to type converters, but scoped to a single member. Value resolvers receive the enclosed source/destination objects as parameters.
Value converters do not. This makes it possible to reuse value converters across multiple members and multiple maps.

<a name='M-AutoMapper-IMemberConfigurationExpression`3-ConvertUsing``2-System-String-'></a>
### ConvertUsing\`\`2(sourceMemberName) `method`

##### Summary

Specify a value converter to convert from the specified source member name to the destination member

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceMemberName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Source member name to supply to the value converter |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValueConverter | Value converter type |
| TSourceMember | Source member type |

##### Remarks

Value converters are similar to type converters, but scoped to a single member. Value resolvers receive the enclosed source/destination objects as parameters.
Value converters do not. This makes it possible to reuse value converters across multiple members and multiple maps.

<a name='M-AutoMapper-IMemberConfigurationExpression`3-DoNotUseDestinationValue'></a>
### DoNotUseDestinationValue() `method`

##### Summary

Reset UseDestinationValue.

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-IMemberConfigurationExpression`3-MapAtRuntime'></a>
### MapAtRuntime() `method`

##### Summary

Do not precompute the execution plan for this member, just map it at runtime.
Simplifies the execution plan by not inlining.

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-IMemberConfigurationExpression`3-MapFrom-AutoMapper-IValueResolver{`0,`1,`2}-'></a>
### MapFrom(valueResolver) `method`

##### Summary

Map destination member using a custom value resolver instance

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| valueResolver | [AutoMapper.IValueResolver{\`0,\`1,\`2}](#T-AutoMapper-IValueResolver{`0,`1,`2} 'AutoMapper.IValueResolver{`0,`1,`2}') | Value resolver instance to use |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMemberConfigurationExpression`3-MapFrom-System-String-'></a>
### MapFrom(sourceMembersPath) `method`

##### Summary

Specify the source member(s) to map from.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceMembersPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Property name referencing the source member to map against. Or a dot separated member path. |

<a name='M-AutoMapper-IMemberConfigurationExpression`3-MapFrom``1'></a>
### MapFrom\`\`1() `method`

##### Summary

Map destination member using a custom value resolver

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValueResolver | Value resolver type |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMemberConfigurationExpression`3-MapFrom``1-AutoMapper-IMemberValueResolver{`0,`1,``0,`2},System-Linq-Expressions-Expression{System-Func{`0,``0}}-'></a>
### MapFrom\`\`1(valueResolver,sourceMember) `method`

##### Summary

Map destination member using a custom value resolver instance

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| valueResolver | [AutoMapper.IMemberValueResolver{\`0,\`1,\`\`0,\`2}](#T-AutoMapper-IMemberValueResolver{`0,`1,``0,`2} 'AutoMapper.IMemberValueResolver{`0,`1,``0,`2}') | Value resolver instance to use |
| sourceMember | [System.Linq.Expressions.Expression{System.Func{\`0,\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{`0,``0}}') | Source member to supply to value resolver |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMemberConfigurationExpression`3-MapFrom``1-System-Func{`0,`1,``0}-'></a>
### MapFrom\`\`1(mappingFunction) `method`

##### Summary

Map destination member using a custom function. Access both the source and destination object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mappingFunction | [System.Func{\`0,\`1,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1,``0}') | Function to map to destination member |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMemberConfigurationExpression`3-MapFrom``1-System-Func{`0,`1,`2,``0}-'></a>
### MapFrom\`\`1(mappingFunction) `method`

##### Summary

Map destination member using a custom function. Access the source, destination object, and destination member.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mappingFunction | [System.Func{\`0,\`1,\`2,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1,`2,``0}') | Function to map to destination member |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMemberConfigurationExpression`3-MapFrom``1-System-Func{`0,`1,`2,AutoMapper-ResolutionContext,``0}-'></a>
### MapFrom\`\`1(mappingFunction) `method`

##### Summary

Map destination member using a custom function. Access the source, destination object, destination member, and context.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mappingFunction | [System.Func{\`0,\`1,\`2,AutoMapper.ResolutionContext,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1,`2,AutoMapper.ResolutionContext,``0}') | Function to map to destination member |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMemberConfigurationExpression`3-MapFrom``2-System-Linq-Expressions-Expression{System-Func{`0,``1}}-'></a>
### MapFrom\`\`2() `method`

##### Summary

Map destination member using a custom member value resolver supplied with a source member

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValueResolver | Value resolver type |
| TSourceMember | Source member to supply |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMemberConfigurationExpression`3-MapFrom``2-System-String-'></a>
### MapFrom\`\`2(sourceMemberName) `method`

##### Summary

Map destination member using a custom member value resolver supplied from a source member name

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceMemberName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Source member name |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValueResolver | Value resolver type |
| TSourceMember | Source member to supply |

##### Remarks

Not used for LINQ projection (ProjectTo)

<a name='M-AutoMapper-IMemberConfigurationExpression`3-PreCondition-System-Func{`0,System-Boolean}-'></a>
### PreCondition(condition) `method`

##### Summary

Conditionally map this member, evaluated before accessing the source value

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Func{\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,System.Boolean}') | Condition to evaluate using the source object |

<a name='M-AutoMapper-IMemberConfigurationExpression`3-PreCondition-System-Func{AutoMapper-ResolutionContext,System-Boolean}-'></a>
### PreCondition(condition) `method`

##### Summary

Conditionally map this member, evaluated before accessing the source value

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Func{AutoMapper.ResolutionContext,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{AutoMapper.ResolutionContext,System.Boolean}') | Condition to evaluate using the current resolution context |

<a name='M-AutoMapper-IMemberConfigurationExpression`3-PreCondition-System-Func{`0,AutoMapper-ResolutionContext,System-Boolean}-'></a>
### PreCondition(condition) `method`

##### Summary

Conditionally map this member, evaluated before accessing the source value

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Func{\`0,AutoMapper.ResolutionContext,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,AutoMapper.ResolutionContext,System.Boolean}') | Condition to evaluate using the source object and the current resolution context |

<a name='M-AutoMapper-IMemberConfigurationExpression`3-PreCondition-System-Func{`0,`1,AutoMapper-ResolutionContext,System-Boolean}-'></a>
### PreCondition(condition) `method`

##### Summary

Conditionally map this member, evaluated before accessing the source value

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Func{\`0,\`1,AutoMapper.ResolutionContext,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1,AutoMapper.ResolutionContext,System.Boolean}') | Condition to evaluate using the source object, the destination object, and the current resolution context |

<a name='M-AutoMapper-IMemberConfigurationExpression`3-SetMappingOrder-System-Int32-'></a>
### SetMappingOrder(mappingOrder) `method`

##### Summary

Supply a custom mapping order instead of what the .NET runtime returns

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mappingOrder | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Mapping order value |

<a name='M-AutoMapper-IMemberConfigurationExpression`3-UseDestinationValue'></a>
### UseDestinationValue() `method`

##### Summary

Use the destination value instead of mapping from the source value or creating a new instance

##### Parameters

This method has no parameters.

<a name='T-AutoMapper-IMemberValueResolver`4'></a>
## IMemberValueResolver\`4 `type`

##### Namespace

AutoMapper

##### Summary

Extension point to provide custom resolution for a destination value

<a name='M-AutoMapper-IMemberValueResolver`4-Resolve-`0,`1,`2,`3,AutoMapper-ResolutionContext-'></a>
### Resolve(source,destination,sourceMember,destMember,context) `method`

##### Summary

Implementors use source object to provide a destination object.

##### Returns

Result, typically build from the source resolution result

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [\`0](#T-`0 '`0') | Source object |
| destination | [\`1](#T-`1 '`1') | Destination object, if exists |
| sourceMember | [\`2](#T-`2 '`2') | Source member |
| destMember | [\`3](#T-`3 '`3') | Destination member |
| context | [AutoMapper.ResolutionContext](#T-AutoMapper-ResolutionContext 'AutoMapper.ResolutionContext') | The context of the mapping |

<a name='T-AutoMapper-INamingConvention'></a>
## INamingConvention `type`

##### Namespace

AutoMapper

##### Summary

Defines a naming convention strategy

<a name='P-AutoMapper-INamingConvention-SplittingExpression'></a>
### SplittingExpression `property`

##### Summary

Regular expression on how to tokenize a member

<a name='T-AutoMapper-Internal-Mappers-IObjectMapper'></a>
## IObjectMapper `type`

##### Namespace

AutoMapper.Internal.Mappers

##### Summary

Mapping execution strategy, as a chain of responsibility

<a name='M-AutoMapper-Internal-Mappers-IObjectMapper-IsMatch-AutoMapper-Internal-TypePair@-'></a>
### IsMatch(context) `method`

##### Summary

When true, the mapping engine will use this mapper as the strategy

##### Returns

Is match

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [AutoMapper.Internal.TypePair@](#T-AutoMapper-Internal-TypePair@ 'AutoMapper.Internal.TypePair@') | Resolution context |

<a name='M-AutoMapper-Internal-Mappers-IObjectMapper-MapExpression-AutoMapper-Internal-IGlobalConfiguration,AutoMapper-ProfileMap,AutoMapper-MemberMap,System-Linq-Expressions-Expression,System-Linq-Expressions-Expression-'></a>
### MapExpression(configurationProvider,profileMap,memberMap,sourceExpression,destExpression) `method`

##### Summary

Builds a mapping expression equivalent to the base Map method

##### Returns

Map expression

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configurationProvider | [AutoMapper.Internal.IGlobalConfiguration](#T-AutoMapper-Internal-IGlobalConfiguration 'AutoMapper.Internal.IGlobalConfiguration') |  |
| profileMap | [AutoMapper.ProfileMap](#T-AutoMapper-ProfileMap 'AutoMapper.ProfileMap') |  |
| memberMap | [AutoMapper.MemberMap](#T-AutoMapper-MemberMap 'AutoMapper.MemberMap') |  |
| sourceExpression | [System.Linq.Expressions.Expression](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression') | Source parameter |
| destExpression | [System.Linq.Expressions.Expression](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression') | Destination parameter |

<a name='T-AutoMapper-Configuration-IPathConfigurationExpression`3'></a>
## IPathConfigurationExpression\`3 `type`

##### Namespace

AutoMapper.Configuration

##### Summary

Member configuration options

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Source type for this member |
| TDestination | Destination type for this map |
| TMember | Type for this member |

<a name='M-AutoMapper-Configuration-IPathConfigurationExpression`3-Ignore'></a>
### Ignore() `method`

##### Summary

Ignore this member for configuration validation and skip during mapping

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-Configuration-IPathConfigurationExpression`3-MapFrom``1-System-Linq-Expressions-Expression{System-Func{`0,``0}}-'></a>
### MapFrom\`\`1(sourceMember) `method`

##### Summary

Specify the source member to map from. Can only reference a member on the `TSource` type
Any null reference exceptions in this expression will be ignored (similar to flattening behavior)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceMember | [System.Linq.Expressions.Expression{System.Func{\`0,\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{`0,``0}}') | Expression referencing the source member to map against |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSourceMember | Member type of the source member to use |

<a name='T-AutoMapper-IProfileConfiguration'></a>
## IProfileConfiguration `type`

##### Namespace

AutoMapper

<a name='P-AutoMapper-IProfileConfiguration-ShouldMapField'></a>
### ShouldMapField `property`

##### Summary

Specify which fields should be mapped.
By default only public fields are mapped.

<a name='P-AutoMapper-IProfileConfiguration-ShouldMapMethod'></a>
### ShouldMapMethod `property`

##### Summary

Specify which methods, of those that are eligible (public, parameterless, and non-static or extension methods), should be mapped.
By default all eligible methods are mapped.

<a name='P-AutoMapper-IProfileConfiguration-ShouldMapProperty'></a>
### ShouldMapProperty `property`

##### Summary

Specify which properties should be mapped.
By default only public properties are mapped.

<a name='P-AutoMapper-IProfileConfiguration-ShouldUseConstructor'></a>
### ShouldUseConstructor `property`

##### Summary

Specify which constructors should be considered for the destination objects.
By default all constructors are considered.

<a name='P-AutoMapper-IProfileConfiguration-SourceExtensionMethods'></a>
### SourceExtensionMethods `property`

##### Summary

Source extension methods included for search

<a name='T-AutoMapper-IProfileExpression'></a>
## IProfileExpression `type`

##### Namespace

AutoMapper

##### Summary

Configuration for profile-specific maps

<a name='P-AutoMapper-IProfileExpression-AllowNullCollections'></a>
### AllowNullCollections `property`

##### Summary

Allow null destination collections. If true, null source collections result in null destination collections. Default false.

<a name='P-AutoMapper-IProfileExpression-AllowNullDestinationValues'></a>
### AllowNullDestinationValues `property`

##### Summary

Allow null destination values. If false, destination objects will be created for deep object graphs. Default true.

<a name='P-AutoMapper-IProfileExpression-DestinationMemberNamingConvention'></a>
### DestinationMemberNamingConvention `property`

##### Summary

Naming convention for destination members

<a name='P-AutoMapper-IProfileExpression-SourceMemberNamingConvention'></a>
### SourceMemberNamingConvention `property`

##### Summary

Naming convention for source members

<a name='P-AutoMapper-IProfileExpression-ValueTransformers'></a>
### ValueTransformers `property`

##### Summary

Value transformers. Modify the list directly or use [Add\`\`1](#M-AutoMapper-ValueTransformerConfigurationExtensions-Add``1-System-Collections-Generic-List{AutoMapper-ValueTransformerConfiguration},System-Linq-Expressions-Expression{System-Func{``0,``0}}- 'AutoMapper.ValueTransformerConfigurationExtensions.Add``1(System.Collections.Generic.List{AutoMapper.ValueTransformerConfiguration},System.Linq.Expressions.Expression{System.Func{``0,``0}})')

<a name='M-AutoMapper-IProfileExpression-AddGlobalIgnore-System-String-'></a>
### AddGlobalIgnore(propertyNameStartingWith) `method`

##### Summary

Add a property name to globally ignore. Matches against the beginning of the property names.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyNameStartingWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Property name to match against |

<a name='M-AutoMapper-IProfileExpression-ClearPrefixes'></a>
### ClearPrefixes() `method`

##### Summary

Clear the list of recognized prefixes.

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-IProfileExpression-CreateMap-System-Type,System-Type-'></a>
### CreateMap(sourceType,destinationType) `method`

##### Summary

Create a mapping configuration from the source type to the destination type.
Use this method when the source and destination type are known at runtime and not compile time.

##### Returns

Mapping expression for more configuration options

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Source type |
| destinationType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Destination type |

<a name='M-AutoMapper-IProfileExpression-CreateMap-System-Type,System-Type,AutoMapper-MemberList-'></a>
### CreateMap(sourceType,destinationType,memberList) `method`

##### Summary

Creates a mapping configuration from the source type to the destination type.
Specify the member list to validate against during configuration validation.

##### Returns

Mapping expression for more configuration options

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Source type |
| destinationType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Destination type |
| memberList | [AutoMapper.MemberList](#T-AutoMapper-MemberList 'AutoMapper.MemberList') | Member list to validate |

<a name='M-AutoMapper-IProfileExpression-CreateMap``2'></a>
### CreateMap\`\`2() `method`

##### Summary

Creates a mapping configuration from the `TSource` type to the `TDestination` type

##### Returns

Mapping expression for more configuration options

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Source type |
| TDestination | Destination type |

<a name='M-AutoMapper-IProfileExpression-CreateMap``2-AutoMapper-MemberList-'></a>
### CreateMap\`\`2(memberList) `method`

##### Summary

Creates a mapping configuration from the `TSource` type to the `TDestination` type.
Specify the member list to validate against during configuration validation.

##### Returns

Mapping expression for more configuration options

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| memberList | [AutoMapper.MemberList](#T-AutoMapper-MemberList 'AutoMapper.MemberList') | Member list to validate |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Source type |
| TDestination | Destination type |

<a name='M-AutoMapper-IProfileExpression-CreateProjection``2'></a>
### CreateProjection\`\`2() `method`

##### Summary

Creates a projection configuration from the `TSource` type to the `TDestination` type

##### Returns

Mapping expression for more configuration options

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Source type |
| TDestination | Destination type |

<a name='M-AutoMapper-IProfileExpression-CreateProjection``2-AutoMapper-MemberList-'></a>
### CreateProjection\`\`2(memberList) `method`

##### Summary

Creates a projection configuration from the `TSource` type to the `TDestination` type.
Specify the member list to validate against during configuration validation.

##### Returns

Mapping expression for more configuration options

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| memberList | [AutoMapper.MemberList](#T-AutoMapper-MemberList 'AutoMapper.MemberList') | Member list to validate |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Source type |
| TDestination | Destination type |

<a name='M-AutoMapper-IProfileExpression-DisableConstructorMapping'></a>
### DisableConstructorMapping() `method`

##### Summary

Disable constructor mapping. Use this if you don't intend to have AutoMapper try to map to constructors

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-IProfileExpression-IncludeSourceExtensionMethods-System-Type-'></a>
### IncludeSourceExtensionMethods(type) `method`

##### Summary

Include extension methods against source members for matching destination members to. Default source extension methods from [Enumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Enumerable 'System.Linq.Enumerable')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Static type that contains extension methods |

<a name='M-AutoMapper-IProfileExpression-RecognizeDestinationPostfixes-System-String[]-'></a>
### RecognizeDestinationPostfixes(postfixes) `method`

##### Summary

Recognize a list of postfixes to be removed from destination member names when matching

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| postfixes | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | List of postfixes |

<a name='M-AutoMapper-IProfileExpression-RecognizeDestinationPrefixes-System-String[]-'></a>
### RecognizeDestinationPrefixes(prefixes) `method`

##### Summary

Recognize a list of prefixes to be removed from destination member names when matching

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| prefixes | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | List of prefixes |

<a name='M-AutoMapper-IProfileExpression-RecognizePostfixes-System-String[]-'></a>
### RecognizePostfixes(postfixes) `method`

##### Summary

Recognize a list of postfixes to be removed from source member names when matching

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| postfixes | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | List of postfixes |

<a name='M-AutoMapper-IProfileExpression-RecognizePrefixes-System-String[]-'></a>
### RecognizePrefixes(prefixes) `method`

##### Summary

Recognize a list of prefixes to be removed from source member names when matching

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| prefixes | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | List of prefixes |

<a name='M-AutoMapper-IProfileExpression-ReplaceMemberName-System-String,System-String-'></a>
### ReplaceMemberName(original,newValue) `method`

##### Summary

Provide a new value for a part of a members name

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| original | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Original member value |
| newValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | New member value |

<a name='T-AutoMapper-Internal-IProfileExpressionInternal'></a>
## IProfileExpressionInternal `type`

##### Namespace

AutoMapper.Internal

<a name='P-AutoMapper-Internal-IProfileExpressionInternal-EnableNullPropagationForQueryMapping'></a>
### EnableNullPropagationForQueryMapping `property`

##### Summary

Allows to enable null-value propagation for query mapping.

<a name='P-AutoMapper-Internal-IProfileExpressionInternal-FieldMappingEnabled'></a>
### FieldMappingEnabled `property`

##### Summary

Disable fields mapping. Use this if you don't intend to have AutoMapper try to map from/to fields.

<a name='P-AutoMapper-Internal-IProfileExpressionInternal-MethodMappingEnabled'></a>
### MethodMappingEnabled `property`

##### Summary

Disable method mapping. Use this if you don't intend to have AutoMapper try to map from methods.

<a name='M-AutoMapper-Internal-IProfileExpressionInternal-ForAllMaps-System-Action{AutoMapper-TypeMap,AutoMapper-IMappingExpression}-'></a>
### ForAllMaps(configuration) `method`

##### Summary

Specify common configuration for all type maps.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [System.Action{AutoMapper.TypeMap,AutoMapper.IMappingExpression}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.TypeMap,AutoMapper.IMappingExpression}') | configuration callback |

<a name='M-AutoMapper-Internal-IProfileExpressionInternal-ForAllPropertyMaps-System-Func{AutoMapper-PropertyMap,System-Boolean},System-Action{AutoMapper-PropertyMap,AutoMapper-IMemberConfigurationExpression}-'></a>
### ForAllPropertyMaps(condition,memberOptions) `method`

##### Summary

Customize configuration for all members across all maps

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Func{AutoMapper.PropertyMap,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{AutoMapper.PropertyMap,System.Boolean}') | Condition |
| memberOptions | [System.Action{AutoMapper.PropertyMap,AutoMapper.IMemberConfigurationExpression}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.PropertyMap,AutoMapper.IMemberConfigurationExpression}') | Callback for member options. Use the property map for conditional maps. |

<a name='T-AutoMapper-IProjectionExpressionBase`3'></a>
## IProjectionExpressionBase\`3 `type`

##### Namespace

AutoMapper

##### Summary

Common mapping configuration options between generic and non-generic mapping configuration

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Source type |
| TDestination | Destination type |
| TMappingExpression | Concrete return type for fluent interface |

<a name='P-AutoMapper-IProjectionExpressionBase`3-ValueTransformers'></a>
### ValueTransformers `property`

##### Summary

Value transformers, typically configured through explicit or extension methods.

<a name='M-AutoMapper-IProjectionExpressionBase`3-ConstructUsing-System-Linq-Expressions-Expression{System-Func{`0,`1}}-'></a>
### ConstructUsing(ctor) `method`

##### Summary

Supply a custom instantiation expression for the destination type

##### Returns

Itself

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ctor | [System.Linq.Expressions.Expression{System.Func{\`0,\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{`0,`1}}') | Expression to create the destination type given the source object |

<a name='M-AutoMapper-IProjectionExpressionBase`3-ConvertUsing-System-Linq-Expressions-Expression{System-Func{`0,`1}}-'></a>
### ConvertUsing(mappingExpression) `method`

##### Summary

Skip member mapping and use a custom expression to convert to the destination type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mappingExpression | [System.Linq.Expressions.Expression{System.Func{\`0,\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{`0,`1}}') | Callback to convert from source type to destination type |

<a name='M-AutoMapper-IProjectionExpressionBase`3-ForCtorParam-System-String,System-Action{AutoMapper-Configuration-ICtorParamConfigurationExpression{`0}}-'></a>
### ForCtorParam(ctorParamName,paramOptions) `method`

##### Summary

Customize configuration for individual constructor parameter

##### Returns

Itself

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ctorParamName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Constructor parameter name |
| paramOptions | [System.Action{AutoMapper.Configuration.ICtorParamConfigurationExpression{\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.Configuration.ICtorParamConfigurationExpression{`0}}') | Options |

<a name='M-AutoMapper-IProjectionExpressionBase`3-MaxDepth-System-Int32-'></a>
### MaxDepth(depth) `method`

##### Summary

For self-referential types, limit recurse depth.
Enables PreserveReferences.

##### Returns

Itself

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| depth | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of levels to limit to |

<a name='M-AutoMapper-IProjectionExpressionBase`3-ValidateMemberList-AutoMapper-MemberList-'></a>
### ValidateMemberList(memberList) `method`

##### Summary

Specify which member list to validate

##### Returns

Itself

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| memberList | [AutoMapper.MemberList](#T-AutoMapper-MemberList 'AutoMapper.MemberList') | Member list to validate |

<a name='T-AutoMapper-IProjectionExpression`2'></a>
## IProjectionExpression\`2 `type`

##### Namespace

AutoMapper

<a name='M-AutoMapper-IProjectionExpression`2-ForMember``1-System-Linq-Expressions-Expression{System-Func{`1,``0}},System-Action{AutoMapper-IProjectionMemberConfiguration{`0,`1,``0}}-'></a>
### ForMember\`\`1(destinationMember,memberOptions) `method`

##### Summary

Customize configuration for individual member

##### Returns

Itself

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| destinationMember | [System.Linq.Expressions.Expression{System.Func{\`1,\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{`1,``0}}') | Expression to the top-level destination member. This must be a member on the `TDestination`TDestination |
| memberOptions | [System.Action{AutoMapper.IProjectionMemberConfiguration{\`0,\`1,\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.IProjectionMemberConfiguration{`0,`1,``0}}') | Callback for member options |

<a name='T-AutoMapper-IProjectionExpression`3'></a>
## IProjectionExpression\`3 `type`

##### Namespace

AutoMapper

<a name='M-AutoMapper-IProjectionExpression`3-AddTransform``1-System-Linq-Expressions-Expression{System-Func{``0,``0}}-'></a>
### AddTransform\`\`1(transformer) `method`

##### Summary

Apply a transformation function after any resolved destination member value with the given type

##### Returns

Itself

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| transformer | [System.Linq.Expressions.Expression{System.Func{\`\`0,\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,``0}}') | Transformation expression |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValue | Value type to match and transform |

<a name='M-AutoMapper-IProjectionExpression`3-IncludeMembers-System-Linq-Expressions-Expression{System-Func{`0,System-Object}}[]-'></a>
### IncludeMembers(memberExpressions) `method`

##### Summary

Add extra configuration to the current map by also mapping the specified child objects to the destination object.
The maps from the child types to the destination need to be created explicitly.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| memberExpressions | [System.Linq.Expressions.Expression{System.Func{\`0,System.Object}}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{`0,System.Object}}[]') | the child objects to map to the destination |

<a name='T-AutoMapper-IProjectionMemberConfiguration`3'></a>
## IProjectionMemberConfiguration\`3 `type`

##### Namespace

AutoMapper

##### Summary

Member configuration options

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Source type for this member |
| TMember | Type for this member |
| TDestination | Destination type for this map |

<a name='M-AutoMapper-IProjectionMemberConfiguration`3-AddTransform-System-Linq-Expressions-Expression{System-Func{`2,`2}}-'></a>
### AddTransform(transformer) `method`

##### Summary

Apply a transformation function after any resolved destination member value with the given type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| transformer | [System.Linq.Expressions.Expression{System.Func{\`2,\`2}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{`2,`2}}') | Transformation expression |

<a name='M-AutoMapper-IProjectionMemberConfiguration`3-AllowNull'></a>
### AllowNull() `method`

##### Summary

Allow this member to be null. Overrides AllowNullDestinationValues/AllowNullCollection.

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-IProjectionMemberConfiguration`3-DoNotAllowNull'></a>
### DoNotAllowNull() `method`

##### Summary

Don't allow this member to be null. Overrides AllowNullDestinationValues/AllowNullCollection.

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-IProjectionMemberConfiguration`3-ExplicitExpansion'></a>
### ExplicitExpansion() `method`

##### Summary

Ignore this member for LINQ projections unless explicitly expanded during projection

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-IProjectionMemberConfiguration`3-Ignore'></a>
### Ignore() `method`

##### Summary

Ignore this member for configuration validation and skip during mapping

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-IProjectionMemberConfiguration`3-MapFrom``1-System-Linq-Expressions-Expression{System-Func{`0,``0}}-'></a>
### MapFrom\`\`1(mapExpression) `method`

##### Summary

Map destination member using a custom expression. Used in LINQ projection (ProjectTo).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mapExpression | [System.Linq.Expressions.Expression{System.Func{\`0,\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{`0,``0}}') | Map expression |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSourceMember | Member type of the source member to use |

<a name='M-AutoMapper-IProjectionMemberConfiguration`3-NullSubstitute-System-Object-'></a>
### NullSubstitute(nullSubstitute) `method`

##### Summary

Substitute a custom value when the source member resolves as null

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| nullSubstitute | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Value to use |

<a name='T-AutoMapper-Configuration-ISourceMemberConfigurationExpression'></a>
## ISourceMemberConfigurationExpression `type`

##### Namespace

AutoMapper.Configuration

##### Summary

Source member configuration options

<a name='M-AutoMapper-Configuration-ISourceMemberConfigurationExpression-DoNotValidate'></a>
### DoNotValidate() `method`

##### Summary

Ignore this member when validating source members, MemberList.Source.
Does not affect validation for the default case, MemberList.Destination.

##### Parameters

This method has no parameters.

<a name='T-AutoMapper-ITypeConverter`2'></a>
## ITypeConverter\`2 `type`

##### Namespace

AutoMapper

##### Summary

Converts source type to destination type instead of normal member mapping

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Source type |
| TDestination | Destination type |

<a name='M-AutoMapper-ITypeConverter`2-Convert-`0,`1,AutoMapper-ResolutionContext-'></a>
### Convert(source,destination,context) `method`

##### Summary

Performs conversion from source to destination type

##### Returns

Destination object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [\`0](#T-`0 '`0') | Source object |
| destination | [\`1](#T-`1 '`1') | Destination object |
| context | [AutoMapper.ResolutionContext](#T-AutoMapper-ResolutionContext 'AutoMapper.ResolutionContext') | Resolution context |

<a name='T-AutoMapper-IValueConverter`2'></a>
## IValueConverter\`2 `type`

##### Namespace

AutoMapper

##### Summary

Converts a source member value to a destination member value

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSourceMember | Source member type |
| TDestinationMember | Destination member type |

<a name='M-AutoMapper-IValueConverter`2-Convert-`0,AutoMapper-ResolutionContext-'></a>
### Convert(sourceMember,context) `method`

##### Summary

Perform conversion from source member value to destination member value

##### Returns

Destination member value

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceMember | [\`0](#T-`0 '`0') | Source member object |
| context | [AutoMapper.ResolutionContext](#T-AutoMapper-ResolutionContext 'AutoMapper.ResolutionContext') | Resolution context |

<a name='T-AutoMapper-IValueResolver`3'></a>
## IValueResolver\`3 `type`

##### Namespace

AutoMapper

##### Summary

Extension point to provide custom resolution for a destination value

<a name='M-AutoMapper-IValueResolver`3-Resolve-`0,`1,`2,AutoMapper-ResolutionContext-'></a>
### Resolve(source,destination,destMember,context) `method`

##### Summary

Implementors use source object to provide a destination object.

##### Returns

Result, typically build from the source resolution result

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [\`0](#T-`0 '`0') | Source object |
| destination | [\`1](#T-`1 '`1') | Destination object, if exists |
| destMember | [\`2](#T-`2 '`2') | Destination member |
| context | [AutoMapper.ResolutionContext](#T-AutoMapper-ResolutionContext 'AutoMapper.ResolutionContext') | The context of the mapping |

<a name='T-AutoMapper-Configuration-Annotations-IgnoreAttribute'></a>
## IgnoreAttribute `type`

##### Namespace

AutoMapper.Configuration.Annotations

##### Summary

Ignore this member for configuration validation and skip during mapping.

##### Remarks

Must be used in combination with [AutoMapAttribute](#T-AutoMapper-AutoMapAttribute 'AutoMapper.AutoMapAttribute')

<a name='T-AutoMapper-Configuration-Annotations-MapAtRuntimeAttribute'></a>
## MapAtRuntimeAttribute `type`

##### Namespace

AutoMapper.Configuration.Annotations

##### Summary

Do not precompute the execution plan for this member, just map it at runtime.
Simplifies the execution plan by not inlining.

##### Remarks

Must be used in combination with [AutoMapAttribute](#T-AutoMapper-AutoMapAttribute 'AutoMapper.AutoMapAttribute')

<a name='T-AutoMapper-MapperConfigurationExpression'></a>
## MapperConfigurationExpression `type`

##### Namespace

AutoMapper

<a name='P-AutoMapper-MapperConfigurationExpression-AutoMapper#Internal#IGlobalConfigurationExpression#AllowAdditiveTypeMapCreation'></a>
### AutoMapper#Internal#IGlobalConfigurationExpression#AllowAdditiveTypeMapCreation `property`

##### Summary

Allow the same map to exist in different profiles.
The default is to throw an exception, true means the maps are merged.

<a name='P-AutoMapper-MapperConfigurationExpression-AutoMapper#Internal#IGlobalConfigurationExpression#MaxExecutionPlanDepth'></a>
### AutoMapper#Internal#IGlobalConfigurationExpression#MaxExecutionPlanDepth `property`

##### Summary

How many levels deep should AutoMapper try to inline the execution plan for child classes.
See for details.

<a name='P-AutoMapper-MapperConfigurationExpression-AutoMapper#Internal#IGlobalConfigurationExpression#RecursiveQueriesMaxDepth'></a>
### AutoMapper#Internal#IGlobalConfigurationExpression#RecursiveQueriesMaxDepth `property`

##### Summary

How many levels deep should recursive queries be expanded.
Must be zero for EF6. Can be greater than zero for EF Core.

<a name='M-AutoMapper-MapperConfigurationExpression-AutoMapper#Internal#IGlobalConfigurationExpression#Validator-System-Action{AutoMapper-Configuration-ValidationContext}-'></a>
### AutoMapper#Internal#IGlobalConfigurationExpression#Validator(validator) `method`

##### Summary

Add an action to be called when validating the configuration.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| validator | [System.Action{AutoMapper.Configuration.ValidationContext}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{AutoMapper.Configuration.ValidationContext}') | the validation callback |

<a name='T-AutoMapper-Configuration-Annotations-MappingOrderAttribute'></a>
## MappingOrderAttribute `type`

##### Namespace

AutoMapper.Configuration.Annotations

##### Summary

Supply a custom mapping order instead of what the .NET runtime returns

##### Remarks

Must be used in combination with [AutoMapAttribute](#T-AutoMapper-AutoMapAttribute 'AutoMapper.AutoMapAttribute')

<a name='T-AutoMapper-MemberList'></a>
## MemberList `type`

##### Namespace

AutoMapper

##### Summary

Member list to check for configuration validation

<a name='F-AutoMapper-MemberList-Destination'></a>
### Destination `constants`

##### Summary

Check that all destination members are mapped

<a name='F-AutoMapper-MemberList-None'></a>
### None `constants`

##### Summary

Check neither source nor destination members, skipping validation

<a name='F-AutoMapper-MemberList-Source'></a>
### Source `constants`

##### Summary

Check that all source members are mapped

<a name='T-AutoMapper-MemberMap'></a>
## MemberMap `type`

##### Namespace

AutoMapper

##### Summary

The base class for member maps (property, constructor and path maps).

<a name='T-mwo-SimpleDI-MissingRegistrationException'></a>
## MissingRegistrationException `type`

##### Namespace

mwo.SimpleDI

##### Summary

The exception is thrown if the state of the registrations is not correct while resolving.

<a name='M-mwo-SimpleDI-MissingRegistrationException-#ctor-System-Type-'></a>
### #ctor(t) `constructor`

##### Summary

Initializes a new instance of the mwo.SimpleDI.MissingRegistrationException class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The type that was missing a registration, is wrapped into a message that describes the error. |

<a name='M-mwo-SimpleDI-MissingRegistrationException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Initializes a new instance of the mwo.SimpleDI.MissingRegistrationException class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message that describes the error. |

<a name='M-mwo-SimpleDI-MissingRegistrationException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,innerException) `constructor`

##### Summary

Initializes a new instance of the mwo.SimpleDI.MissingRegistrationException class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message that describes the error. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The exception that is the cause of the current exception. |

<a name='M-mwo-SimpleDI-MissingRegistrationException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the mwo.SimpleDI.MissingRegistrationException class.

##### Parameters

This constructor has no parameters.

<a name='M-mwo-SimpleDI-MissingRegistrationException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor(serializationInfo,streamingContext) `constructor`

##### Summary

Initializes a new instance of the mwo.SimpleDI.MissingRegistrationException class with serailized data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serializationInfo | [System.Runtime.Serialization.SerializationInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.SerializationInfo 'System.Runtime.Serialization.SerializationInfo') | The object that holds the serialized object data. |
| streamingContext | [System.Runtime.Serialization.StreamingContext](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.StreamingContext 'System.Runtime.Serialization.StreamingContext') | The contextual information about the source or destination. |

<a name='T-AutoMapper-Configuration-Annotations-NullSubstituteAttribute'></a>
## NullSubstituteAttribute `type`

##### Namespace

AutoMapper.Configuration.Annotations

##### Summary

Substitute a custom value when the source member resolves as null

##### Remarks

Must be used in combination with [AutoMapAttribute](#T-AutoMapper-AutoMapAttribute 'AutoMapper.AutoMapAttribute')

<a name='P-AutoMapper-Configuration-Annotations-NullSubstituteAttribute-Value'></a>
### Value `property`

##### Summary

Value to use if source value is null

<a name='T-AutoMapper-QueryableExtensions-NullsafeQueryRewriter'></a>
## NullsafeQueryRewriter `type`

##### Namespace

AutoMapper.QueryableExtensions

##### Summary

Expression visitor for making member access null-safe.

##### Remarks

NullSafeQueryRewriter is copied from the NeinLinq project, licensed under the MIT license.
Copyright (c) 2014-2018 Axel Heer.
See https://github.com/axelheer/nein-linq/blob/master/src/NeinLinq/NullsafeQueryRewriter.cs

<a name='M-AutoMapper-QueryableExtensions-NullsafeQueryRewriter-VisitMember-System-Linq-Expressions-MemberExpression-'></a>
### VisitMember() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-AutoMapper-QueryableExtensions-NullsafeQueryRewriter-VisitMethodCall-System-Linq-Expressions-MethodCallExpression-'></a>
### VisitMethodCall() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-AutoMapper-Internal-Mappers-ObjectMapper`2'></a>
## ObjectMapper\`2 `type`

##### Namespace

AutoMapper.Internal.Mappers

##### Summary

Base class for simple object mappers that don't want to use expressions.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | type of the source |
| TDestination | type of the destination |

<a name='M-AutoMapper-Internal-Mappers-ObjectMapper`2-IsMatch-AutoMapper-Internal-TypePair@-'></a>
### IsMatch(context) `method`

##### Summary

When true, the mapping engine will use this mapper as the strategy

##### Returns

Is match

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [AutoMapper.Internal.TypePair@](#T-AutoMapper-Internal-TypePair@ 'AutoMapper.Internal.TypePair@') | Resolution context |

<a name='M-AutoMapper-Internal-Mappers-ObjectMapper`2-Map-`0,`1,System-Type,System-Type,AutoMapper-ResolutionContext-'></a>
### Map(source,destination,sourceType,destinationType,context) `method`

##### Summary

Performs conversion from source to destination type

##### Returns

Destination object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [\`0](#T-`0 '`0') | Source object |
| destination | [\`1](#T-`1 '`1') | Destination object |
| sourceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The compile time type of the source object |
| destinationType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The compile time type of the destination object |
| context | [AutoMapper.ResolutionContext](#T-AutoMapper-ResolutionContext 'AutoMapper.ResolutionContext') | Resolution context |

<a name='T-AutoMapper-Profile'></a>
## Profile `type`

##### Namespace

AutoMapper

##### Summary

Provides a named configuration for maps. Naming conventions become scoped per profile.

<a name='T-AutoMapper-QueryableExtensions-Impl-QueryMapperHelper'></a>
## QueryMapperHelper `type`

##### Namespace

AutoMapper.QueryableExtensions.Impl

<a name='M-AutoMapper-QueryableExtensions-Impl-QueryMapperHelper-ReplaceItemType-System-Type,System-Type,System-Type-'></a>
### ReplaceItemType(targetType,oldType,newType) `method`

##### Summary

if targetType is oldType, method will return newType
if targetType is not oldType, method will return targetType
if targetType is generic type with oldType arguments, method will replace all oldType arguments on newType

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| oldType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| newType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='T-AutoMapper-ResolutionContext'></a>
## ResolutionContext `type`

##### Namespace

AutoMapper

##### Summary

Context information regarding resolution of a destination value

<a name='P-AutoMapper-ResolutionContext-InstanceCache'></a>
### InstanceCache `property`

##### Summary

Instance cache for resolving circular references

<a name='P-AutoMapper-ResolutionContext-Items'></a>
### Items `property`

##### Summary

Context items from [Options](#P-AutoMapper-ResolutionContext-Options 'AutoMapper.ResolutionContext.Options')

<a name='P-AutoMapper-ResolutionContext-Mapper'></a>
### Mapper `property`

##### Summary

Current mapper

<a name='P-AutoMapper-ResolutionContext-Options'></a>
### Options `property`

##### Summary

Mapping operation options

<a name='P-AutoMapper-ResolutionContext-TypeDepth'></a>
### TypeDepth `property`

##### Summary

Instance cache for resolving keeping track of depth

<a name='T-AutoMapper-Configuration-Annotations-SourceMemberAttribute'></a>
## SourceMemberAttribute `type`

##### Namespace

AutoMapper.Configuration.Annotations

##### Summary

Specify the source member to map from. Can only reference a member on the [SourceType](#P-AutoMapper-AutoMapAttribute-SourceType 'AutoMapper.AutoMapAttribute.SourceType') type

##### Remarks

Must be used in combination with [AutoMapAttribute](#T-AutoMapper-AutoMapAttribute 'AutoMapper.AutoMapAttribute')

<a name='T-AutoMapper-Configuration-SourceMemberConfig'></a>
## SourceMemberConfig `type`

##### Namespace

AutoMapper.Configuration

##### Summary

Contains member configuration relating to source members

<a name='T-AutoMapper-Internal-TypeDetails'></a>
## TypeDetails `type`

##### Namespace

AutoMapper.Internal

##### Summary

Contains cached reflection information for easy retrieval

<a name='T-AutoMapper-TypeMap'></a>
## TypeMap `type`

##### Namespace

AutoMapper

##### Summary

Main configuration object holding all mapping configuration for a source and destination type

<a name='T-AutoMapper-Configuration-Annotations-UseExistingValueAttribute'></a>
## UseExistingValueAttribute `type`

##### Namespace

AutoMapper.Configuration.Annotations

##### Summary

Use the destination value instead of mapping from the source value or creating a new instance

##### Remarks

Must be used in combination with [AutoMapAttribute](#T-AutoMapper-AutoMapAttribute 'AutoMapper.AutoMapAttribute')

<a name='T-AutoMapper-Configuration-Annotations-ValueConverterAttribute'></a>
## ValueConverterAttribute `type`

##### Namespace

AutoMapper.Configuration.Annotations

##### Summary

Specify a value converter type to convert from the matching source member to the destination member
Use with [SourceMemberAttribute](#T-AutoMapper-Configuration-Annotations-SourceMemberAttribute 'AutoMapper.Configuration.Annotations.SourceMemberAttribute') to specify a separate source member to supply to the value converter

##### Remarks

Must be used in combination with [AutoMapAttribute](#T-AutoMapper-AutoMapAttribute 'AutoMapper.AutoMapAttribute')

<a name='P-AutoMapper-Configuration-Annotations-ValueConverterAttribute-Type'></a>
### Type `property`

##### Summary

[IValueConverter\`2](#T-AutoMapper-IValueConverter`2 'AutoMapper.IValueConverter`2') type

<a name='T-AutoMapper-Configuration-Annotations-ValueResolverAttribute'></a>
## ValueResolverAttribute `type`

##### Namespace

AutoMapper.Configuration.Annotations

##### Summary

Map destination member using a custom value resolver.
Use with [SourceMemberAttribute](#T-AutoMapper-Configuration-Annotations-SourceMemberAttribute 'AutoMapper.Configuration.Annotations.SourceMemberAttribute') to specify an [IMemberValueResolver\`4](#T-AutoMapper-IMemberValueResolver`4 'AutoMapper.IMemberValueResolver`4') type.

##### Remarks

Must be used in combination with [AutoMapAttribute](#T-AutoMapper-AutoMapAttribute 'AutoMapper.AutoMapAttribute')

<a name='P-AutoMapper-Configuration-Annotations-ValueResolverAttribute-Type'></a>
### Type `property`

##### Summary

[IValueResolver\`3](#T-AutoMapper-IValueResolver`3 'AutoMapper.IValueResolver`3') or [IMemberValueResolver\`4](#T-AutoMapper-IMemberValueResolver`4 'AutoMapper.IMemberValueResolver`4') type

<a name='T-AutoMapper-ValueTransformerConfigurationExtensions'></a>
## ValueTransformerConfigurationExtensions `type`

##### Namespace

AutoMapper

<a name='M-AutoMapper-ValueTransformerConfigurationExtensions-Add``1-System-Collections-Generic-List{AutoMapper-ValueTransformerConfiguration},System-Linq-Expressions-Expression{System-Func{``0,``0}}-'></a>
### Add\`\`1(valueTransformers,transformer) `method`

##### Summary

Apply a transformation function after any resolved destination member value with the given type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| valueTransformers | [System.Collections.Generic.List{AutoMapper.ValueTransformerConfiguration}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{AutoMapper.ValueTransformerConfiguration}') | Value transformer list |
| transformer | [System.Linq.Expressions.Expression{System.Func{\`\`0,\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,``0}}') | Transformation expression |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValue | Value type to match and transform |
