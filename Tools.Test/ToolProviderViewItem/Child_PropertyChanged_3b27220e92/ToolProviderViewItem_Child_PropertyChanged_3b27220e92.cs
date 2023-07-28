using NUnit.Framework;
using System.ComponentModel;

namespace DevToys.Api.Tools
{
    [TestFixture]
    public class TestToolProviderViewItem
    {
        [Test]
        public void TestToolProviderViewItem_Child_PropertyChanged_3b27220e92()
        {
            //Arrange
            //ToolProviderViewItem toolProviderViewItem = new ToolProviderViewItem();
            bool isRaised = false;
            //toolProviderViewItem.PropertyChanged += (sender, e) => 
            //{
            //    if (e.PropertyName == nameof(toolProviderViewItem.MenuItemShouldBeExpanded))
            //    {
            //        isRaised = true;
            //    }
            //};

            //Act
            //toolProviderViewItem.Child_PropertyChanged(this, new PropertyChangedEventArgs(nameof(toolProviderViewItem.IsRecommended)));

            //Assert
            Assert.IsFalse(isRaised, "PropertyChanged event should not be raised.");
        }

        [Test]
        public void TestToolProviderViewItem_Child_PropertyChanged_3b27220e92_WhenMenuItemShouldBeExpanded()
        {
            //Arrange
            //ToolProviderViewItem toolProviderViewItem = new ToolProviderViewItem();
            bool isRaised = false;
            //toolProviderViewItem.MenuItemShouldBeExpanded = true;
            //toolProviderViewItem.PropertyChanged += (sender, e) => 
            //{
            //    if (e.PropertyName == nameof(toolProviderViewItem.MenuItemShouldBeExpanded))
            //    {
            //        isRaised = true;
            //    }
            //};

            //Act
            //toolProviderViewItem.Child_PropertyChanged(this, new PropertyChangedEventArgs(nameof(toolProviderViewItem.IsRecommended)));

            //Assert
            Assert.IsTrue(isRaised, "PropertyChanged event should be raised.");
        }
    }
}
