using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mwo.SimpleDI.Tests
{
    [TestClass]
    public class IntegrationTests
    {
        [TestInitialize]
        public void Initialize()
        {
        }

        [TestCleanup]
        public void Cleanup()
        {
            DependencyContainerManager.Reset();
        }

        /// <summary>
        /// This very simple test displays the ability to statically transport the default container and resolve from anywhere without a direct path passing down the container.
        /// This is a handy method to introduce Dependency Injection to an existing project where Dependency Inversion is not well practiced and hard to introduce. 
        /// </summary>
        [TestMethod]
        public void Register_Resolve_DefaultTest()
        {
            //Arrange
            RegistrationFunctionWithNoReturnValue();

            //Act
            var result = CompletelyDisconnectedFunctionWithNoParam();

            //Assert
            Assert.IsNotNull(result);
        }

        private static void RegistrationFunctionWithNoReturnValue()
        {
            DependencyContainerManager.Default.Register<ILogger>(_ => new Logger(Guid.NewGuid()));
        }

        private static ILogger CompletelyDisconnectedFunctionWithNoParam()
        {
            return DependencyContainerManager.Default.Resolve<ILogger>();
        }

        /// <summary>
        /// Of course we can Register the Logger as one of its interfaces. This will probably a common case as Dependency Inversion would make us rely on ILogger rather than the concrete logger.
        /// </summary>
        [TestMethod]
        public void Register_AsInterface_PositiveTest()
        {
            //Arrange
            DependencyContainerManager.Default.Register<ILogger>(_ => new Logger(Guid.NewGuid()));

            //Act
            var result = DependencyContainerManager.Default.Resolve<ILogger>();

            //Assert
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// However, since there is no "real" reflection, if you dont explicitely register something as an Interface, it wont resolve as it.
        /// If you want the Logger to resolve as ITracer, you will have to register it as ITracer.
        /// </summary>
        [TestMethod]
        public void Register_AsInterface_NegativeTest()
        {
            //Arrange
            DependencyContainerManager.Default.Register(_ => new Logger(Guid.NewGuid()));

            //Act
            var ex1 = Assert.ThrowsException<MissingRegistrationException>(() => DependencyContainerManager.Default.Resolve<ILogger>());
            var ex2 = Assert.ThrowsException<MissingRegistrationException>(() => DependencyContainerManager.Default.Resolve<ITracer>());
            var result = DependencyContainerManager.Default.Resolve<Logger>();

            //Assert
            Assert.IsNotNull(ex1);
            Assert.IsNotNull(ex2);
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// This test stacks an request specific container on top of the default container to tie the loggers name to the request, this makes it, so that any Logger resolved throughout this request always has the same name.
        /// This approach can help tie logs together, however it requires passing through the specific container to all functions within this request!
        /// </summary>
        [TestMethod]
        public void Register_CorrealtionId_Test()
        {
            //Arrange
            var correlationId = Guid.NewGuid(); //Usually this would maybe be form HttpContext.GetCorrelationId() or something similar.

            var specificContainerForThisCorrelation = DependencyContainerManager.Unique
                .Register(_ => correlationId)
                .Register(_ => new Logger(_.Resolve<Guid>()));

            //Act
            var result = specificContainerForThisCorrelation.Resolve<Logger>();

            //Assert
            Assert.AreEqual(correlationId.ToString(), result.Name);
        }

        /// <summary>
        /// Here we have a sample with a named container. 
        /// There is a dependency to some form of storage that is read and this reading is performed by the class SomeDependency.
        /// However, in the UnitTest this call must fail, because you wont provide actual URLs and secrets of course.
        /// The Setup method SystemUnderTestSetup leverages RegisterWeak to register the dependency, therefore the Arrange of the UnitTest can insert its FakeDependency class in order to mock the call to the database.
        /// Note how the Arrange does not pass its container to the system under test, yet, all parts of this Unit test work on the same Container.
        /// 
        /// For this scenario it is assumed of course that the method SystemUnderTestWithDependency cannot be modified, is feared to be modified, is burried deep inside the system under test, you name it.
        /// If you would be able to modify the scenario it is a better approach to include the IDepencency as parameter to the constructor or method of the system under test and straight up pass it, like you see it here with SystemUnderTestCallingDependency.
        /// However while the approach of passing dependencies is nice and clean code, its often not feasable with existing software, that might have interfaces that cannot be modified or includes a layer somewhere that assumes empty constructors, or ...
        /// </summary>
        [TestMethod]
        public void RegisterWeak_Resolve_FakeInterfaceTest()
        {
            //Arrange
            var id = Guid.NewGuid().ToString();
            DependencyContainerManager.GetOrCreate("DBReader")
                .Register<IDependency>(_ => new FakeDependency());

            //Act
            var result = SystemUnderTestWithDependency(id);

            //Assert
            Assert.AreEqual(id, result);
        }

        private string SystemUnderTestWithDependency(string id)
        {
            var container = SystemUnderTestSetup();

            var dependency = container.Resolve<IDependency>();
            return SystemUnderTestCallingDependency(dependency, id);
        }

        private IDependencyContainer SystemUnderTestSetup()
        {
            return DependencyContainerManager.GetOrCreate("DBReader")
                .RegisterWeak<IDependency>(_ => new SomeDependency());
        }

        private string SystemUnderTestCallingDependency(IDependency dependency, string id)
        {
            return dependency.GetString(id);
        }
    }

    public class Logger : ILogger, ITracer
    {
        public string Name { get; private set; }
        public Logger(Guid guid)
        {
            Name = guid.ToString();
        }
        public void Log(string msg) => Console.WriteLine($"{Name}: {msg}");
        public void Trace(string msg) => Console.WriteLine($"{Name}: {msg}");
    }

    public interface ILogger
    {
        void Log(string msg);
    }

    public interface ITracer
    {
        void Trace(string msg);
    }

    public class SomeDependency : IDependency
    {
        public string GetString(string id)
        {
            throw new WebException();
        }
    }

    public class FakeDependency : IDependency
    {
        public string GetString(string id)
        {
            return id;
        }
    }

    public interface IDependency
    {
        string GetString(string id);
    }
}
