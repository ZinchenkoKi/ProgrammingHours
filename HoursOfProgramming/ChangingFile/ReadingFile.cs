using System;
using System.IO;
using HoursOfProgramming.TimerData;

namespace HoursOfProgramming.ChangingFile
{
    public class ReadingFile
    {
        public void Reading(TimeInFile timeInFile, string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                timeInFile.HoursInFile = Convert.ToInt32(reader.ReadLine());
                timeInFile.MinutesInFile = Convert.ToInt32(reader.ReadLine());
                timeInFile.SecondsInFile = Convert.ToInt32(reader.ReadLine());
            }
        }
    }
}
