using System;
using NUnit.Framework;

namespace DevToys.MonacoEditor.Helpers
{
    [TestFixture]
    public class ThemeListenerTests
    {
        private ThemeListener _themeListener;

        [SetUp]
        public void SetUp()
        {
            _themeListener = new ThemeListener();
        }

        [Test]
        public void TestThemeListener_UpdateProperties_LightHighContrastScheme()
        {
            // Arrange
            // TODO: Set up a scenario where HighContrastScheme is ON and lighter than "white"

            // Act
            _themeListener.UpdateProperties();

            // Assert
            Assert.IsFalse(_themeListener.IsHighContrast);
            Assert.AreEqual(ApplicationTheme.Light, _themeListener.CurrentTheme);
            // TODO: Assert other properties
        }

        [Test]
        public void TestThemeListener_UpdateProperties_DarkTheme()
        {
            // Arrange
            // TODO: Set up a scenario where HighContrastScheme is OFF and system theme is dark

            // Act
            _themeListener.UpdateProperties();

            // Assert
            Assert.AreEqual(ApplicationTheme.Dark, _themeListener.CurrentTheme);
            // TODO: Assert other properties
        }
    }
}
