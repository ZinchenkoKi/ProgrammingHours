using HoursOfProgramming.Model.Data;

namespace HoursOfProgramming.Model.Stopwatchs
{
    public class Tick
    {
        private TimeInApp _timeInApp;

        public Tick(TimeInApp timeInApp)
        {
            _timeInApp = timeInApp;
        }

        public TimeInApp Update()
        {
            _timeInApp.Seconds++;
            if (IsCorrect(_timeInApp.Seconds))
            {
                _timeInApp.Minutes++;
                _timeInApp.Seconds = 0;
            }
            if (IsCorrect(_timeInApp.Minutes))
            {
                _timeInApp.Hours++;
                _timeInApp.Minutes = 0;
            }
            return _timeInApp;
        }

        private bool IsCorrect(int values)
        {
            return values > 59;
        }
    }
}
