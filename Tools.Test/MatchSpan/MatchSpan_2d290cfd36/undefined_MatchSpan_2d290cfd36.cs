// Test generated by RoostGPT for test Csharp-dev-toys using AI Type Open AI and AI Model gpt-3.5-turbo-0301

using NUnit.Framework;
using DevToys.Api.Tools;

namespace DevToys.Api.Tools
{
    [TestFixture]
    public class MatchSpanTests
    {
        [Test]
        public void Testundefined_MatchSpan_2d290cfd36()
        {
            // Arrange
            int startPosition = 0;
            int length = 5;
            DevToys.Api.Tools.MatchSpan matchSpan = new DevToys.Api.Tools.MatchSpan(startPosition, length);

            // Act
            int actualStartPosition = matchSpan.StartPosition;
            int actualLength = matchSpan.Length;

            // Assert
            Assert.AreEqual(startPosition, actualStartPosition);
            Assert.AreEqual(length, actualLength);
        }

        [Test]
        public void Testundefined_MatchSpan_2d290cfd37()
        {
            // Arrange
            int startPosition = 5;
            int length = 0;
            DevToys.Api.Tools.MatchSpan matchSpan = new DevToys.Api.Tools.MatchSpan(startPosition, length);

            // Act
            int actualStartPosition = matchSpan.StartPosition;
            int actualLength = matchSpan.Length;

            // Assert
            Assert.AreEqual(startPosition, actualStartPosition);
            Assert.AreEqual(length, actualLength);
        }
    }
}