using NUnit.Framework;
using DevToys.Core;
using System.Threading.Tasks;

namespace DevToys.Core.Tests
{
    public class AssetsHelperTests
    {
        [Test]
        public async Task TestAssetsHelper_GetReleaseNoteAsync_f142a22916()
        {
            // TODO: Change the file path to a valid path for your system
            string filePath = "C:\\Users\\User\\Documents\\ReleaseNote.txt";

            // Test case 1: Valid file path
            string expectedOutput = "This is the release note.";
            string actualOutput = await AssetsHelper.GetReleaseNoteAsync(filePath);
            Assert.AreEqual(expectedOutput, actualOutput);

            // Test case 2: Invalid file path
            filePath = "C:\\Users\\User\\Documents\\InvalidPath.txt";
            expectedOutput = null;
            actualOutput = await AssetsHelper.GetReleaseNoteAsync(filePath);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
