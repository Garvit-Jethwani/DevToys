using NUnit.Framework;
using DevToys.Api.Core;
using System;

namespace DevToys.Api.Core.Tests
{
    [TestFixture]
    public class InAppNotificationAddedEventArgsTests
    {
        [Test]
        public void TestInAppNotificationAddedEventArgs_InAppNotificationAddedEventArgs_131676a13f()
        {
            // Test case 1: Valid input
            string title = "Test Title";
            string message = "Test Message";
            string actionableLinkText = "Test Link Text";
            Action action = () => { };
            InAppNotificationAddedEventArgs args = new InAppNotificationAddedEventArgs(title, message, actionableLinkText, action);
            Assert.AreEqual(title, args.Title);
            Assert.AreEqual(message, args.Message);
            Assert.AreEqual(actionableLinkText, args.ActionableLinkText);
            Assert.AreEqual(action, args.Action);

            // Test case 2: Invalid input (null actionableLinkText and non-null action)
            title = "Test Title";
            message = "Test Message";
            actionableLinkText = null;
            action = () => { };
            Assert.Throws<ArgumentException>(() => new InAppNotificationAddedEventArgs(title, message, actionableLinkText, action));
        }
    }
}
