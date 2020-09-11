<a name='assembly'></a>
# mwo.SimpleDI.Doc

## Contents

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
- [IDependencyContainer](#T-mwo-SimpleDI-IDependencyContainer 'mwo.SimpleDI.IDependencyContainer')
  - [ParentContainer](#P-mwo-SimpleDI-IDependencyContainer-ParentContainer 'mwo.SimpleDI.IDependencyContainer.ParentContainer')
  - [IsRegistered\`\`1()](#M-mwo-SimpleDI-IDependencyContainer-IsRegistered``1 'mwo.SimpleDI.IDependencyContainer.IsRegistered``1')
  - [RegisterStrong\`\`1(builder)](#M-mwo-SimpleDI-IDependencyContainer-RegisterStrong``1-System-Func{mwo-SimpleDI-IDependencyContainer,``0}- 'mwo.SimpleDI.IDependencyContainer.RegisterStrong``1(System.Func{mwo.SimpleDI.IDependencyContainer,``0})')
  - [RegisterWeak\`\`1(builder)](#M-mwo-SimpleDI-IDependencyContainer-RegisterWeak``1-System-Func{mwo-SimpleDI-IDependencyContainer,``0}- 'mwo.SimpleDI.IDependencyContainer.RegisterWeak``1(System.Func{mwo.SimpleDI.IDependencyContainer,``0})')
  - [Register\`\`1(builder)](#M-mwo-SimpleDI-IDependencyContainer-Register``1-System-Func{mwo-SimpleDI-IDependencyContainer,``0}- 'mwo.SimpleDI.IDependencyContainer.Register``1(System.Func{mwo.SimpleDI.IDependencyContainer,``0})')
  - [Resolve\`\`1()](#M-mwo-SimpleDI-IDependencyContainer-Resolve``1 'mwo.SimpleDI.IDependencyContainer.Resolve``1')
  - [TryResolve\`\`1(obj)](#M-mwo-SimpleDI-IDependencyContainer-TryResolve``1-``0@- 'mwo.SimpleDI.IDependencyContainer.TryResolve``1(``0@)')
- [MissingRegistrationException](#T-mwo-SimpleDI-MissingRegistrationException 'mwo.SimpleDI.MissingRegistrationException')
  - [#ctor(t)](#M-mwo-SimpleDI-MissingRegistrationException-#ctor-System-Type- 'mwo.SimpleDI.MissingRegistrationException.#ctor(System.Type)')
  - [#ctor(message)](#M-mwo-SimpleDI-MissingRegistrationException-#ctor-System-String- 'mwo.SimpleDI.MissingRegistrationException.#ctor(System.String)')
  - [#ctor(message,innerException)](#M-mwo-SimpleDI-MissingRegistrationException-#ctor-System-String,System-Exception- 'mwo.SimpleDI.MissingRegistrationException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-mwo-SimpleDI-MissingRegistrationException-#ctor 'mwo.SimpleDI.MissingRegistrationException.#ctor')
  - [#ctor(serializationInfo,streamingContext)](#M-mwo-SimpleDI-MissingRegistrationException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'mwo.SimpleDI.MissingRegistrationException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')

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
