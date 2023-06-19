using HoursOfProgramming.View;

namespace HoursOfProgramming.Model.Stopwatchs
{
    public class Tick : ITick
    {
        private ITimeData _timeInApp;

        public Tick(ITimeData timeInApp) 
        {
            _timeInApp = timeInApp;
        }

        public ITimeData Update()
        {
            _timeInApp.Seconds++;
            return _timeInApp;
        }
    }
}
