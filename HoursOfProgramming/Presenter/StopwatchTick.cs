using HoursOfProgramming.Model.Data;
using HoursOfProgramming.Model.Stopwatchs;

namespace HoursOfProgramming.Presenter
{
    /// <summary>
    /// Запускает секундомер
    /// </summary>
    public class StopwatchTick
    {
        private TimeInApp _timeInApp;

        public StopwatchTick(TimeInApp timeInApp) 
        {
            _timeInApp = timeInApp;
        }

        public TimeInApp Update()
        {
            var tick = new Tick(_timeInApp);
            _timeInApp = tick.Update();
            return _timeInApp;
        }
    }
}
