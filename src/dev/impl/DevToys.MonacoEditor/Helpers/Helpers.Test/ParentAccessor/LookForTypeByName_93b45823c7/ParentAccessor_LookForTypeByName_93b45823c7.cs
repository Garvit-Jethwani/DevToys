using NUnit.Framework;
using System;
using System.Reflection;

namespace DevToys.MonacoEditor.Helpers
{
    [TestFixture]
    public class TypeLookupTests
    {
        [Test]
        public void TestLookForTypeByName_LocalSearch_Success()
        {
            var typeLookup = new TypeLookup();
            var typeName = "System.String";

            var result = typeLookup.LookForTypeByName(typeName);

            Assert.IsNotNull(result, "Result should not be null");
            Assert.AreEqual(typeof(string), result, "Result should be of type string");
        }

        [Test]
        public void TestLookForTypeByName_LocalSearch_Failure()
        {
            var typeLookup = new TypeLookup();
            var typeName = "NonExistentType";

            var result = typeLookup.LookForTypeByName(typeName);

            Assert.IsNull(result, "Result should be null for non-existent type");
        }

        [Test]
        public void TestLookForTypeByName_AssemblySearch_Success()
        {
            var typeLookup = new TypeLookup();
            var typeName = "MyNamespace.MyClass";

            var result = typeLookup.LookForTypeByName(typeName);

            Assert.IsNotNull(result, "Result should not be null");
            Assert.AreEqual(typeof(MyNamespace.MyClass), result, "Result should be of type MyNamespace.MyClass");
        }

        [Test]
        public void TestLookForTypeByName_AssemblySearch_Failure()
        {
            var typeLookup = new TypeLookup();
            var typeName = "NonExistentType";

            var result = typeLookup.LookForTypeByName(typeName);

            Assert.IsNull(result, "Result should be null for non-existent type");
        }
    }

    public class TypeLookup
    {
        private Assembly[] assemblies = { typeof(string).Assembly };

        public Assembly[] Assemblies
        {
            get { return assemblies; }
            set { assemblies = value; }
        }

        public Type LookForTypeByName(string name)
        {
            var result = Type.GetType(name);

            if (result != null)
            {
                return result;
            }

            foreach (Assembly assembly in Assemblies)
            {
                foreach (Type typeInfo in assembly.ExportedTypes)
                {
                    if (typeInfo.Name == name)
                    {
                        return typeInfo;
                    }
                }
            }

            return null;
        }
    }
}
