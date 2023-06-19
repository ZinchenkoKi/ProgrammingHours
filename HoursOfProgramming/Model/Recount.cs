using HoursOfProgramming.View;

namespace HoursOfProgramming.Model
{
    public class Recount : IRecount
    {
        private ICorrect _correct;

        public Recount(ICorrect correct)
        {
            _correct = correct;
        }

        public ITimeData Recalculate(ITimeData timeInApp, ITimeData timeInFile)
        {
            timeInFile = Sum(timeInApp, timeInFile);
            if (_correct.IsCorrect(timeInFile.Seconds))
            {
                timeInFile.Minutes += timeInFile.Seconds / 60;
                timeInFile.Seconds = timeInFile.Seconds % 60;
            }
            else if (_correct.IsCorrect(timeInFile.Minutes))
            {
                timeInFile.Hours += timeInFile.Minutes / 60;
                timeInFile.Minutes = timeInFile.Minutes % 60;
            }
            return timeInFile;
        }

        private ITimeData Sum(ITimeData timeInApp, ITimeData timeInFile)
        {
            timeInFile.Seconds += timeInApp.Seconds;
            timeInFile.Minutes += timeInApp.Minutes;
            timeInFile.Hours += timeInApp.Hours;
            return timeInFile;
        }
    }
}
