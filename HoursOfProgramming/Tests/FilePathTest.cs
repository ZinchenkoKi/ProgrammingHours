using HoursOfProgramming.Model;
using NUnit.Framework;

namespace HoursOfProgramming.Tests
{
    [TestFixture]
    public class FilePathTest
    {
        [Test]
        public void GetPath()
        {
            var filePath = new FilePath();
            string path = filePath.GetPath();
            string realPath = "C:\\Users\\zinch\\OneDrive\\Документы\\StopwatchData.txt";

            Assert.AreEqual(realPath, path);
        }
    }
}
