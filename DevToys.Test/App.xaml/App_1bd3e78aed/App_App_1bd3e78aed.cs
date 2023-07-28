using System.Threading.Tasks;
using NUnit.Framework;
using DevToys;
using DevToys.Shared;

namespace DevToys.Test
{
    [TestFixture]
    public class AppTest
    {
        private Task<MefComposer> _mefComposer;

        [Test]
        public void TestApp_App_1bd3e78aed()
        {
            // Test case 1
            LanguageManager.Instance.SetCurrentCulture(LanguageManager.Instance.AvailableLanguages[0]);
            Assert.AreEqual(LanguageManager.Instance.AvailableLanguages[0], LanguageManager.Instance.CurrentCulture);

            // Test case 2
            _mefComposer = Task.Run(() =>
            {
                return new MefComposer(
                    typeof(App).Assembly,
                    typeof(Constants).Assembly);
            });
            Assert.IsNotNull(_mefComposer.Result);
        }
    }
}
