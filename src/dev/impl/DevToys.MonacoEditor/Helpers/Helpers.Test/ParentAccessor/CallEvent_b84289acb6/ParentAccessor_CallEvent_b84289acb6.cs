using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace DevToys.MonacoEditor.Helpers
{
    public class TestClass
    {
        Dictionary<string, Func<string[], string?>> events = new Dictionary<string, Func<string[], string?>>();

        public IAsyncOperation<string?>? CallEvent(string name, [ReadOnlyArray] string[] parameters)
        {
            if (events is not null && events.ContainsKey(name))
            {
                return events[name]?.Invoke(parameters).AsAsyncOperation();
            }

            return new Task<string?>(() => { return null; }).AsAsyncOperation();
        }

        [Test]
        public void TestCallEvent_WithValidName_ShouldReturnValidValue()
        {
            // Arrange
            string expected = "Hello World";
            events.Add("EventA", (parameters) => { return expected; });

            // Act
            IAsyncOperation<string?>? result = CallEvent("EventA", new string[] { "param1" });

            // Assert
            Assert.AreEqual(expected, result.GetResults());
        }

        [Test]
        public void TestCallEvent_WithInvalidName_ShouldReturnNull()
        {
            // Arrange
            events.Add("EventA", (parameters) => { return "Hello World"; });

            // Act
            IAsyncOperation<string?>? result = CallEvent("EventB", new string[] { "param1" });

            // Assert
            Assert.AreEqual(null, result.GetResults());
        }
    }
}
