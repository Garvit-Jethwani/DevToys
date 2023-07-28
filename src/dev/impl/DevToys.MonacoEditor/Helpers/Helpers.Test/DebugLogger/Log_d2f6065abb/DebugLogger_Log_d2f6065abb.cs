using NUnit.Framework;
using System.Diagnostics;

namespace DevToys.MonacoEditor.Helpers
{
    [TestFixture]
    public class DebugLoggerTests
    {
        [Test]
        public void TestDebugLogger_Log_Success()
        {
            // Arrange
            DebugLogger debugLogger = new DebugLogger();
            string message = "Test message";

            // Act
            debugLogger.Log(message);

            // Assert
            // TODO: Add assertion to verify the expected output matches the actual output
        }

        [Test]
        public void TestDebugLogger_Log_DebugDisabled()
        {
            // Arrange
            DebugLogger debugLogger = new DebugLogger();
            string message = "Test message";

            // Act
            debugLogger.Log(message);

            // Assert
            // TODO: Add assertion to verify the expected output matches the actual output
        }
    }

    public class DebugLogger
    {
        public void Log(string message)
        {
#if DEBUG
            Debug.WriteLine(message);
#endif
        }
    }
}
