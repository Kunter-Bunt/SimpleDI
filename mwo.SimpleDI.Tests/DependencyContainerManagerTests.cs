using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mwo.SimpleDI.Tests
{
    [TestClass]
    public class DependencyContainerManagerTests
    {
        [TestCleanup]
        public void Cleanup()
        {
            DependencyContainerManager.Reset();
        }

        #region Default
        [TestMethod]
        public void Default_CanRegisterTest()
        {
            //Act
            DependencyContainerManager.Default.Register(_ => Guid.NewGuid());

            //Assert
            Assert.IsTrue(DependencyContainerManager.Default.IsRegistered<Guid>());
            Assert.IsFalse(DependencyContainerManager.Default.IsRegistered<string>());
        }

        [TestMethod]
        public void Default_IsRootTest()
        {
            //Act
            var container = DependencyContainerManager.Default;

            //Assert
            Assert.IsNull(container.ParentContainer);
        }
        #endregion

        #region Unique
        [TestMethod]
        public void Unique_CanRegisterTest()
        {
            //Arrange
            var container = DependencyContainerManager.Unique;

            //Act
            container.Register(_ => Guid.NewGuid());

            //Assert
            Assert.IsTrue(container.IsRegistered<Guid>());
            Assert.IsFalse(container.IsRegistered<string>());
        }

        [TestMethod]
        public void Unique_DoesNotAffectDefaultTest()
        {
            //Arrange
            var container = DependencyContainerManager.Unique;

            //Act
            container.Register(_ => Guid.NewGuid());

            //Assert
            Assert.IsTrue(container.IsRegistered<Guid>());
            Assert.IsFalse(DependencyContainerManager.Default.IsRegistered<Guid>());
        }

        [TestMethod]
        public void Unique_IsUniqueTest()
        {
            //Act
            DependencyContainerManager.Unique.Register(_ => Guid.NewGuid());

            //Assert
            Assert.IsFalse(DependencyContainerManager.Unique.IsRegistered<Guid>());
        }

        [TestMethod]
        public void Unique_HasDefaultParentTest()
        {
            //Arrange
            var container = DependencyContainerManager.Unique;

            //Act
            DependencyContainerManager.Default.Register(_ => Guid.NewGuid());

            //Assert
            Assert.IsTrue(container.TryResolve(out Guid _));
            Assert.AreEqual(DependencyContainerManager.Default, container.ParentContainer);
        }
        #endregion

        #region GetOrCreate
        [TestMethod]
        public void GetOrCreate_CanRegisterTest()
        {
            //Arrange
            var container = DependencyContainerManager.GetOrCreate("Test");

            //Act
            container.Register(_ => Guid.NewGuid());

            //Assert
            Assert.IsTrue(container.IsRegistered<Guid>());
        }

        [TestMethod]
        public void GetOrCreate_HoldsReferenceTest()
        {
            //Arrange
            var name = "Test";

            //Act
            DependencyContainerManager.GetOrCreate(name);

            //Assert
            Assert.IsTrue(DependencyContainerManager.ManagedContainers.ContainsKey(name));
        }

        [TestMethod]
        public void GetOrCreate_GetReturnsSameTest()
        {
            //Arrange
            var name = "Test";
            var expectedContainer = DependencyContainerManager.GetOrCreate(name);

            //Act
            var actualContainer = DependencyContainerManager.GetOrCreate(name);

            //Assert
            Assert.AreEqual(expectedContainer, actualContainer);
        }


        [TestMethod]
        public void GetOrCreate_HasDefaultParentTest()
        {
            //Arrange
            var container = DependencyContainerManager.GetOrCreate("Test");

            //Act
            DependencyContainerManager.Default.Register(_ => Guid.NewGuid());

            //Assert
            Assert.IsTrue(container.TryResolve(out Guid _));
        }
        #endregion

        #region Reset
        [TestMethod]
        public void Reset_DefaultTest()
        {
            //Arrange
            DependencyContainerManager.Default.Register(_ => Guid.NewGuid());

            //Act
            DependencyContainerManager.Reset();

            //Assert
            Assert.IsFalse(DependencyContainerManager.Default.IsRegistered<Guid>());
        }

        [TestMethod]
        public void Reset_MangedContainersTest()
        {
            //Arrange
            var name = Guid.NewGuid().ToString();
            var container = DependencyContainerManager.GetOrCreate(name);
            Assert.IsTrue(DependencyContainerManager.ManagedContainers.ContainsKey(name));
            container.Register(_ => Guid.NewGuid());

            //Act
            DependencyContainerManager.Reset();

            //Assert
            Assert.IsFalse(DependencyContainerManager.ManagedContainers.ContainsKey(name));
            Assert.IsTrue(container.TryResolve(out Guid _));
        }
        #endregion
    }
}
