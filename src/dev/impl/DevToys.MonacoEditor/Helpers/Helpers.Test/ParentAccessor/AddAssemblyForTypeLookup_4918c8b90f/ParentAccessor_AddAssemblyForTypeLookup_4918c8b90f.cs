using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace DevToys.MonacoEditor.Helpers
{
    public class ParentAccessor
    {
        public List<Assembly> Assemblies { get; set; }

        internal void AddAssemblyForTypeLookup(Assembly assembly)
        {
            Assemblies.Add(assembly);
        }
    }

    [TestFixture]
    public class ParentAccessorTests
    {
        [Test]
        public void TestParentAccessor_AddAssemblyForTypeLookup_Success()
        {
            // Arrange
            var parentAccessor = new ParentAccessor();
            var assembly = Assembly.GetExecutingAssembly();

            // Act
            parentAccessor.AddAssemblyForTypeLookup(assembly);

            // Assert
            Assert.Contains(assembly, parentAccessor.Assemblies);
        }

        [Test]
        public void TestParentAccessor_AddAssemblyForTypeLookup_NullAssembly()
        {
            // Arrange
            var parentAccessor = new ParentAccessor();
            Assembly assembly = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => parentAccessor.AddAssemblyForTypeLookup(assembly));
        }
    }
}
