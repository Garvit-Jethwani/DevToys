using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DevToys.MonacoEditor.Helpers
{
    public class ActionManager
    {
        private Dictionary<string, Action> actions;

        public ActionManager(Dictionary<string, Action> actions)
        {
            this.actions = actions;
        }

        public bool CallAction(string name)
        {
            if (actions is not null && actions.ContainsKey(name))
            {
                actions[name]?.Invoke();
                return true;
            }

            return false;
        }
    }

    [TestFixture]
    public class ActionManagerTests
    {
        [Test]
        public void TestCallAction_WhenActionExists_ShouldInvokeActionAndReturnTrue()
        {
            // Arrange
            var actions = new Dictionary<string, Action>
            {
                { "action1", () => Console.WriteLine("Action 1 invoked") },
                { "action2", () => Console.WriteLine("Action 2 invoked") }
            };

            var actionManager = new ActionManager(actions);

            // Act
            var result = actionManager.CallAction("action1");

            // Assert
            Assert.True(result);
        }

        [Test]
        public void TestCallAction_WhenActionDoesNotExist_ShouldNotInvokeActionAndReturnFalse()
        {
            // Arrange
            var actions = new Dictionary<string, Action>
            {
                { "action1", () => Console.WriteLine("Action 1 invoked") },
                { "action2", () => Console.WriteLine("Action 2 invoked") }
            };

            var actionManager = new ActionManager(actions);

            // Act
            var result = actionManager.CallAction("action3");

            // Assert
            Assert.False(result);
        }
    }
}
