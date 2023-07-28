using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using DevToys.Shared;

namespace DevToys.Core.Collections.Test
{
    [TestFixture]
    public class TestExtendedObservableCollection
    {
        [Test]
        public void TestExtendedObservableCollection_AddRange_977b2afdb9()
        {
            var collection = new ExtendedObservableCollection<int>();

            // Test case 1: Adding a valid collection of integers
            var inputCollection = new List<int> { 1, 2, 3 };
            collection.AddRange(inputCollection);
            Assert.AreEqual(inputCollection.Count, collection.Count);

            // Test case 2: Adding a null collection
            List<int> nullCollection = null;
            Assert.Throws<System.ArgumentNullException>(() => collection.AddRange(nullCollection));
        }
    }
}
