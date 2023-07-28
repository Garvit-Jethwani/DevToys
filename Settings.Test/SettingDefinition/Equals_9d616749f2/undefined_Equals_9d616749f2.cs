using NUnit.Framework;
using DevToys.Api.Core.Settings;

namespace DevToys.Api.Core.Settings.Tests
{
    public class SettingDefinitionTests
    {
        [Test]
        public void TestEquals_ReturnsTrue()
        {
            // Arrange
            var setting1 = new SettingDefinition<string>("TestSetting", "TestValue", true);
            var setting2 = new SettingDefinition<string>("TestSetting", "TestValue", true);

            // Act
            var result = setting1.Equals(setting2);

            // Assert
            Assert.True(result);
        }

        [Test]
        public void TestEquals_ReturnsFalse()
        {
            // Arrange
            var setting1 = new SettingDefinition<string>("TestSetting1", "TestValue1", true);
            var setting2 = new SettingDefinition<string>("TestSetting2", "TestValue2", true);

            // Act
            var result = setting1.Equals(setting2);

            // Assert
            Assert.False(result);
        }
    }
}
