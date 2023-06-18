using HoursOfProgramming.Model.Data;
using HoursOfProgramming.View;
using System;
using System.IO;

namespace HoursOfProgramming.Model
{
    public class Read : IRead
    {
        private TimeInFile _timeInFile;
        private IFilePath _filePath;
        private string _path;

        public Read(IFilePath filePath)
        {
            _timeInFile = new TimeInFile();
            _filePath = filePath;
            _path = GetPath();
        }

        public TimeInFile Reading()
        {
            using (StreamReader reader = new StreamReader(_path))
            {
                _timeInFile.Hours = Convert.ToInt32(reader.ReadLine());
                _timeInFile.Minutes = Convert.ToInt32(reader.ReadLine());
                _timeInFile.Seconds = Convert.ToInt32(reader.ReadLine());
            }
            return _timeInFile;
        }

        private string GetPath()
        {
            return _filePath.GetPath();
        }
    }
}
