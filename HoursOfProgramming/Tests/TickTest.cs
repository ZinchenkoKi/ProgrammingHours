using HoursOfProgramming.Model.Data;
using HoursOfProgramming.Model.Stopwatchs;
using HoursOfProgramming.View;
using NUnit.Framework;

namespace HoursOfProgramming.Tests
{
    [TestFixture]
    public class TickTest
    {
        [Test]
        public void TickInclude()
        {
            ITimeData time = new TimeInApp();
            time.Seconds = 10;

            var tick = new Tick(time);
            time = tick.Update();

            Assert.AreEqual(11, time.Seconds);
        }


        [Test]
        public void TickIncludeThirty()
        {
            ITimeData time = new TimeInApp();
            time.Seconds = 10;
            var tick = new Tick(time);

            for (int i = 0; i < 30; i++)
            {
                time = tick.Update();
            }

            Assert.AreEqual(40, time.Seconds);
        }
    }
}
