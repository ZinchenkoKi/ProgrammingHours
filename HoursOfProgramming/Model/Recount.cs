using HoursOfProgramming.Model.Data;
using HoursOfProgramming.View;

namespace HoursOfProgramming.Model
{
    public class Recount : IRecount
    {
        private TimeInApp _timeInApp;
        private TimeInFile _timeInFile;
        private ICorrect _correct;

        public Recount(ICorrect correct)
        {
            _correct = correct;
        }

        public TimeInFile Recalculate(TimeInApp timeInApp, TimeInFile timeInFile)
        {
            _timeInFile = timeInFile;
            _timeInApp = timeInApp;
            _timeInFile = Sum();
            if (_correct.IsCorrect(_timeInFile.Seconds))
            {
                _timeInFile.Minutes += _timeInFile.Seconds / 60;
                _timeInFile.Seconds = _timeInFile.Seconds % 60;
            }
            else if (_correct.IsCorrect(_timeInFile.Minutes))
            {
                _timeInFile.Hours += _timeInFile.Minutes / 60;
                _timeInFile.Minutes = _timeInFile.Minutes % 60;
            }
            return _timeInFile;
        }

        private TimeInFile Sum()
        {
            _timeInFile.Seconds += _timeInApp.Seconds;
            _timeInFile.Minutes += _timeInApp.Minutes;
            _timeInFile.Hours += _timeInApp.Hours;
            return _timeInFile;
        }
    }
}
