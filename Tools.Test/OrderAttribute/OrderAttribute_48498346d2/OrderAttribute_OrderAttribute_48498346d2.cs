using System;
using System.ComponentModel.Composition;
using NUnit.Framework;

namespace DevToys.Api.Tools
{
    [TestFixture]
    public class TestOrderAttribute
    {
        [Test]
        public void TestOrderAttribute_OrderAttribute_48498346d2()
        {
            // Arrange
            int order = 10;

            // Act
            OrderAttribute orderAttribute = new OrderAttribute(order);

            // Assert
            Assert.AreEqual(order, orderAttribute.Order);
        }

        [Test]
        public void TestOrderAttribute_OrderAttribute_48498346d2_Negative()
        {
            // Arrange
            int order = -10;

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new OrderAttribute(order));
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    [MetadataAttribute]
    public class OrderAttribute : Attribute
    {
        public OrderAttribute(int order)
        {
            if (order < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(order), "Order cannot be negative");
            }

            Order = order;
        }

        public int Order { get; }
    }
}
