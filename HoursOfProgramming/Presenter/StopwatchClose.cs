using HoursOfProgramming.Model.Data;
using HoursOfProgramming.View;
using System.Windows.Forms;

namespace HoursOfProgramming.Presenter
{
    public class StopwatchClose
    {
        private ITimeData _timeInApp;
        private ITimeData _timeInFile;
        private IRead _read;
        private IRecord _record;

        public StopwatchClose(ITimeData timeInApp, IRead read, IRecord record)
        {
            _read = read;
            _timeInFile = new TimeInFile();
            _timeInApp = timeInApp;
            _record = record;
        }

        public void Close(IRecount _recount)
        {
            _timeInFile = GetFileData();
            _timeInFile = _recount.Recalculate(_timeInApp, _timeInFile);
            _record.Writing(_timeInFile);
            Application.Exit();
        }

        private TimeInFile GetFileData()
        {
            return _read.Reading();
        }
    }
}
