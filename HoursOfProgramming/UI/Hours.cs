using HoursOfProgramming.DomainModel;
using HoursOfProgramming.Presentation;
using System.Windows.Forms;

namespace HoursOfProgramming.UI
{
    public class Hours
    {
        private TimeInFile _timeInFile;
        public Hours(TimeInFile timeInFile)
        {
            _timeInFile = timeInFile;
        }

        public void Get(Label allHours)
        {
            var path = new DataPath();
            var file = new Data(_timeInFile);
            _timeInFile = file.Reading(path.GetPath());
            allHours.Text = _timeInFile.HoursInFile.ToString();
        }
    }
}
