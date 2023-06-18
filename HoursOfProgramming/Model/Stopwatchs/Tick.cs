using HoursOfProgramming.Model.Data;
using HoursOfProgramming.View;

namespace HoursOfProgramming.Model.Stopwatchs
{
    public class Tick : ITick
    {
        private TimeInApp _timeInApp;

        public Tick(TimeInApp timeInApp) 
        {
            _timeInApp = timeInApp;
        }

        public TimeInApp Update()
        {
            _timeInApp.Seconds++;
            return _timeInApp;
        }
    }
}
