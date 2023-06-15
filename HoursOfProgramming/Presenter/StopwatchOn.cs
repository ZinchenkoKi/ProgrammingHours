using HoursOfProgramming.View;
using HoursOfProgramming.Model.Stopwatchs;

namespace HoursOfProgramming.Presenter
{
    internal class StopwatchOn
    {
        private IStopwatch _stopwatch;

        public StopwatchOn(IStopwatch stopwatch)
        {
            _stopwatch = stopwatch;
        }

        public StopwatchState Start()
        {
            var stopwatch = new Stopwatch();
            return stopwatch.Start(_stopwatch.Start,_stopwatch.TimerEnabled);
        }
    }
}
