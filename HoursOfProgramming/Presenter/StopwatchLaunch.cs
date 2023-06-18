using HoursOfProgramming.Model.Data;
using HoursOfProgramming.View;

namespace HoursOfProgramming.Presenter
{
    public class StopwatchLaunch
    {
        private TimeInFile _timeInFile;
        private IRead _read;

        public StopwatchLaunch(IRead read)
        {
            _read = read;
            _timeInFile = new TimeInFile();
        }

        public string Start()
        {
            _timeInFile = GetFileData();
            return _timeInFile.Hours.ToString();
        }

        private TimeInFile GetFileData()
        {
            return _read.Reading();
        }
    }
}
