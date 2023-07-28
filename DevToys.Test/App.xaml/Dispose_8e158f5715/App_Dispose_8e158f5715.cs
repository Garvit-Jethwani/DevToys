// Test generated by RoostGPT for test Csharp-dev-toys using AI Type Open AI and AI Model gpt-3.5-turbo-0301

using NUnit.Framework;
using DevToys;

namespace DevToys.Tests
{
    [TestFixture]
    public class TestApp
    {
        [Test]
        public void TestApp_Dispose_8e158f5715()
        {
            App app = new App();
            app.Dispose();

            // Assert
            Assert.IsTrue(true);
        }

        [Test]
        public void TestApp_Dispose_Invalid()
        {
            App app = null;

            // Assert
            Assert.Throws<System.NullReferenceException>(() => app.Dispose());
        }
    }
}
