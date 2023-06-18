using HoursOfProgramming.Model;
using HoursOfProgramming.Model.Data;
using HoursOfProgramming.View;
using System.Windows.Forms;

namespace HoursOfProgramming.Presenter
{
    public class StopwatchClose
    {
        private TimeInApp _timeInApp;
        private TimeInFile _timeInFile;
        private IRead _read;
        private IRecord _record;
        private IRecount _recount;

        public StopwatchClose(TimeInApp timeInApp, IRead read, IRecord record, IRecount recount)
        {
            _read = read;
            _timeInFile = new TimeInFile();
            _timeInApp = timeInApp;
            _record = record;
            _recount = recount;
        }

        public void Close()
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
