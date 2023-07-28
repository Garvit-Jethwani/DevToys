using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DevToys.MonacoEditor.Helpers
{
    public class RegisterActionTests
    {
        [Test]
        public void Test_RegisterAction_ValidNameAndAction()
        {
            // Arrange
            RegisterAction registerAction = new RegisterAction();
            string validName = "ValidAction";
            bool actionExecuted = false;

            // Act
            registerAction.RegisterAction(validName, () => actionExecuted = true);

            // Assert
            Assert.IsTrue(registerAction.Actions.ContainsKey(validName));
            Assert.IsTrue(actionExecuted);
        }

        [Test]
        public void Test_RegisterAction_NullActions()
        {
            // Arrange
            RegisterAction registerAction = new RegisterAction();
            string invalidName = "InvalidAction";

            // Act and Assert
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() => registerAction.RegisterAction(invalidName, null));
            Assert.AreEqual("Value cannot be null. (Parameter 'action')", exception.Message);
        }
    }

    internal class RegisterAction
    {
        public Dictionary<string, Action> Actions { get; } = new Dictionary<string, Action>();

        internal void RegisterAction(string name, Action action)
        {
            if (Actions is null)
            {
                throw new NullReferenceException();
            }

            Actions[name] = action;
        }
    }
}
