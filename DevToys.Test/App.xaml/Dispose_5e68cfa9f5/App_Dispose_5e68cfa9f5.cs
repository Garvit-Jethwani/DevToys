// Test generated by RoostGPT for test Csharp-dev-toys using AI Type Open AI and AI Model gpt-3.5-turbo-0301

using NUnit.Framework;
using DevToys;

namespace DevToys.Tests
{
    [TestFixture]
    public class DisposeTests
    {
        [Test]
        public void TestApp_Dispose_5e68cfa9f5()
        {
            // Arrange
            var app = new DevToys.App();

            // Act
            app.Dispose(true);

            // Assert
            Assert.IsTrue(app._isDisposed);
        }

        [Test]
        public void TestApp_Dispose_5e68cfa9f6()
        {
            // Arrange
            var app = new DevToys.App();

            // Act
            app.Dispose(false);

            // Assert
            Assert.IsFalse(app._isDisposed);
        }
    }
}
