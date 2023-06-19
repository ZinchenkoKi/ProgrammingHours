using HoursOfProgramming.View;
using HoursOfProgramming.Model.Stopwatchs;

namespace HoursOfProgramming.Presenter
{
    /// <summary>
    /// Меняет текст кнопки и включает таймер
    /// </summary>
    internal class StopwatchOn
    {
        private IStopwatch _stopwatch;

        public StopwatchOn(IStopwatch stopwatch)
        {
            _stopwatch = stopwatch;
        }

        public IStopwatch Start()
        {
            var stopwatch = new Stopwatch(_stopwatch);
            return stopwatch.Start();
        }
    }
}
