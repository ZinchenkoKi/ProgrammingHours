using System;
using System.IO;
using HoursOfProgramming.Model.Data;

namespace HoursOfProgramming.Model
{
    internal class DataTime
    {
        private TimeInFile _timeInFile;
        private TimeInApp _timeInApp;
        private string Path;

        public DataTime(TimeInFile timeInFile)
        {
            var path = new DataPath();
            Path = path.GetPath();
            _timeInFile = timeInFile;
        }

        public DataTime(TimeInFile timeInFile, TimeInApp timeInApp)
        {
            var path = new DataPath();
            Path = path.GetPath();
            _timeInFile = timeInFile;
            _timeInApp = timeInApp;
        }

        public TimeInFile Reading()
        {
            using (StreamReader reader = new StreamReader(Path))
            {
                _timeInFile.HoursInFile = Convert.ToInt32(reader.ReadLine());
                _timeInFile.MinutesInFile = Convert.ToInt32(reader.ReadLine());
                _timeInFile.SecondsInFile = Convert.ToInt32(reader.ReadLine());
            }
            return _timeInFile;
        }

        public TimeInFile Recalculating()
        {
            _timeInFile = Sum();
            if (_timeInFile.SecondsInFile > 59)
            {
                _timeInFile.MinutesInFile += _timeInFile.SecondsInFile / 60;
                _timeInFile.SecondsInFile = _timeInFile.SecondsInFile % 60;
            }
            else if (_timeInFile.MinutesInFile > 59)
            {
                _timeInFile.HoursInFile += _timeInFile.MinutesInFile / 60;
                _timeInFile.MinutesInFile = _timeInFile.MinutesInFile % 60;
            }
            return _timeInFile;
        }

        public void Writing()
        {
            using (StreamWriter writer = new StreamWriter(Path, false))
            {
                writer.WriteLine(_timeInFile.HoursInFile);
                writer.WriteLine(_timeInFile.MinutesInFile);
                writer.WriteLine(_timeInFile.SecondsInFile);
            }
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
