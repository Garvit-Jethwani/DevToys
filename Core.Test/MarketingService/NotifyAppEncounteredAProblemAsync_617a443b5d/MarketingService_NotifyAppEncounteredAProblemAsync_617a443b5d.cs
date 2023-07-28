using DevToys.Core;
using NUnit.Framework;
using System;

namespace DevToys.Core.Tests
{
    [TestFixture]
    public class TestMarketingService
    {
        [Test]
        public async Task TestMarketingService_NotifyAppEncounteredAProblemAsync_617a443b5d()
        {
            //Arrange
            var marketingService = new MarketingService(); // TODO: Change this to your actual class name
            var expectedLastProblemEncounteredDate = DateTime.Now;
            var expectedStartSinceLastProblemEncounteredCount = 0;

            //Act
            await marketingService.NotifyAppEncounteredAProblemAsync();

            //Assert
            var actualMarketingState = marketingService.GetMarketingState();
            Assert.AreEqual(expectedLastProblemEncounteredDate, actualMarketingState.LastProblemEncounteredDate);
            Assert.AreEqual(expectedStartSinceLastProblemEncounteredCount, actualMarketingState.StartSinceLastProblemEncounteredCount);
        }

        [Test]
        public async Task TestMarketingService_NotifyAppEncounteredAProblemAsync_WhenMarketingStateIsNull()
        {
            //Arrange
            var marketingService = new MarketingService(); // TODO: Change this to your actual class name
            var expectedLastProblemEncounteredDate = DateTime.Now;
            var expectedStartSinceLastProblemEncounteredCount = 0;

            //Act
            await marketingService.NotifyAppEncounteredAProblemAsync();

            //Assert
            var actualMarketingState = marketingService.GetMarketingState();
            Assert.IsNotNull(actualMarketingState);
            Assert.AreEqual(expectedLastProblemEncounteredDate, actualMarketingState.LastProblemEncounteredDate);
            Assert.AreEqual(expectedStartSinceLastProblemEncounteredCount, actualMarketingState.StartSinceLastProblemEncounteredCount);
        }
    }
}
