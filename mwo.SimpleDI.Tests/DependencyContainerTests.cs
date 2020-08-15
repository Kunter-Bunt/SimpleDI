using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mwo.SimpleDI.Tests
{
    [TestClass]
    public class DependencyContainerTests
    {
        private IDependencyContainer Container;
        private IDependencyContainer ParentContainer;
        private IDependencyContainer ChildContainer;

        [TestInitialize]
        public void Initialize()
        {
            Container = new DependencyContainer();
            ParentContainer = new DependencyContainer();
            ChildContainer = new DependencyContainer(ParentContainer);
        }

        #region IsRegistered
        [TestMethod]
        public void IsRegistered_PositiveTest()
        {
            //Arrange
            Container.Register(_ => Guid.NewGuid());

            //Act
            var result = Container.IsRegistered<Guid>();

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsRegistered_NegativeTest()
        {
            //Act
            var result = Container.IsRegistered<Guid>();

            //Assert
            Assert.IsFalse(result);
        }
        #endregion

        #region Register
        [TestMethod]
        public void Register_BasicTest()
        {
            //Arrange
            var container = Container as DependencyContainer;
            var initialRegistrations = container.Registrations.Count;

            //Act
            Container.Register(_ => Guid.NewGuid());

            //Assert
            Assert.AreEqual(initialRegistrations + 1, container.Registrations.Count);
            Assert.IsTrue(container.Registrations.ContainsKey(typeof(Guid)));
        }

        [TestMethod]
        public void Register_SelfTest()
        {
            //Arrange
            var container = Container as DependencyContainer;
            var initialRegistrations = container.Registrations.Count;

            //Assert
            Assert.AreEqual(initialRegistrations, container.Registrations.Count);
            Assert.IsTrue(container.Registrations.ContainsKey(typeof(IDependencyContainer)));
        }

        [TestMethod]
        public void Register_ObjectTest()
        {
            //Arrange
            Container.Register(_ => GetType());

            //Act
            var result = Container.Resolve<Type>();

            //Assert
            Assert.AreEqual(GetType().Name, result.Name);
        }

        [TestMethod]
        public void Register_ObjectAsIntefaceTest()
        {
            //Arrange
            Container.Register<IReflect>(_ => GetType());

            //Act
            var result = Container.Resolve<IReflect>();

            //Assert
            Assert.AreEqual(GetType().UnderlyingSystemType, result.UnderlyingSystemType);
        }

        [TestMethod]
        public void Register_SingletonTest()
        {
            //Arrange
            var guid = Guid.NewGuid();
            Container.Register(_ => guid);

            //Act
            var result1 = Container.Resolve<Guid>();
            var result2 = Container.Resolve<Guid>();

            //Assert
            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void Register_DoubleRegistrationTest()
        {
            //Arrange
            var guid = Guid.NewGuid();
            Container.Register(_ => guid);

            //Act
            var result = Assert.ThrowsException<DuplicateRegistrationException>(() => Container.Register(_ => guid));

            //Assert
            Assert.AreEqual("There is already a Registration for <System.Guid>", result.Message);
        }

        [TestMethod]
        public void Register_FluencyTest()
        {
            //Arrange
            var container = Container as DependencyContainer;
            var initialRegistrations = container.Registrations.Count;

            //Act
            Container
                .Register(_ => Guid.NewGuid())
                .Register(_ => new DependencyContainerTests());

            //Assert
            Assert.AreEqual(initialRegistrations + 2, container.Registrations.Count);
            Assert.IsTrue(container.Registrations.ContainsKey(typeof(Guid)));
            Assert.IsTrue(container.Registrations.ContainsKey(typeof(DependencyContainerTests)));
        }
        #endregion

        #region RegisterWeak
        [TestMethod]
        public void RegisterWeak_BasicTest()
        {
            //Arrange
            var container = Container as DependencyContainer;
            var initialRegistrations = container.Registrations.Count;

            //Act
            Container.RegisterWeak(_ => Guid.NewGuid());

            //Assert
            Assert.AreEqual(initialRegistrations + 1, container.Registrations.Count);
            Assert.IsTrue(container.Registrations.ContainsKey(typeof(Guid)));
        }

        [TestMethod]
        public void RegisterWeak_DoubleRegistrationTest()
        {
            //Arrange
            var container = Container as DependencyContainer;
            var initialRegistrations = container.Registrations.Count;

            //Act
            Container
                .RegisterWeak(_ => Guid.NewGuid())
                .RegisterWeak(_ => Guid.NewGuid());

            //Assert
            Assert.AreEqual(initialRegistrations + 1, container.Registrations.Count);
            Assert.IsTrue(container.Registrations.ContainsKey(typeof(Guid)));
        }
        #endregion

        #region RegisterStrong
        [TestMethod]
        public void RegisterStrong_BasicTest()
        {
            //Arrange
            var container = Container as DependencyContainer;
            var initialRegistrations = container.Registrations.Count;

            //Act
            Container.RegisterStrong(_ => Guid.NewGuid());

            //Assert
            Assert.AreEqual(initialRegistrations + 1, container.Registrations.Count);
            Assert.IsTrue(container.Registrations.ContainsKey(typeof(Guid)));
        }

        [TestMethod]
        public void RegisterStrong_DoubleRegistrationTest()
        {
            //Arrange
            var container = Container as DependencyContainer;
            var initialRegistrations = container.Registrations.Count;

            //Act
            Container
                .RegisterStrong(_ => Guid.NewGuid())
                .RegisterStrong(_ => Guid.NewGuid());

            //Assert
            Assert.AreEqual(initialRegistrations + 1, container.Registrations.Count);
            Assert.IsTrue(container.Registrations.ContainsKey(typeof(Guid)));
        }
        #endregion

        #region Resolve
        [TestMethod]
        public void Resolve_SelfTest()
        {
            //Act
            var result = Container.Resolve<IDependencyContainer>();

            //Assert
            Assert.AreEqual(Container, result);
        }

        [TestMethod]
        public void Resolve_BasicTest()
        {
            //Arrange
            Container.Register(_ => Guid.NewGuid());

            //Act
            var result = Container.Resolve<Guid>();

            //Assert
            Assert.AreNotEqual(default, result);
            Assert.AreEqual(typeof(Guid), result.GetType());
        }

        [TestMethod]
        public void Resolve_StaticTest()
        {
            //Arrange
            var guid = Guid.NewGuid();
            Container.Register(_ => guid);

            //Act
            var result = Container.Resolve<Guid>();

            //Assert
            Assert.AreEqual(guid, result);
        }

        [TestMethod]
        public void Resolve_DynamicTest()
        {
            //Arrange
            Container.Register(_ => Guid.NewGuid());

            //Act
            var result1 = Container.Resolve<Guid>();
            var result2 = Container.Resolve<Guid>();

            //Assert
            Assert.AreNotEqual(result1, result2);
        }

        [TestMethod]
        public void Resolve_NothingRegisteredTest()
        {
            //Act
            var result = Assert.ThrowsException<MissingRegistrationException>(() => Container.Resolve<Guid>());

            //Assert
            Assert.AreEqual("Nothing registered for <System.Guid>", result.Message);
        }

        [TestMethod]
        public void Resolve_InternalResolveTest()
        {
            //Arrange
            var expectedMessage = "Test";
            Container
                .Register(_ => expectedMessage)
                .Register(_ => new Exception(_.Resolve<string>()));

            //Act
            var result = Container.Resolve<Exception>();

            //Assert
            Assert.AreEqual(expectedMessage, result.Message);
        }
        #endregion

        #region TryResolve
        [TestMethod]
        public void TryResolve_NothingRegisteredTest()
        {
            //Act
            var result = Container.TryResolve(out Guid id);

            //Assert
            Assert.IsFalse(result);
            Assert.AreEqual(default, id);
        }

        [TestMethod]
        public void TryResolve_BasicTest()
        {
            //Arrange
            var expectedId = Guid.NewGuid();
            Container.Register(_ => expectedId);

            //Act
            var result = Container.TryResolve(out Guid id);

            //Assert
            Assert.IsTrue(result);
            Assert.AreEqual(expectedId, id);
        }
        #endregion

        #region ParentChild
        [TestMethod]
        public void ParentChild_Resolve_ParentTest()
        {
            //Arrange
            ParentContainer.Register(_ => Guid.NewGuid());

            //Act
            var result = ChildContainer.Resolve<Guid>();

            //Assert
            Assert.AreNotEqual(default, result);
            Assert.AreEqual(typeof(Guid), result.GetType());
        }

        [TestMethod]
        public void ParentChild_Resolve_ChildTest()
        {
            //Arrange
            var parentGuid = Guid.NewGuid();
            var childGuid = Guid.NewGuid();
            ParentContainer.Register(_ => parentGuid);
            ChildContainer.Register(_ => childGuid);

            //Act
            var result = ChildContainer.Resolve<Guid>();

            //Assert
            Assert.AreNotEqual(parentGuid, result);
            Assert.AreEqual(childGuid, result);
        }
        #endregion

        #region DeepHierachy
        [TestMethod]
        public void DeepHierachy_Resolve_ParentTest()
        {
            //Arrange
            var parentGuid = Guid.NewGuid();
            ParentContainer.Register(_ => parentGuid);
            var container = new DependencyContainer(ChildContainer);

            //Act
            var result = container.Resolve<Guid>();

            //Assert
            Assert.AreEqual(parentGuid, result);
        }
        #endregion
    }
}
