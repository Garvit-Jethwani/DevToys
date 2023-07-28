using NUnit.Framework;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using DevToys.Core;
using DevToys.Shared;

namespace DevToys.Core.Test.AssetsHelper
{
    [TestFixture]
    public class AssetsHelperTests
    {
        [Test]
        public async Task TestAssetsHelper_GetLicenseAsync_042b11f4ea()
        {
            // TODO: Change the expected value as per the LICENSE.md content
            string expected = "This is a sample license file content";
            string actual = await AssetsHelper.GetLicenseAsync();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public async Task TestAssetsHelper_GetLicenseAsync_InvalidFilePath()
        {
            // TODO: Change the invalid file path as per the actual file path
            string invalidFilePath = "Assets\\InvalidFile.txt";
            string actual = await AssetsHelper.GetLocalFileContentAsync(invalidFilePath);

            Assert.IsNull(actual);
        }
    }
}
