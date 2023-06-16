using HoursOfProgramming.Model.Data;

namespace HoursOfProgramming.Model.ExitApplication
{
    /// <summary>
    /// Производит подсчет времени в файле 
    /// с помощью класса DataTime.
    /// </summary>
    public class TimeRecording
    {
        private TimeInFile _timeInFile;
        private TimeInApp _timeInApp;

        public TimeRecording(TimeInFile timeInFile, TimeInApp timeInApp)
        {
            _timeInFile = timeInFile;
            _timeInApp = timeInApp;
        }

        /// <summary>
        /// Считает и записывает время в файл.
        /// </summary>
        public void ProduceRecord()
        {
            var data = new DataTime(_timeInFile, _timeInApp);
            _timeInFile = data.Recalculating();
            data.Writing();
        }
    }
}
