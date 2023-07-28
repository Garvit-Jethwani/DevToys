// Test generated by RoostGPT for test Csharp-dev-toys using AI Type Azure Open AI and AI Model roost-gpt

using NUnit.Framework;
using System;
using System.Windows.Media;

namespace DevToys.MonacoEditor.Helpers
{
    [TestFixture]
    public class ColorHelperTests
    {
        [Test]
        public void TestToHtmlHex_White()
        {
            // Arrange
            Color color = Colors.White;

            // Act
            string result = ColorHelper.ToHtmlHex(color);

            // Assert
            Assert.AreEqual("#FFFFFFFF", result);
        }

        [Test]
        public void TestToHtmlHex_Black()
        {
            // Arrange
            Color color = Colors.Black;

            // Act
            string result = ColorHelper.ToHtmlHex(color);

            // Assert
            Assert.AreEqual("#FF000000", result);
        }
    }
}
