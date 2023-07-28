using DevToys.Api.Core.Settings;
using NUnit.Framework;

namespace DevToys.Api.Core.Settings.Test
{
    [TestFixture]
    public class SettingDefinitionTest
    {
        [Test]
        public void TestSettingDefinitionWithValidName()
        {
            // Arrange
            string name = "validName";
            bool isRoaming = true;
            int defaultValue = 5;

            // Act
            SettingDefinition<int> settingDefinition = new SettingDefinition<int>(name, isRoaming, defaultValue);

            // Assert
            Assert.AreEqual(name, settingDefinition.Name);
            Assert.AreEqual(isRoaming, settingDefinition.IsRoaming);
            Assert.AreEqual(defaultValue, settingDefinition.DefaultValue);
        }

        [Test]
        public void TestSettingDefinitionWithInvalidName()
        {
            // Arrange
            string name = "invalidNameWithLengthGreaterThan255";
            bool isRoaming = true;
            int defaultValue = 5;

            // Act
            TestDelegate testDelegate = () => new SettingDefinition<int>(name, isRoaming, defaultValue);

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(testDelegate);
        }
    }
}
