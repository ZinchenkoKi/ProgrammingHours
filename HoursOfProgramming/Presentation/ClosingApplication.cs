using System.Windows.Forms;
using HoursOfProgramming.DomainModel;

namespace HoursOfProgramming.Presentation
{
    public class ClosingApplication
    {
        private TimeInFile _timeInFile;
        private TimeInApp _timeInApp;

        public ClosingApplication(TimeInFile timeInFile, TimeInApp timeInApp)
        {
            _timeInFile = timeInFile;
            _timeInApp = timeInApp;
        }

        public void Close(TimeInApp timeInApp)
        {
            var path = new DataPath();
            var metrics = new SavingMetrics(_timeInFile, _timeInApp);
            metrics.Save(path.GetPath());
            Application.Exit();
        }
    }
}
