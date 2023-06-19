using HoursOfProgramming.Model;
using NUnit.Framework;

namespace HoursOfProgramming.Tests
{
    [TestFixture]
    public class CorrectDataTest
    {
        [Test]
        public void CorrectDataThirtySeconds()
        {
            var correctData = new CorrectData();
            int time = 30;

            Assert.AreEqual(false, correctData.IsCorrect(time));
        }

        [Test]
        public void CorrectDataZeroSeconds()
        {
            var correctData = new CorrectData();
            int time = 0;

            Assert.AreEqual(false, correctData.IsCorrect(time));
        }

        [Test]
        public void CorrectDataSeventySeconds()
        {
            var correctData = new CorrectData();
            int time = 70;

            Assert.AreEqual(true, correctData.IsCorrect(time));
        }
    }
}
