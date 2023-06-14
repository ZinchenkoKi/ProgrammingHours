using HoursOfProgramming.ChangingFile;
using HoursOfProgramming.TimerData;
using System.Windows.Forms;

namespace HoursOfProgramming.VsualPart
{
    public class OutputAllHours
    {
        public void Output(TimeInFile timeInFile, Label allHours)
        {
            PathFile.Path path = new PathFile.Path();
            ReadingFile reading = new ReadingFile();
            reading.Reading(timeInFile, path.GettingPath());
            allHours.Text = timeInFile.HoursInFile.ToString();
        }
    }
}
