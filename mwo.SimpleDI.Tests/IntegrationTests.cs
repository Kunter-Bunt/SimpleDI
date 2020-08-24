using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mwo.SimpleDI.Tests
{
    [TestClass]
    public class IntegrationTests
    {
        private Logger SingletonLogger;
        private IDependencyContainer UniqueContainer;
        private Guid RegisteredGuid;

        [TestInitialize]
        public void Initialize()
        {
            SingletonLogger = new Logger(Guid.NewGuid());
            UniqueContainer = DependencyContainerManager.Unique.Register(_ => SingletonLogger);

            RegisteredGuid = Guid.NewGuid();
            DependencyContainerManager.Default.Register(_ => RegisteredGuid);
        }

        [TestCleanup]
        public void Cleanup()
        {
            DependencyContainerManager.Reset();
        }

        [TestMethod]
        public void Register_Resolve_DefaultTest()
        {
            //Arrange
            DependencyContainerManager.Default.Register(_ => new Logger(Guid.NewGuid()));

            //Act
            var result = DependencyContainerManager.Default.Resolve<Logger>();

            //Assert
            Assert.IsNotNull(result);
        }

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
}
