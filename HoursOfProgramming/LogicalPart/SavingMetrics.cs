using HoursOfProgramming.ChangingFile;
using HoursOfProgramming.TimerData;

namespace HoursOfProgramming.LogicalPart
{

    public class SavingMetrics
    {
        ReadingFile reading = new ReadingFile();
        WritingFile writing = new WritingFile();
        RecalculatingTimeFile recalculating = new RecalculatingTimeFile();

        public void Save(TimeInFile timeInFile, TimeInApp timeInApp, string path)
        {
            reading.Reading(timeInFile, path);
            Sum(timeInFile, timeInApp);
            recalculating.Recalculating(timeInFile);
            writing.Writing(timeInFile, path);
        }

        private TimeInFile Sum(TimeInFile timeInFile, TimeInApp timeInApp)
        {
            timeInFile.SecondsInFile += timeInApp.SecondsInApp;
            timeInFile.MinutesInFile += timeInApp.MinutesInApp;
            timeInFile.HoursInFile += timeInApp.HoursInApp;
            return timeInFile;
        }
    }
}
