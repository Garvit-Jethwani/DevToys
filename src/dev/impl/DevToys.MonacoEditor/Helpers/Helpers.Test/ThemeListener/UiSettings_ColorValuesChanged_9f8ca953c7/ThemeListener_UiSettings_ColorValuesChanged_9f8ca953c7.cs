// Test generated by RoostGPT for test Csharp-dev-toys using AI Type Azure Open AI and AI Model roost-gpt

using NUnit.Framework;
using System;
using Windows.ApplicationModel.Core;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace DevToys.MonacoEditor.Helpers
{
    public class ThemeListenerTests
    {
        [Test]
        public void TestThemeListener_UiSettings_ColorValuesChanged_9f8ca953c7()
        {
            var uiSettings = new UISettings();
            bool isUpdatePropertiesCalled = false;

            ThemeListener themeListener = new ThemeListener();

            themeListener.ColorValuesChanged += (sender, args) =>
            {
                isUpdatePropertiesCalled = true;
            };

            uiSettings.ColorValuesChanged += themeListener.UiSettings_ColorValuesChanged;
            uiSettings.OnColorValuesChanged(null, null);

            Assert.IsTrue(isUpdatePropertiesCalled);
        }

        [Test]
        public void TestThemeListener_UiSettings_ColorValuesChanged_1acca72897()
        {
            var uiSettings = new UISettings();
            bool isUpdatePropertiesCalled = false;

            ThemeListener themeListener = new ThemeListener();

            themeListener.ColorValuesChanged += (sender, args) =>
            {
                isUpdatePropertiesCalled = true;
            };

            uiSettings.ColorValuesChanged += themeListener.UiSettings_ColorValuesChanged;
            uiSettings.OnColorValuesChanged(null, null);

            Assert.IsTrue(isUpdatePropertiesCalled);
        }
    }
}
