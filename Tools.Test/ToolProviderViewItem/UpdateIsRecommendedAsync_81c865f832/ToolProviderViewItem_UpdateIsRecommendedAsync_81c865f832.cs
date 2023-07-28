using NUnit.Framework;
using DevToys.Api.Tools;

namespace DevToys.Api.Tools.Test
{
    [TestFixture]
    public class TestToolProviderViewItem
    {
        [Test]
        public void TestToolProviderViewItem_UpdateIsRecommendedAsync_81c865f832_Success()
        {
            // TODO: Set up clipboard content
            string clipboardContent = "";

            // TODO: Set up expected value of IsRecommended
            bool expectedIsRecommended = true;

            // Call the method
            ToolProviderViewItem toolProviderViewItem = new ToolProviderViewItem();
            toolProviderViewItem.UpdateIsRecommendedAsync(clipboardContent).Wait();

            // Check if IsRecommended is set correctly
            Assert.AreEqual(expectedIsRecommended, toolProviderViewItem.IsRecommended);
        }

        [Test]
        public void TestToolProviderViewItem_UpdateIsRecommendedAsync_81c865f832_Failure()
        {
            // TODO: Set up clipboard content
            string clipboardContent = "";

            // TODO: Set up expected value of IsRecommended
            bool expectedIsRecommended = false;

            // Call the method
            ToolProviderViewItem toolProviderViewItem = new ToolProviderViewItem();
            toolProviderViewItem.UpdateIsRecommendedAsync(clipboardContent).Wait();

            // Check if IsRecommended is set correctly
            Assert.AreEqual(expectedIsRecommended, toolProviderViewItem.IsRecommended);
        }
    }
}
