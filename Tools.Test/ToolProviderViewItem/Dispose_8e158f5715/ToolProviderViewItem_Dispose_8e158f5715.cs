// Test generated by RoostGPT for test Csharp-dev-toys using AI Type Open AI and AI Model gpt-3.5-turbo-0301

using NUnit.Framework;
using DevToys.Api.Tools;

namespace DevToys.Api.Tools
{
    [TestFixture]
    public class ToolProviderViewItemTests
    {
        private ToolProviderViewItem _toolProviderViewItem;

        [SetUp]
        public void SetUp()
        {
            _toolProviderViewItem = new ToolProviderViewItem();
        }

        [Test]
        public void TestToolProviderViewItem_Dispose_8e158f5715()
        {
            // TODO: Change the value to true to test if _isBeingProgrammaticallySelected is set to false on Dispose()
            _toolProviderViewItem._isBeingProgrammaticallySelected = true;
            _toolProviderViewItem.Dispose();
            Assert.IsFalse(_toolProviderViewItem._isBeingProgrammaticallySelected);
        }

        [Test]
        public void TestToolProviderViewItem_Dispose_8e158f5715_Null()
        {
            // TODO: Change the value to null to test if Dispose() works with null _toolProviderViewItem
            _toolProviderViewItem = null;
            _toolProviderViewItem.Dispose();
            Assert.IsNull(_toolProviderViewItem);
        }
    }
}