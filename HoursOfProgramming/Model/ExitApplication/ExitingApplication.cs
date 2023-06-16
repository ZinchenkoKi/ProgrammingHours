using System.Windows.Forms;
using HoursOfProgramming.Model.Data;

namespace HoursOfProgramming.Model.ExitApplication
{
    /// <summary>
    /// Класс сохраняет показания таймера и после закрывает приложение.
    /// </summary>
    public class ExitingApplication
    {
        private TimeInFile _timeInFile;
        private TimeInApp _timeInApp;

        public ExitingApplication(TimeInFile timeInFile, TimeInApp timeInApp)
        {
            _timeInFile = timeInFile;
            _timeInApp = timeInApp;
        }

        public void GoOut()
        {
            var metrics = new TimeRecording(_timeInFile, _timeInApp);
            metrics.ProduceRecord();
            Application.Exit();
        }
    }
}
