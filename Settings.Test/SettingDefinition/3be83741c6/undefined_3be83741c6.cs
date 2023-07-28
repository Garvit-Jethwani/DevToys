using NUnit.Framework;
using DevToys.Api.Core.Settings;

namespace DevToys.Api.Core.Settings.Tests
{
    [TestFixture]
    public class SettingDefinitionTests
    {
        [Test]
        public void TestOperatorNotEqual_BothNull_ReturnsFalse()
        {
            SettingDefinition<int> left = null;
            SettingDefinition<int> right = null;

            Assert.IsFalse(left != right);
        }

        [Test]
        public void TestOperatorNotEqual_LeftNull_ReturnsTrue()
        {
            SettingDefinition<int> left = null;
            SettingDefinition<int> right = new SettingDefinition<int>("test", 1);

            Assert.IsTrue(left != right);
        }

        [Test]
        public void TestOperatorNotEqual_RightNull_ReturnsTrue()
        {
            SettingDefinition<int> left = new SettingDefinition<int>("test", 1);
            SettingDefinition<int> right = null;

            Assert.IsTrue(left != right);
        }

        [Test]
        public void TestOperatorNotEqual_BothEqual_ReturnsFalse()
        {
            SettingDefinition<int> left = new SettingDefinition<int>("test", 1);
            SettingDefinition<int> right = new SettingDefinition<int>("test", 1);

            Assert.IsFalse(left != right);
        }

        [Test]
        public void TestOperatorNotEqual_BothNotEqual_ReturnsTrue()
        {
            SettingDefinition<int> left = new SettingDefinition<int>("test1", 1);
            SettingDefinition<int> right = new SettingDefinition<int>("test2", 2);

            Assert.IsTrue(left != right);
        }
    }
}
