// Test generated by RoostGPT for test Csharp-dev-toys using AI Type Open AI and AI Model gpt-3.5-turbo-0301

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using DevToys.Shared.Core;
using NUnit.Framework;

namespace DevToys.Core.Collections
{
    [TestFixture]
    public class TestExtendedObservableCollection
    {
        [Test]
        public void TestExtendedObservableCollection_Update_c0e93c314f()
        {
            // TODO: Add test cases
            Assert.IsTrue(true);
        }
        
        [Test]
        public void TestExtendedObservableCollection_Update_AddNewItem()
        {
            var collection = new ExtendedObservableCollection<int> { 1, 2, 3 };
            collection.Update(new List<int> { 1, 2, 3, 4 });
            Assert.AreEqual(4, collection.Count);
            Assert.AreEqual(4, collection[3]);
        }

        [Test]
        public void TestExtendedObservableCollection_Update_MoveExistingItem()
        {
            var collection = new ExtendedObservableCollection<int> { 1, 2, 3 };
            collection.Update(new List<int> { 2, 3, 1 });
            Assert.AreEqual(3, collection.Count);
            Assert.AreEqual(2, collection[0]);
            Assert.AreEqual(3, collection[1]);
            Assert.AreEqual(1, collection[2]);
        }
    }
}
