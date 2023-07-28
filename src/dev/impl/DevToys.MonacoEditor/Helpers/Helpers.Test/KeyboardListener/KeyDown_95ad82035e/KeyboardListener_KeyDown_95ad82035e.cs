using NUnit.Framework;
using DevToys.MonacoEditor.Helpers;

namespace DevToys.MonacoEditor.Test
{
    public class KeyDownTests
    {
        private CodeEditorCore codeEditor;

        [SetUp]
        public void Setup()
        {
            codeEditor = new CodeEditorCore();
        }

        [Test]
        public void TestKeyDown_Success()
        {
            // Arrange
            int keyCode = 65; // 'A' key
            bool ctrl = false;
            bool shift = false;
            bool alt = false;
            bool meta = false;

            // Act
            bool result = codeEditor.KeyDown(keyCode, ctrl, shift, alt, meta);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void TestKeyDown_Failure()
        {
            // Arrange
            int keyCode = 123; // Invalid key code
            bool ctrl = false;
            bool shift = false;
            bool alt = false;
            bool meta = false;

            // Act
            bool result = codeEditor.KeyDown(keyCode, ctrl, shift, alt, meta);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
