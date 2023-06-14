using System.IO;
using HoursOfProgramming.TimerData;

namespace HoursOfProgramming.ChangingFile
{
    public class WritingFile
    {
        public void Writing(TimeInFile timeInFile, string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(timeInFile.HoursInFile);
                writer.WriteLine(timeInFile.MinutesInFile);
                writer.WriteLine(timeInFile.SecondsInFile);
            }
        }
    }
}
