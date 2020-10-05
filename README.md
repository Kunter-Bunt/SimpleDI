# SimpleDI
A Dependency Injection framework that works without a Build operation.

This project was created as an attempt to introduce Dependency Injection to Dynamics 365 projects to improve their testability.
Why not just introduce something like Unity or Autofac to them, you ask? Here is why:
- Dynamics Plugins rely on the IPlugin Interface and a fixed set of constructors, passing a Dependency Container from the outside is not possible via these.
- These frameworks do not support beeing used static (for good reasons), but that would be the option to get around the IPlugin layer.
- They tend to rely heavily on Reflection and an expensive build operation, assuming that you can do this for example on startup. With Dynamics Plugins you are working inside Sandboxes and cannot persist a Dependency Container for long while also usually firing many small Plugins. Building a Dependency Container every time here can be very taxing on the general performance of your plugins.

However Dependency Injection has many advantages, one being that you can insert fakes for external dependencies for Tests. And interacting with external systems from CRM is most probably something any decent sized project is faced with. 

## Goals
- Provide Dependency Injection without taxing operations, quick registration, quick resolving.
  - This is achieved by letting the user register actual builder functions returning an instance of the type. This makes this as fast as accessing a dictionary and actually invoking a Func.
- Allow for both static as well as dynamic containers, to support existing projects where many layers would have to be changed to introduce DI as well as newer code that tries it "the right way" of pulling through Dependency Inversion.
  - For the static way the DependencyContainerManager offers the _Default_ as well as named IDependencyContainer with _GetOrCreate_.
  - When you want to use dynamic containers, for example per Correlation, the DependencyContainerManager offers a _Unique_, always creating a new, unique IDependencyContainer.
  - Since IDependencyContainers are hierachical, you can mix and match both styles. This helps the slow transition to a code base that hits the D in SOLID.
- Do not require code or tools that are not supported for Dynamics 365.
  - Because the resulting NuGet contains a Shared Project, the importing project will compile the source code as if it was part of the project. At the same time this is not an inclusion of the source files, keeping this project logically out of your project. It will look like a normal NuGet reference while its actually an inclusion of source files. This saves you from merging the assemblies with ILMerge, while still maintaining a split in projects and reusability.
- Be simple.(period) There are currently less than 250 lines in the two main classes DependencyContainerManager and DependencyContainer, including comments! So in case this solution has a bug, you can probably figure it out and even fix it the short way. Of course you are encouraged to contribute or open an issue in case you find a problem. However bigger extensions like a _RegisterType_ method should not be part of this project as this would start to defeat the purpose of this project. You could then fork the project, create a new one stacking on top or turn to more fully featured Frameworks like Autofac and Unity.

## Features & Usage
Check the [wiki](https://github.com/Kunter-Bunt/SimpleDI/wiki) to find out more about the provided functions and their usage.

## License
**MIT**  
