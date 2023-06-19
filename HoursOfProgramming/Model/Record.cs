using System.IO;
using HoursOfProgramming.View;

namespace HoursOfProgramming.Model
{
    /// <summary>
    /// Записывает данне в файл
    /// </summary>
    public class Record : IRecord 
    {
        private IFilePath _filePath;

        public Record(IFilePath filePath)
        {
            _filePath = filePath;
        }

        public void Writing(ITimeData timeInFile)
        {
            using (StreamWriter writer = new StreamWriter(_filePath.GetPath(), false))
            {
                writer.WriteLine(timeInFile.Hours);
                writer.WriteLine(timeInFile.Minutes);
                writer.WriteLine(timeInFile.Seconds);
            }
        }
    }
}
