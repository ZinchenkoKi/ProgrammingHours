using HoursOfProgramming.Model.Data;
using HoursOfProgramming.Model.Stopwatchs;
using HoursOfProgramming.View;
using NUnit.Framework;

namespace HoursOfProgramming.Tests
{
    [TestFixture]
    public class StopwatchTest
    {
        [Test]
        public void StopwatchStart()
        {
            IStopwatch state = new StopwatchState();
            state.Start = "START";

            var stopwatch = new Stopwatch(state);
            state = stopwatch.Start();

            Assert.AreEqual("STOP", state.Start);
        }

        [Test]
        public void StopwatchStop()
        {
            IStopwatch state = new StopwatchState();
            state.Start = "STOP";

            var stopwatch = new Stopwatch(state);
            state = stopwatch.Start();

            Assert.AreEqual("START", state.Start);
        }

        [Test]
        public void StopwatchTrue()
        {
            IStopwatch state = new StopwatchState();
            string word = "STOP";

            var stopwatch = new Stopwatch(state);

            Assert.AreEqual(false, stopwatch.IsActive(word));
        }

        [Test]
        public void StopwatchFalse()
        {
            IStopwatch state = new StopwatchState();
            string word = "START";

            var stopwatch = new Stopwatch(state);

            Assert.AreEqual(true, stopwatch.IsActive(word));
        }
    }
}
