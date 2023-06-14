using System;
using System.IO;
using HoursOfProgramming.DomainModel;


namespace HoursOfProgramming.Presentation
{
    internal class Data
    {
        private TimeInFile _timeInFile;

        public Data(TimeInFile timeInFile)
        {
            _timeInFile = timeInFile;
        }


        public TimeInFile Reading(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                _timeInFile.HoursInFile = Convert.ToInt32(reader.ReadLine());
                _timeInFile.MinutesInFile = Convert.ToInt32(reader.ReadLine());
                _timeInFile.SecondsInFile = Convert.ToInt32(reader.ReadLine());
            }
            return _timeInFile;
        }

        public TimeInFile Recalculating()
        {
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

        public void Writing(string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(_timeInFile.HoursInFile);
                writer.WriteLine(_timeInFile.MinutesInFile);
                writer.WriteLine(_timeInFile.SecondsInFile);
            }
        }
    }
}
