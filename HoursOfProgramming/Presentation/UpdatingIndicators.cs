using HoursOfProgramming.DomainModel;

namespace HoursOfProgramming.Presentation
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
            if (IsDozens(_timeInApp.Seconds))
            {
                _timeInApp.Minutes++;
                _timeInApp.Seconds = 0;
            }
            if (IsDozens(_timeInApp.Minutes))
            {
                _timeInApp.Hours++;
                _timeInApp.Minutes = 0;
            }
            return _timeInApp;
        }

        private bool IsDozens(int values)
        {
            return values > 59;
        }
    }
}
