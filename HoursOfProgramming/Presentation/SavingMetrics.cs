using HoursOfProgramming.DomainModel;

namespace HoursOfProgramming.Presentation
{

    public class SavingMetrics
    {
        private TimeInFile _timeInFile;
        private TimeInApp _timeInApp;

        public SavingMetrics(TimeInFile timeInFile, TimeInApp timeInApp)
        {
            _timeInFile = timeInFile;
            _timeInApp = timeInApp;
        }

        public void Save(string path)
        {
            var data = new Data(_timeInFile);
            _timeInFile = data.Reading(path);
            _timeInFile = Sum();
            _timeInFile = data.Recalculating();
            data.Writing(path);
        }

        private TimeInFile Sum()
        {
            _timeInFile.SecondsInFile += _timeInApp.Seconds;
            _timeInFile.MinutesInFile += _timeInApp.Minutes;
            _timeInFile.HoursInFile += _timeInApp.Hours;
            return _timeInFile;
        }
    }
}
