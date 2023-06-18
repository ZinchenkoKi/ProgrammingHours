using HoursOfProgramming.Model.Data;
using HoursOfProgramming.View;

namespace HoursOfProgramming.Presenter
{
    /// <summary>
    /// Запускает секундомер
    /// </summary>
    public class StopwatchTick
    {
        private TimeInApp _timeInApp;
        private ICorrect _correct;
        private ITick _tick;

        public StopwatchTick(ITick tick, ICorrect correct) 
        {
            _timeInApp = new TimeInApp();   
            _correct = correct;
            _tick = tick;
        }

        public TimeInApp Tick()
        {
            _timeInApp = _tick.Update();
            if (_correct.IsCorrect(_timeInApp.Seconds))
            {
                _timeInApp.Minutes++;
                _timeInApp.Seconds = 0;
            }
            if (_correct.IsCorrect(_timeInApp.Minutes))
            {
                _timeInApp.Hours++;
                _timeInApp.Minutes = 0;
            }
            return _timeInApp;
        }
    }
}
