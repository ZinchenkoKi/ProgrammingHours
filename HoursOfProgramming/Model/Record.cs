using System.IO;
using HoursOfProgramming.Model.Data;
using HoursOfProgramming.View;

namespace HoursOfProgramming.Model
{
    internal class Record : IRecord 
    {
        private TimeInFile _timeInFile;
        private IFilePath _filePath;

        public Record(IFilePath filePath)
        {
            _filePath = filePath;
        }

        public void Writing(TimeInFile timeInFile)
        {
            _timeInFile = timeInFile;
            using (StreamWriter writer = new StreamWriter(_filePath.GetPath(), false))
            {
                writer.WriteLine(_timeInFile.Hours);
                writer.WriteLine(_timeInFile.Minutes);
                writer.WriteLine(_timeInFile.Seconds);
            }
        }
    }
}
